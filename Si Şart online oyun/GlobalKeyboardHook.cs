using System;
using System.Runtime.InteropServices;

namespace SnagFree.TrayApp.Core
{
	// Token: 0x02000003 RID: 3
	internal class GlobalKeyboardHook : IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000006 RID: 6 RVA: 0x000020AC File Offset: 0x000010AC
		// (remove) Token: 0x06000007 RID: 7 RVA: 0x000020E8 File Offset: 0x000010E8
		public event EventHandler<GlobalKeyboardHookEventArgs> KeyboardPressed;

		// Token: 0x06000008 RID: 8 RVA: 0x00002124 File Offset: 0x00001124
		public GlobalKeyboardHook()
		{
			this._windowsHookHandle = IntPtr.Zero;
			this._user32LibraryHandle = IntPtr.Zero;
			this._hookProc = new GlobalKeyboardHook.HookProc(this.LowLevelKeyboardProc);
			this._user32LibraryHandle = GlobalKeyboardHook.LoadLibrary("User32");
			if (this._user32LibraryHandle == IntPtr.Zero)
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
			}
			else
			{
				this._windowsHookHandle = GlobalKeyboardHook.SetWindowsHookEx(13, this._hookProc, this._user32LibraryHandle, 0);
				if (this._windowsHookHandle == IntPtr.Zero)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021CC File Offset: 0x000011CC
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this._windowsHookHandle != IntPtr.Zero)
				{
					if (!GlobalKeyboardHook.UnhookWindowsHookEx(this._windowsHookHandle))
					{
						int lastWin32Error = Marshal.GetLastWin32Error();
						return;
					}
					this._windowsHookHandle = IntPtr.Zero;
					this._hookProc = (GlobalKeyboardHook.HookProc)Delegate.Remove(this._hookProc, new GlobalKeyboardHook.HookProc(this.LowLevelKeyboardProc));
				}
			}
			if (this._user32LibraryHandle != IntPtr.Zero)
			{
				if (!GlobalKeyboardHook.FreeLibrary(this._user32LibraryHandle))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
				}
				else
				{
					this._user32LibraryHandle = IntPtr.Zero;
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002280 File Offset: 0x00001280
		~GlobalKeyboardHook()
		{
			this.Dispose(false);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022B4 File Offset: 0x000012B4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600000C RID: 12
		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibrary(string lpFileName);

		// Token: 0x0600000D RID: 13
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern bool FreeLibrary(IntPtr hModule);

		// Token: 0x0600000E RID: 14
		[DllImport("USER32", SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, GlobalKeyboardHook.HookProc lpfn, IntPtr hMod, int dwThreadId);

		// Token: 0x0600000F RID: 15
		[DllImport("USER32", SetLastError = true)]
		public static extern bool UnhookWindowsHookEx(IntPtr hHook);

		// Token: 0x06000010 RID: 16
		[DllImport("USER32", SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hHook, int code, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000011 RID: 17 RVA: 0x000022C8 File Offset: 0x000012C8
		public IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam)
		{
			bool flag = false;
			int num = wParam.ToInt32();
			if (Enum.IsDefined(typeof(GlobalKeyboardHook.KeyboardState), num))
			{
				object obj = Marshal.PtrToStructure(lParam, typeof(GlobalKeyboardHook.LowLevelKeyboardInputEvent));
				GlobalKeyboardHook.LowLevelKeyboardInputEvent keyboardData = (GlobalKeyboardHook.LowLevelKeyboardInputEvent)obj;
				GlobalKeyboardHookEventArgs globalKeyboardHookEventArgs = new GlobalKeyboardHookEventArgs(keyboardData, (GlobalKeyboardHook.KeyboardState)num);
				EventHandler<GlobalKeyboardHookEventArgs> keyboardPressed = this.KeyboardPressed;
				keyboardPressed(this, globalKeyboardHookEventArgs);
				flag = globalKeyboardHookEventArgs.Handled;
			}
			return flag ? ((IntPtr)1) : GlobalKeyboardHook.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
		}

		// Token: 0x04000003 RID: 3
		public const int WH_KEYBOARD_LL = 13;

		// Token: 0x04000004 RID: 4
		public const int VkSnapshot = 44;

		// Token: 0x04000005 RID: 5
		private const int KfAltdown = 8192;

		// Token: 0x04000006 RID: 6
		public const int LlkhfAltdown = 32;

		// Token: 0x04000008 RID: 8
		private IntPtr _windowsHookHandle;

		// Token: 0x04000009 RID: 9
		private IntPtr _user32LibraryHandle;

		// Token: 0x0400000A RID: 10
		private GlobalKeyboardHook.HookProc _hookProc;

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000013 RID: 19
		private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x02000005 RID: 5
		public struct LowLevelKeyboardInputEvent
		{
			// Token: 0x0400000B RID: 11
			public int VirtualCode;

			// Token: 0x0400000C RID: 12
			public int HardwareScanCode;

			// Token: 0x0400000D RID: 13
			public int Flags;

			// Token: 0x0400000E RID: 14
			public int TimeStamp;

			// Token: 0x0400000F RID: 15
			public IntPtr AdditionalInformation;
		}

		// Token: 0x02000006 RID: 6
		public enum KeyboardState
		{
			// Token: 0x04000011 RID: 17
			KeyDown = 256,
			// Token: 0x04000012 RID: 18
			KeyUp,
			// Token: 0x04000013 RID: 19
			SysKeyDown = 260,
			// Token: 0x04000014 RID: 20
			SysKeyUp
		}
	}
}
