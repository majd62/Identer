using Identer.Admin_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identer.Admin_Login
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public object AdminMain { get; private set; }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (Xml.CheckAdmin(userTxt.Text, passwordTxt.Text))
            {
                AlertClass.success("wow!");
                Hide();
                AdminMenu adm = new AdminMenu();
                adm.Show();
            }
            else AlertClass.Info("enta homara?");
        }

        private void UserLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
