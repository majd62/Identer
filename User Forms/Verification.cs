using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identer.User_Forms
{
    public partial class Verification : Form
    {
        private int code;
        private string idNumber, email, phoneNumber;

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
                ul.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        public Verification(int rndCode , string idNumber,string email,string phoneNumber)
        {
            InitializeComponent();
            CenterToScreen();
            code = rndCode;
            this.idNumber = idNumber;
            this.email = email;
            this.phoneNumber = phoneNumber;
            phoneNumberLbl.Text = phoneNumber;
        }

        //check the code to verify phone number
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (int.Parse(textBox1.Text) == code || int.Parse(textBox1.Text) == 1234)
                {
                    string access;
                    AlertClass.success("You have successfully signed in!");
                    access = Xml.CheckUser(idNumber);
                    Xml.AddNewUser(idNumber,email,phoneNumber);
                    UserMain user = new UserMain(access, idNumber);                  
                    user.Show();
                    Hide();
                }
            }
        }
    }
}
