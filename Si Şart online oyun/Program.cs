using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using NetLimiter.Service;
using Si_Şart_online_oyun;

namespace VimeTeleport2
{
    // Token: 0x02000008 RID: 8
    internal sealed class Program
    {
        // Token: 0x0600002D RID: 45 RVA: 0x00004514 File Offset: 0x00003514
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Программу не удалось запустить т.к. на компьюторе не запущена служба NetLimiter", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            try
            {
                TCapture.GFilter();
            }
            catch
            {
                MessageBox.Show("NetLimiter не активирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vtp.lock");
            try
            {
                StreamWriter streamWriter = new StreamWriter(path);
            }
            catch
            {
                MessageBox.Show("Программа уже открыта в другом окне", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Settings.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            Settings.Save();
            {

            }
        }
    }
}

		// Token: 0x0600002E RID: 46 RVA: 0x000046B0 File Offset: 0x000036B0