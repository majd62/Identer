using Identer.Admin_Login;
using Identer.User_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Identer
{   
    public partial class UserLogin : Form
    {
        public static string emailAddress;
        public static string phoneNumber;
        public static string idNumber;

        Random rnd = new Random();
        public static int x, code;
        public UserLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }
     
        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminLogin admin = new AdminLogin();
            admin.Show();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //check all the inputs
            Boolean error = false;
            if (CheckInput.check(idNumberTxt.Text, "ID"))
                errorProvider1.Clear();
            else
            {
                errorProvider1.SetError(idNumberTxt, "ID number is not valid");
                error = true; 
            }

            if (CheckInput.check(emailTxt.Text, "email"))
                errorProvider2.Clear();
            else
            {
                errorProvider2.SetError(emailTxt, "Email is not valid");
                error = true;
            }

            if (CheckInput.check(phoneNumberTxt.Text, "phoneNumber"))
                errorProvider3.Clear();
            else
            {
                errorProvider3.SetError(phoneNumberTxt, "Phone Number is not valid");
                error = true;
            }
            if (!error)//no error inputs
            {
                emailAddress = emailTxt.Text;
                phoneNumber = phoneNumberTxt.Text;
                idNumber = idNumberTxt.Text;
                code = rnd.Next(1000, 9999);
                AlertClass.SendVerifyCode(code.ToString(), int.Parse(phoneNumber));
                Verification verify = new Verification(code, idNumberTxt.Text, emailTxt.Text, phoneNumber);
                verify.Show();
                Hide();
            }
        }   
    }
}
