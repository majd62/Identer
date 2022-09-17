using Identer.User_Forms.Creaters;
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
    public partial class finish : Form
    {
        public finish()
        {
            InitializeComponent();
        }


        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            UserMain.myForm.Close();
            string access = Xml.CheckUser(UserLogin.idNumber);
            Xml.AddNewUser(UserLogin.idNumber, UserLogin.emailAddress, UserLogin.phoneNumber);
            UserMain user = new UserMain(access, UserLogin.idNumber);
            user.Show();
            Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            UserLogin usrlgn = new UserLogin();
            usrlgn.Show();
            UserMain.myForm.Close();
        }
    }
}
