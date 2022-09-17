using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Identer.User_Forms
{    
    public partial class CreateDrivingLicense : Form
    {
        public static Panel panel2;

        private string myImgPath;
        public static string imageFilePath = "";
        


        public CreateDrivingLicense(string idNumber)
        {
            InitializeComponent();
           
            User ud = new User();
            ud = Xml.FillData(idNumber); //fill all data from user's id card
            try
            {
                idNumberTxt.Text = idNumber;
                nameTb.Text = ud.FirstName;
                lastNameTxt.Text = ud.LastName;
                addressTxt.Text = ud.Address;
                Bitmap image = new Bitmap(ud.ImagePath);
                pictureBox.Image = image;
                myImgPath = ud.ImagePath;
                bdateTP.Value = DateTime.Parse(ud.DateOfBirth);
            }
            catch (NullReferenceException e)
            {
               AlertClass.Error(e.Message);
            }
       
        }
        
        private void nextBtn_Click(object sender, EventArgs e)
        {
            //check all input data
            Boolean checkFlag = true;
            if (FileNameTxt.Text != "")
                errorProvider1.Clear();
            else
            {
                errorProvider1.SetError(insertFileBtn, "please insert a file");
                checkFlag = false;
            }

            if ((degreeComboBox.SelectedIndex > -1) && (!CheckInput.CheckDegree(degreeComboBox.Text, bdateTP.Value)))
            {
                errorProvider2.Clear();

            }
            else
            {
                errorProvider2.SetError(degreeComboBox, "please choose a degree license");
                checkFlag = false;
            }

            if (checkFlag)//there is no errors
            {
              
                    if (imageFilePath == "") imageFilePath = FileNameTxt.Text;
                    //add the card to xml file
                    Xml.AddLicense(idNumberTxt.Text, degreeComboBox.Text, myImgPath, imageFilePath, "DrivingLicense");
                    PaymentMethod pm = new PaymentMethod("driving license", idNumberTxt.Text)
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };
                    panel1.Controls.Add(pm);
                    panel1.Tag = pm;
                    pm.BringToFront();
                    pm.Show();
                    panel1.Visible = true;
                    panel2 = panel1;
              
            }
        }
        //open web cam
        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            
             using (cameraForm form2 = new cameraForm())
            {
                form2.ShowDialog();
               
                if (form2.TheValue() != null)
                {
                    
                    myImgPath = @".\data\PersonalImages\" + idNumberTxt.Text + "DL.png";
                    pictureBox.Image = form2.TheValue();
                    pictureBox.Image.Save(myImgPath);
              
                    
                }
            }
             
        }
        //insert a image 
        private void uploadPicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                myImgPath = dialog.FileName;
                Bitmap image = new Bitmap(myImgPath);
                pictureBox.Image = image;
                
            }
        }
        //insert file
        private void insertFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = dialog.FileName;            
            
                FileNameTxt.Text = imageFilePath;
                FileNameTxt.Visible = true;
                removeFile2.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //load form and remove all the degrees from the combobox
        private void CreateDrivingLicense_Load(object sender, EventArgs e)
        {
           
            XDocument doc = XDocument.Load(@".\data\Accepted.Xml");
            var values =
                from d in doc.Element("Users").Elements("User")
                .Single(c => c.Attribute("idNumber").Value == idNumberTxt.Text)
                .Elements("DrivingLicense")
                .Elements("Degree")
                select d;
            foreach (var d in values)
            {
                degreeComboBox.Items.Remove(d.Value);
            }
        }
    }


}

