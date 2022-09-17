using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace Identer.User_Forms.Creaters
{
    public partial class CreateCruiseLicense : Form
    {
        public static Panel panel2;
       
       
        private string myImgPath = "";
        public static string imageFilePath = "";
        
        
        public CreateCruiseLicense(string idNumber)
        {
            InitializeComponent();
        

            User ud = new User();
            ud = Xml.FillData(idNumber);//fill all the data from user id card
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

            if (checkFlag)//there are no errors
            {
               
                    if (imageFilePath == "") imageFilePath = FileNameTxt.Text;
                    Xml.AddLicense(idNumberTxt.Text, degreeComboBox.Text, myImgPath, imageFilePath, "CruiseLicense");
                    PaymentMethod pm = new PaymentMethod("CruiseLicense", idNumberTxt.Text)
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
        //upload image 
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
        //open web cam to take picture
        private void iconButton1_Click(object sender, EventArgs e)
        {
          
               using (cameraForm form2 = new cameraForm())
            {
                form2.ShowDialog();
               
                if (form2.TheValue() != null)
                {
                    
                    myImgPath = @".\data\PersonalImages\" + idNumberTxt.Text + "CL.png";
                    pictureBox.Image = form2.TheValue();
                    pictureBox.Image.Save(myImgPath);
              
                 
                }
            }
        }
        //insert  file
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
         //load form and remove the degrees from combobox
        private void CreateCruiseLicense_Load(object sender, EventArgs e)
        {

           
            XDocument doc = XDocument.Load(@".\data\Accepted.Xml");
            var values =
                from d in doc.Element("Users").Elements("User")
                .Single(c => c.Attribute("idNumber").Value == idNumberTxt.Text)
                .Elements("CruiseLicense")
                .Elements("Degree")
                select d;
            foreach (var d in values)
            {
                degreeComboBox.Items.Remove(d.Value);
            }
        }
    }
}
