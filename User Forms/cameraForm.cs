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
    public partial class cameraForm : Form
    {
        private Boolean flag = false;
        WebCam webcam;

        public cameraForm()
        {
            InitializeComponent();
        }
        //take picture button
        private void takePicBtn_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
            confirmBtn.Enabled = true;
        }

        //confirm the taken picture
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            flag = true;
            pictureBox2.Image.Save(@".\data\PersonalImages\MYPIC.png");
            webcam.Stop();
            Hide();
        }
        
        //cancel button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            Hide();
        }

        public Image TheValue()
        {
            if (flag)
                return pictureBox2.Image;
            return null;
        }

        //start the web-cam
        private void cameraForm_Load_1(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
            webcam.Start();
        }
    }
}
