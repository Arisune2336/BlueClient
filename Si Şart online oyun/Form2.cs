using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthGG;
using System.Runtime.InteropServices;

namespace Si_Şart_online_oyun
{
    public partial class Form2 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
             
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (API.Register(username.Text, password.Text, email.Text, license.Text))
            {
                MessageBox.Show("Başarıyla Üye Oldunuz Artık Giriş Yapa Bilirsiniz!", "Üye Ol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Kullanıcı Adı")
            {
                username.Text = "";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Şifre")
            {
                password.Text = "";
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
            }
        }

        private void license_Enter(object sender, EventArgs e)
        {
            if (license.Text == "License")
            {
                license.Text = "";
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if(username.Text == "")
            {
                username.Text = "Kullanıcı Adı";
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.UseSystemPasswordChar = false;
                password.Text = "Şifre";
                password.UseSystemPasswordChar = false;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if(email.Text == "")
            {
                email.Text = "Email";
            }
        }

        private void license_Leave(object sender, EventArgs e)
        {
            if (license.Text == "")
            {
                license.Text = "License";
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
