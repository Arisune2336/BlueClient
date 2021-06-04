using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using AuthGG;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Drawing.Text;
using System.IO.Compression;
using GlobalLowLevelHooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Drawing.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using VimeTeleport2;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GlobalLowLevelHooks;
using System.IO;
using System.Net;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Drawing.Text;
using System.IO.Compression;
using System.IO.Compression;
using WindowsInput;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NetLimiter.Service;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NetLimiter.Service;

namespace Si_Şart_online_oyun
{
    public partial class Main : Form
    {
       


    int JITR = 10;
        Random rnd = new Random();
        public string getjavawTitle()
        {
            Process[] proc = Process.GetProcessesByName("javaw");
            foreach (var process in proc)
            {
                return process.MainWindowTitle;
            }
            return "Bulunamadı";
        }






    [DllImport("user32", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);





        private InputSimulator inps = new InputSimulator();
        InputSimulator input = new InputSimulator();
        public Process crProc;
        private IntPtr[] Founds;
        IntPtr[] wh;
        IntPtr[] ka;
        IntPtr[] r;
        IntPtr[] r4;
        IntPtr[] r3;
        IntPtr[] h1;
        IntPtr[] h2;
        IntPtr[] mg;
        IntPtr[] rc4;
        IntPtr[] rc5;
















        private SoundPlayer _soundplayer;
        KeyboardHook.VKeys currKey1;
        bool setkey1 = false;
        KeyboardHook kh = new KeyboardHook();
        KeyboardHook.VKeys currKey2;
        bool setkey2 = false;
        bool setkey3 = false;
        bool setkey6 = false;
        KeyboardHook.VKeys currKey6;
        bool setkey4 = false;
        bool setkey5 = false;
        bool setkey7 = false;
        bool setkey8 = false;
        bool setkey9 = false;
        KeyboardHook.VKeys currKey9;
        KeyboardHook.VKeys currKey8;
        KeyboardHook.VKeys currKey7;
        KeyboardHook.VKeys currKey5;
        KeyboardHook.VKeys currKey4;

        KeyboardHook.VKeys currKey3;



        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */




        bool suruklenmedurumu = false;
        Point ilkkonum;
        int logId, logStatus;
        string logUsername, logFullname;
        public DataSet ds;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Main()
        {


            InitializeComponent();
            _soundplayer = new SoundPlayer("Sounds.wav");





            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.LIGHT;

            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        
        }
    
        public Panel constet;


        private void keyboardHook_KeyDown(KeyboardHook.VKeys key)
        {

            if (setkey1 == true)
            {
                currKey1 = key;
                string ky = key.ToString();
                guna2Button4.Text = ky.Replace("KEY_", "");
                setkey1 = false;

            }
            else if (key == currKey1)
            {
                if (timer3.Enabled == false)
                {
                    if (soundchecker.Checked == true)
                    {
                        _soundplayer.Play();
                    }
                    timer3.Enabled = true;
                }
                else
                {
                    if (soundchecker.Checked == true)
                    {
                        _soundplayer.Stop();
                    }
                    timer3.Enabled = false;
                }
            }

            if (setkey2 == true)
            {
                currKey2 = key;
                string ky = key.ToString();
                guna2Button5.Text = ky.Replace("KEY_", "");
                setkey2 = false;

            }
            else if (key == currKey2)
            {
                if (timer4.Enabled == false)
                {
                    if (soundchecker.Checked == true)
                    {
                        _soundplayer.Play();
                    }
                    timer4.Enabled = true;
                }
                else
                {
                    if (soundchecker.Checked == true)
                    {
                        _soundplayer.Stop();
                        timer4.Enabled = false;
                    }
                }
            }


            if (setkey3 == true)
            {
                currKey3 = key;
                string ky = key.ToString();
                guna2Button7.Text = ky.Replace("KEY_", "");
                setkey3 = false;

            }
            else if (key == currKey3)
            {
                if (timer5.Enabled == false)
                {
                    timer5.Enabled = true;
                }
                else
                {
                    timer5.Enabled = false;
                }
            }

            if (setkey4 == true)
            {
                currKey4 = key;
                string ky = key.ToString();
                guna2Button6.Text = ky.Replace("KEY_", "");
                setkey4 = false;

            }
            else if (key == currKey4)
            {
                if (timer7.Enabled == false)
                {
                    timer7.Enabled = true;
                }
                else
                {
                    if (timer7.Enabled == true)
                    {
                        timer7.Enabled = false;
                        timer8.Enabled = false;
                    }
                }
            }










            if (setkey5 == true)
            {
                currKey5 = key;
                string ky = key.ToString();
                guna2Button8.Text = ky.Replace("KEY_", "");
                setkey5 = false;

            }
            else if (key == currKey5)
            {
                if (timer11.Enabled == false)
                {
                    timer11.Enabled = true;
                }
                else
                {
                    if (timer11.Enabled == true)
                    {
                        timer11.Enabled = false;
                    }
                }
            }




            if (setkey6 == true)
            {
                currKey6 = key;
                string ky = key.ToString();
                guna2Button9.Text = ky.Replace("KEY_", "");
                setkey6 = false;

            }
            else if (key == currKey6)
            {
                if (timer12.Enabled == false)
                {
                    timer12.Enabled = true;
                }
                else
                {
                    if (timer12.Enabled == true)
                    {
                        timer12.Enabled = false;
                    }
                }
            }



            if (setkey7 == true)
            {
                currKey7 = key;
                string ky = key.ToString();
                guna2Button11.Text = ky.Replace("KEY_", "");
                setkey7 = false;

            }
            else if (key == currKey7)
            {
                if (timer14.Enabled == false)
                {
                    timer14.Enabled = true;
                }
                else
                {
                    if (timer14.Enabled == true)
                    {
                        timer14.Enabled = false;
                    }
                }
            }


            if (setkey8 == true)
            {
                currKey8 = key;
                string ky = key.ToString();
                guna2Button10.Text = ky.Replace("KEY_", "");
                setkey8 = false;

            }
            else if (key == currKey8)
            {
                if (timer15.Enabled == false)
                {
                    timer15.Enabled = true;
                }
                else
                {
                    if (timer15.Enabled == true)
                    {
                        timer15.Enabled = false;
                    }
                }
            }



            if (setkey9 == true)
            {
                currKey9 = key;
                string ky = key.ToString();
                guna2Button12.Text = ky.Replace("KEY_", "");
                setkey9 = false;

            }
            else if (key == currKey9)
            {
                if (timer16.Enabled == false)
                {
                    timer16.Enabled = true;
                }
                else
                {
                    if (timer16.Enabled == true)
                    {
                        timer16.Enabled = false;
                    }
                }
            }





        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




        private void Main_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\" + Environment.UserName + @"\Desktop/CraftRise Launcher.exe");
            kh.KeyDown += keyboardHook_KeyDown;
            kh.Install();
            gunaComboBox2.SelectedItem = "3";
            gunaComboBox1.SelectedItem = "1";

        }




        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            misc1.BackColor = Color.Red;
            chat2.BackColor = Color.FromArgb(35, 35, 35);
            settings3.BackColor = Color.FromArgb(35, 35, 35);
            info4.BackColor = Color.FromArgb(35, 35, 35);
            gunaButton1.BaseColor = Color.FromArgb(25, 25, 25);
            tabControl1.SelectedTab = (tabPage1);
            chat.BaseColor = Color.FromArgb(25, 25, 25);
            info.BaseColor = Color.FromArgb(25, 25, 25);
            settings.BaseColor = Color.FromArgb(25, 25, 25);
            misc.BaseColor = Color.FromArgb(35, 35, 35);
            player.FillColor = Color.FromArgb(35, 35, 35);
            other.BaseColor = Color.FromArgb(25, 25, 25);
            player5.BackColor = Color.FromArgb(35, 35, 35);
            other6.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void chat_Click(object sender, EventArgs e)
        {
            player5.BackColor = Color.FromArgb(35, 35, 35);
            other6.BackColor = Color.FromArgb(35, 35, 35);
            player.FillColor = Color.FromArgb(35, 35, 35);
            tabControl1.SelectedTab = (tabPage2);
            gunaButton1.BaseColor = Color.FromArgb(25, 25, 25);
            other.BaseColor = Color.FromArgb(25, 25, 25);
            misc1.BackColor = Color.FromArgb(35, 35, 35);
            chat2.BackColor = Color.Red;
           settings3.BackColor = Color.FromArgb(35, 35, 35);
            info4.BackColor = Color.FromArgb(35, 35, 35);


            tabControl1.SelectedTab = (tabPage2);
            chat.BaseColor = Color.FromArgb(35, 35, 35);
            info.BaseColor = Color.FromArgb(25, 25, 25);
            settings.BaseColor = Color.FromArgb(25, 25, 25);
            misc.BaseColor = Color.FromArgb(25, 25, 25);
        }

        private void info_Click(object sender, EventArgs e)
        {
            player5.BackColor = Color.FromArgb(35, 35, 35);
            other6.BackColor = Color.FromArgb(35, 35, 35);
            misc1.BackColor = Color.FromArgb(35, 35, 35);
            chat2.BackColor = Color.FromArgb(35, 35, 35);
            player.FillColor = Color.FromArgb(35, 35, 35);
            other.BaseColor = Color.FromArgb(25, 25, 25);
            gunaButton1.BaseColor = Color.FromArgb(25, 25, 25);
            settings3.BackColor = Color.FromArgb(35, 35, 35);
            info4.BackColor = Color.Red;



            tabControl1.SelectedTab = (tabPage4);
            chat.BaseColor = Color.FromArgb(25, 25, 25);
            info.BaseColor = Color.FromArgb(35, 35, 35);
            settings.BaseColor = Color.FromArgb(25, 25, 25);
            misc.BaseColor = Color.FromArgb(25, 25, 25);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            player5.BackColor = Color.FromArgb(35, 35, 35);
            other6.BackColor = Color.FromArgb(35, 35, 35);
            misc1.BackColor = Color.FromArgb(35, 35, 35);
            gunaButton1.BaseColor = Color.FromArgb(25, 25, 25);
            chat2.BackColor = Color.FromArgb(35, 35, 35);
            settings3.BackColor = Color.Red;
            info4.BackColor = Color.FromArgb(35, 35, 35);
            player.FillColor = Color.FromArgb(35, 35, 35);
            other.BaseColor = Color.FromArgb(25, 25, 25);


            tabControl1.SelectedTab = (tabPage3);
            chat.BaseColor = Color.FromArgb(25, 25, 25);
            info.BaseColor = Color.FromArgb(25, 25, 25);
            settings.BaseColor = Color.FromArgb(35, 35, 35);
            misc.BaseColor = Color.FromArgb(25, 25, 25);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chat_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void misc_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void chat_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            username.Text = User.Username;
            expiry.Text = User.Expiry;
            gunaLabel15.Text = "Şifre :" + User.Password;
            gunaLabel16.Text = "ID: " + User.ID;
            gunaLabel14.Text = "Kullanıcı Adı: " + User.Username;
            gunaLabel17.Text = "Email: " + User.Email;
            gunaLabel18.Text = "HWID: " + User.HWID;
            gunaLabel21.Text = "IP: " + User.IP;
            gunaLabel19.Text = "Lisans Bitme Tarihi: " + User.Expiry;
            gunaLabel22.Text = "Last Login: " + User.LastLogin;
            gunaLabel20.Text = "Register Date: " + User.RegisterDate;
        }

        private void chat_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void chat_Move(object sender, EventArgs e)
        {
         
        }

        private void chat_Leave(object sender, EventArgs e)
        {
          
        }

        private void chat_DragEnter(object sender, DragEventArgs e)
        {
          
        }

        private void misc_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
         
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text == "Bir Mesaj Gönder")
            {
                guna2TextBox1.Text = "";
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.Text = "Bir Mesaj Gönder";
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            gunaLabel1.BackColor = Color.Blue;
            timer10.Start();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCxy50XUA-MtxI2lhybbVJzQ");
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            chat.PerformClick();
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            gunaLabel1.BackColor = Color.Blue;
            timer10.Start();
           
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            chat.PerformClick();
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCxy50XUA-MtxI2lhybbVJzQ");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
           
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == false)
            {
                soundchecker.Checked = false;
            }
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gunaLabel9.Text = guna2TrackBar1.Value.ToString();
        }


  

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked == true)
            {
                if(guna2CheckBox13.Checked == true)
                {
                    int mX = MousePosition.X;
                    int mY = MousePosition.Y;
                    int randx = rnd.Next(1, JITR);
                    int randy = rnd.Next(1, JITR);
                    Cursor.Position = new Point(mX - randx, mY - randy);
                }
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    int maxValue = 1000 / this.player.Value;
                    timer3.Interval = maxValue;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == false)
            {
                soundchecker.Checked = false;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.guna2Button4.Text = "Prees...";
            this.setkey1 = true;
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void info4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settings3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chat2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void misc1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void expiry_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2TrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            guna2HtmlLabel5.Text = "Cps: " + player.Value.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true)
            {
                if (guna2CheckBox13.Checked == true)
                {
                    int mX = MousePosition.X;
                    int mY = MousePosition.Y;
                    int randx = rnd.Next(1, JITR);
                    int randy = rnd.Next(1, JITR);
                    Cursor.Position = new Point(mX - randx, mY - randy);
                }
                mouse_event(8, 0, 0, 0, 0);
                mouse_event(16, 0, 0, 0, 0);
                int maxValue = 1000 / this.player.Value;
                timer4.Interval = maxValue;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            guna2Button5.Text = "Press...";
            this.setkey2 = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if(guna2CheckBox3.Checked == true)
            {
                bool flag = Control.MouseButtons == MouseButtons.Left;
                if (flag)
                {
                    int maxValue = 15 + this.guna2TrackBar3.Value;
                    timer5.Interval = maxValue;
                    timer6.Interval = maxValue;
                    SendKeys.Send(gunaComboBox2.SelectedItem.ToString());
                    mouse_event(8, 0, 0, 0, 0);
                    mouse_event(16, 0, 0, 0, 0);
                    timer5.Stop();
                    timer6.Start();
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(gunaComboBox1.SelectedItem.ToString());
            timer5.Start();
            timer6.Stop();
        }

        private void guna2TrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            guna2TrackBar3.Minimum = 30;
            guna2HtmlLabel6.Text = guna2TrackBar3.Value.ToString();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Button7.Text = "Press...";
            this.setkey3 = true;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if(guna2CheckBox4.Checked == true)
            {
                int maxValue = -20 + this.guna2TrackBar3.Value;
                timer7.Interval = maxValue;
                SendKeys.Send(gunaComboBox2.Text);
                mouse_event(8, 0, 0, 0, 0);
                mouse_event(16, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(50);
                SendKeys.Send(gunaComboBox1.Text);
            }
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.setkey4 = true;
            guna2Button6.Text = "Press...";
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(gunaComboBox1.SelectedItem.ToString());


            timer9.Stop();
            timer7.Start();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void gunaLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void gunaLabel1_Leave(object sender, EventArgs e)
        {
            gunaLabel1.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void timer10_Tick_1(object sender, EventArgs e)
        {
            Clipboard.SetText(gunaLabel1.Text);
            gunaLabel1.BackColor = Color.FromArgb(20, 20, 20);
            timer10.Stop();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            misc1.BackColor = Color.FromArgb(35, 35, 35);
            chat2.BackColor = Color.FromArgb(35, 35, 35);
            settings3.BackColor = Color.FromArgb(35, 35, 35);
            info4.BackColor = Color.FromArgb(35, 35, 35);

            tabControl1.SelectedTab = (tabPage5);
            chat.BaseColor = Color.FromArgb(25, 25, 25);
            info.BaseColor = Color.FromArgb(25, 25, 25);
            settings.BaseColor = Color.FromArgb(25, 25, 25);
            misc.BaseColor = Color.FromArgb(25, 25, 25);
            player.FillColor = Color.FromArgb(35, 35, 35);
            gunaButton1.BaseColor = Color.FromArgb(35, 35, 35);
            other.BaseColor = Color.FromArgb(25, 25, 25);
            player5.BackColor = Color.Red;
            other6.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void other_Click(object sender, EventArgs e)
        {
            misc1.BackColor = Color.FromArgb(35, 35, 35);
            chat2.BackColor = Color.FromArgb(35, 35, 35);
            settings3.BackColor = Color.FromArgb(35, 35, 35);
            info4.BackColor = Color.FromArgb(35, 35, 35);

            tabControl1.SelectedTab = (tabPage6);
            chat.BaseColor = Color.FromArgb(25, 25, 25);
            info.BaseColor = Color.FromArgb(25, 25, 25);
            settings.BaseColor = Color.FromArgb(25, 25, 25);
            gunaButton1.BaseColor = Color.FromArgb(25, 25, 25);
            misc.BaseColor = Color.FromArgb(25, 25, 25);
            player.FillColor = Color.FromArgb(35, 35, 35);
            other.BaseColor = Color.FromArgb(35, 35, 35);
            player5.BackColor = Color.FromArgb(35, 35, 35);
            other6.BackColor = Color.Red;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if(guna2CheckBox5.Checked == true)
            {
                timer11.Interval = guna2TrackBar2.Value;
                SendKeys.Send("s");
                SendKeys.Send("w");
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.setkey5 = true;
            guna2Button8.Text = "Press...";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.setkey6 = true;
            guna2Button9.Text = "Press...";
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            if (guna2CheckBox6.Checked = true)
            {
                Random rnd = new Random();
                int RastgeleSayi1 = rnd.Next(100, 999);
                SendKeys.Send("t");
                Thread.Sleep(100);
                SendKeys.Send(guna2TextBox2.Text);
                SendKeys.Send(" " + RastgeleSayi1 + "");
                SendKeys.Send("{Enter}");
            }
        }

        private void guna2CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox7.Checked == true)
            {
                Process.Start("enthernet.bat");
            }
        }

        private void guna2CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox8.Checked == true)
            {
                Process.Start("FPS Boost.bat");
                timer13.Start();
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
            SendKeys.Send("{Enter}");
            SendKeys.Send("{Enter}");
            SendKeys.Send("{Enter}");
            SendKeys.Send("{Enter}");
            timer13.Stop();
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            if(guna2CheckBox10.Checked == true)
            {
                int timerhizi;
                timerhizi = guna2TrackBar4.Value;
                timer14.Interval = timerhizi;
                inps.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_W);
                inps.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.VK_W);
            }    
        }

        private void guna2TrackBar4_Scroll(object sender, ScrollEventArgs e)
        {
            guna2HtmlLabel10.Text = guna2TrackBar4.Value.ToString();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            guna2Button11.Text = "Press...";
            this.setkey7 = true;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            guna2Button10.Text = "Press...";
            this.setkey8 = true;
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            if(guna2CheckBox9.Checked == true)
            {
                int timerhizi;
                timerhizi = guna2TrackBar5.Value;
                timer15.Interval = timerhizi;
                inps.Mouse.RightButtonClick();
                inps.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.VK_S);
                Thread.Sleep(200);
                inps.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.LSHIFT);
                Thread.Sleep(200);
                inps.Keyboard.KeyUp(WindowsInput.Native.VirtualKeyCode.LSHIFT);
            }
        }

        private void guna2TrackBar5_Scroll(object sender, ScrollEventArgs e)
        {
            guna2HtmlLabel11.Text = guna2TrackBar5.Value.ToString();
        }


        private void guna2CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox11.Checked == true)
            {
                Process[] proc = Process.GetProcessesByName("javaw");
                foreach (var process in proc)
                {
                    SetWindowText(process.MainWindowHandle, gunaTextBox1.Text);
                }
            }
            else
            {
                Process[] proc = Process.GetProcessesByName("javaw");
                foreach (var process in proc)
                {
                    SetWindowText(process.MainWindowHandle, "CraftRise Launcher");
                }
            }
           
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            guna2Button12.Text = "Press...";
            this.setkey9 = true;
        }

        private void AimBot_Tick(object sender, EventArgs e)
        {
                if(guna2CheckBox20.Checked == true)
                {
                timer16.Interval = guna2TrackBar6.Value;

                if (MouseButtons == MouseButtons.Left)
                {
                    mouse_event(8, 0, 0, 0, 0);
                    mouse_event(16, 0, 0, 0, 0);
                }

                }
        }

        private void guna2CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2CheckBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox21.Checked == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void guna2TrackBar6_Scroll(object sender, ScrollEventArgs e)
        {
            guna2HtmlLabel13.Text = guna2TrackBar6.Value.ToString();
        }

        private void checker_CheckedChanged(object sender, EventArgs e)
        {
            if (checker.Checked == true)
            {
                line.Image = rainbow.Image;
                line.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                line.BackColor = Color.White;
                line.Image = line3.Image;
            }
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
               
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCapture.ToggleOut();
        }

        private void guna2TrackBar2_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void timer17_Tick(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }










