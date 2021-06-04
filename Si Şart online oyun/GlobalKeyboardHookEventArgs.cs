using System;
using System.ComponentModel;

namespace SnagFree.TrayApp.Core
{
	// Token: 0x02000002 RID: 2
	internal class GlobalKeyboardHookEventArgs : HandledEventArgs
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002067 File Offset: 0x00001067
		public GlobalKeyboardHook.KeyboardState KeyboardState { get; private set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002070 File Offset: 0x00001070
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002087 File Offset: 0x00001087
		public GlobalKeyboardHook.LowLevelKeyboardInputEvent KeyboardData { get; private set; }

		// Token: 0x06000005 RID: 5 RVA: 0x00002090 File Offset: 0x00001090
		public GlobalKeyboardHookEventArgs(GlobalKeyboardHook.LowLevelKeyboardInputEvent keyboardData, GlobalKeyboardHook.KeyboardState keyboardState)
		{
			this.KeyboardData = keyboardData;
			this.KeyboardState = keyboardState;
		}
	}
}
