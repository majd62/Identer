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
using System.Xml;

namespace Identer.User_Forms.Creaters
{
    public partial class CreateWeaponLicense : Form
    {
        public static Panel panel2;
        private string myImgPath = "";
        public static string imageFilePath = "";
        private string idNumber;
      
        public CreateWeaponLicense(string idNumber)
        {
            InitializeComponent();
     
            this.idNumber = idNumber;

            User ud = new User();
            ud = Xml.FillData(idNumber);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            using (cameraForm form2 = new cameraForm())
            {
                form2.ShowDialog();

                if (form2.TheValue() != null)
                {

                    myImgPath = @".\data\PersonalImages\" + idNumberTxt.Text + "WP.png";
                    pictureBox.Image = form2.TheValue();
                    pictureBox.Image.Save(myImgPath);

             
                }
            }

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Boolean checkFlag = true;
            if (FileNameTxt.Text != "")
                errorProvider1.Clear();
            else
            {
                errorProvider1.SetError(insertFileBtn, "please insert a file");
                checkFlag = false;
            }

            if ((weaponComboBox.SelectedIndex > -1) && (!CheckInput.CheckDegree("WeaponLicence", bdateTP.Value)))
            {
                errorProvider2.Clear();

            }
            else
            {
                errorProvider2.SetError(weaponComboBox, "Please choose a weapon type");
                checkFlag = false;
            }

            if (checkFlag)
            {
             
                PaymentMethod pm;


                if (imageFilePath == "") imageFilePath = FileNameTxt.Text;
                Xml.AddLicence(idNumberTxt.Text, weaponComboBox.Text, causeComboBox.Text, myImgPath, imageFilePath, "WeaponLicense");
                pm = new PaymentMethod("WeaponLicense", idNumberTxt.Text);
                
                pm.TopLevel = false;
                pm.FormBorderStyle = FormBorderStyle.None;
                pm.Dock = DockStyle.Fill;
                panel1.Controls.Add(pm);
                panel1.Tag = pm;
                pm.BringToFront();
                pm.Show();
                panel1.Visible = true;
                panel2 = panel1;
            }
        }

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


        private void CreateWeaponLicense_Load(object sender, EventArgs e)
        {
            


            XDocument doc = XDocument.Load(@".\data\Accepted.Xml");
            var values =
                from d in doc.Element("Users").Elements("User")
                .Single(c => c.Attribute("idNumber").Value == idNumber)
                .Elements("WeaponLicense")
                .Elements("Degree")
                select d;
            foreach (var d in values)
            {
                weaponComboBox.Items.Remove(d.Value);
            }
        }
    }
}
