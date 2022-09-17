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
using FontAwesome.Sharp;
using Identer.User_Forms.Creaters;

namespace Identer.User_Forms
{
    public partial class UserMain : Form
    {
        public static Form myForm;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private string idNumber;
        public UserMain(string access,string idNumber)
        {          
            InitializeComponent();
            CenterToScreen();
            this.idNumber = idNumber;
            if (access == "new user")
            {
                drivingBtn.Enabled = false;
                CruiseBtn.Enabled = false;
                weaponBtn.Enabled = false;
                carBtn.Enabled = false;
            }else if(access == "in progress")
            {
                drivingBtn.Enabled = false;
                CruiseBtn.Enabled = false;
                weaponBtn.Enabled = false;
                carBtn.Enabled = false;
                idBtn.Enabled = false;
                AlertClass.Info("Your ID request is still in progress!");
                inProgressPic.Visible = true;
            }
            else
            {
                idBtn.Enabled = false;
            }
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 61);
            panel1.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;         
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(102, 120, 139);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            myForm = this;
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void idBtn_Click(object sender, EventArgs e)
        {
            logoPic.Visible = false;
            welcomelbl.Visible = false;
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CreateId(idNumber));
        }

        private void drivingBtn_Click(object sender, EventArgs e)
        {
            logoPic.Visible = false;
            welcomelbl.Visible = false;
            //check if have a requst in proggress
            string Access = Xml.CheckUser(idNumber, @".\data\DLRequests.Xml");
            if (Access == "")
            {
                ActivateButton(sender, RGBColors.color2);
                OpenChildForm(new CreateDrivingLicense(idNumber));
            }else//in proggress
            {
                inProgressPic.Visible = true;
                drivingBtn.Enabled = false;
            }
           
        }

        private void CruiseBtn_Click(object sender, EventArgs e)
        {
            logoPic.Visible = false;
            welcomelbl.Visible = false;
            string Access = Xml.CheckUser(idNumber, @".\data\CLRequests.Xml");
            if (Access == "")
            {
                ActivateButton(sender, RGBColors.color3);
                OpenChildForm(new CreateCruiseLicense(idNumber));
            }
            else
            {
                inProgressPic.Visible = true;
                CruiseBtn.Enabled = false;
            }
        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            logoPic.Visible = false;
            welcomelbl.Visible = false;
            string Access = Xml.CheckUser(idNumber, @".\data\CarLRequests.Xml");
            if (Access == "")
            {
                ActivateButton(sender, RGBColors.color4);
                OpenChildForm(new CreateCarLicense());
            }
            else
            {
                inProgressPic.Visible = true;
                carBtn.Enabled = false;
            }
        }

        private void weaponBtn_Click(object sender, EventArgs e)
        {
            logoPic.Visible = false;
            welcomelbl.Visible = false;
            string Access = Xml.CheckUser(idNumber, @".\data\WLRequests.Xml");
            if (Access == "")
            {
                ActivateButton(sender, RGBColors.color5);
                OpenChildForm(new CreateWeaponLicense(idNumber));
            }
            else
            {
                inProgressPic.Visible = true;
                weaponBtn.Enabled = false;
            }
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            UserLogin lgn = new UserLogin();
            lgn.Show();
            Hide();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            logoPic.Visible = true;
            welcomelbl.Visible = true;
            inProgressPic.Visible = false;
            if (currentChildForm != null)
            {              
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            logoPic.Visible = false;
            welcomelbl.Visible = false;
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new About());
        }
    }
}
