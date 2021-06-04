﻿using System;
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
    public partial class Form4 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form4()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            guna2TextBox2.Text = User.Username;
            guna2TextBox1.Text = User.Password;
            email.Text = User.Email;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            User.Username = guna2TextBox2.Text;
            User.Password = guna2TextBox1.Text;
            User.Email = email.Text;
            Application.Restart();
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
       

        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
