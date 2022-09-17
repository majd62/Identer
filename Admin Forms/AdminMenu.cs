using FontAwesome.Sharp;
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

namespace Identer.Admin_Forms
{
    public partial class AdminMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public AdminMenu()
        {            
            InitializeComponent();
            CenterToScreen();
            countDashboard();            
        }
        private void countDashboard()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 91);
            panel1.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //count requests
            idRequestCounter.Text = Xml.LoadIdsList().Count.ToString();
            dlRequestCounter.Text = Xml.LoadLicensesList("DrivingLicense", @".\data\DLRequests.Xml").Count.ToString();
            blRequestCounter.Text = Xml.LoadLicensesList("CruiseLicense", @".\data\CLRequests.Xml").Count.ToString();

            wlRequestCounter.Text = Xml.LoadLicensesList("WeaponLicense", @".\data\WLRequests.Xml").Count.ToString();
            clRequestCounter.Text = Xml.LoadCarLicensesList().Count.ToString();

            //count accepted
            idAcceptedCounter.Text = Xml.LoadAllUsersList().Count.ToString();
            dlAcceptedCounter.Text = Xml.LoadAllUsersLicenseList("DrivingLicense").Count.ToString();
            wlAcceptedCounter.Text = Xml.LoadAllUsersLicenseList("CruiseLicense").Count.ToString();
            blAcceptedCounter.Text = Xml.LoadAllUsersLicenseList("WeaponLicense").Count.ToString();
            clAcceptedCounter.Text = Xml.LoadAllCarLicenseList().Count.ToString();
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
                currentBtn.BackColor = Color.FromArgb(211, 211, 211);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
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
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //  OpenChildForm(new CreateId(idNumber));
            if (currentChildForm != null)
                currentChildForm.Close();
            this.Controls.Clear();
            this.InitializeComponent();
            countDashboard();
            CreateChart();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new showUsers());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Requests());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new About());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            UserLogin lgn = new UserLogin();
            lgn.Show();
            Hide();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            this.Controls.Clear();
            this.InitializeComponent();
            countDashboard();
            CreateChart();
        }

     

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            CreateChart();
        }
        private void CreateChart()
        {
            requestsChart.Series["Requests"].Points.AddXY("id", idRequestCounter.Text);
            requestsChart.Series["Accepted"].Points.AddXY("id", idAcceptedCounter.Text);

            requestsChart.Series["Requests"].Points.AddXY("Driving License", dlRequestCounter.Text);
            requestsChart.Series["Accepted"].Points.AddXY("Driving License", dlAcceptedCounter.Text);

            requestsChart.Series["Requests"].Points.AddXY("Weapon License", wlRequestCounter.Text);
            requestsChart.Series["Accepted"].Points.AddXY("Weapon License", wlAcceptedCounter.Text);

            requestsChart.Series["Requests"].Points.AddXY("Cruise License", blRequestCounter.Text);
            requestsChart.Series["Accepted"].Points.AddXY("Cruise License", blAcceptedCounter.Text);

            requestsChart.Series["Requests"].Points.AddXY("Car License", clRequestCounter.Text);
            requestsChart.Series["Accepted"].Points.AddXY("Car License", clAcceptedCounter.Text);
        }

        
    }
}
