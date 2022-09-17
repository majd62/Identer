using Identer.Cards_Designs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identer.Admin_Forms
{
      public partial class Edit : Form
    {
        private string cardType;
        private string index;
        private string idNumber;
        
        private string newEdit="";
        private int flag;
        public Edit(string idNumber, string cardType)
        {
            InitializeComponent();
            this.cardType = cardType;
            this.idNumber = idNumber;
        }
        //edit car license by index
        public Edit(string idNumber, string cardType,string _index)
        {
            InitializeComponent();
            this.cardType = cardType;
            this.idNumber = idNumber;
            index = _index;
        }
        //load combo box for all licenses
        private void Edit_Load(object sender, EventArgs e)
        {
            switch (cardType)
            {
                case "idCard":
             
                    comboBox.Items.Add("FirstName");
                    comboBox.Items.Add("FatherName");
                    comboBox.Items.Add("MotherName");
                    comboBox.Items.Add("GfatherName");
                    comboBox.Items.Add("LastName");
                    comboBox.Items.Add("Address");
                    comboBox.Items.Add("Gender");
                    comboBox.Items.Add("ImagePath");
                    break;
                case "DrivingLicense":
                    
                    comboBox.Items.Add("ImagePath");
                   
                    break;
                case "CruiseLicense":
                    
                    comboBox.Items.Add("ImagePath");
                   
                    break;
                case "WeaponLicense":

                    comboBox.Items.Add("ImagePath");

                    break;
                case "CarLicense":
                    comboBox.Items.Add("volumeTxt");
                    comboBox.Items.Add("PowerhpTxt");
                    comboBox.Items.Add("PreviousownersTxt");
                    comboBox.Items.Add("ReartireTxt");
                    comboBox.Items.Add("FronttireTxt");
                    comboBox.Items.Add("ColorText");
                    comboBox.Items.Add("TheHookHauled");
                    break;
            }
        }

        //select specific license to edit on it
        private void comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if the selected control is image
            if (comboBox.SelectedItem.ToString() == "ImagePath")
            {
                pictureBox1.Visible = true;
                insertBtn.Visible = true;
                maleRb.Visible = false;
                femaleRb.Visible = false;
                editedText.Visible = false;
            }
            //if the selected control is radio button (gender select)
            else if (comboBox.SelectedItem.ToString() == "Gender")
            {
                maleRb.Visible = true;
                femaleRb.Visible = true;
                pictureBox1.Visible = false;
                insertBtn.Visible = false;
                editedText.Visible = false;
                flag = 2;
            }
            //if the selected control is Text
            else
            {
                maleRb.Visible = false;
                femaleRb.Visible = false;
                pictureBox1.Visible = false;
                insertBtn.Visible = false;
                editedText.Visible = true;
                flag = 1;
            }
        }
        //edit the data by card type and change it in xml file
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (flag == 1) newEdit = editedText.Text;
            if (flag == 2) newEdit = maleRb.Checked ? maleRb.Text : femaleRb.Text;
           
            switch (cardType)
            {
                case "idCard":
                    Xml.editElement(idNumber, comboBox.SelectedItem.ToString(), newEdit);
                    idCardDesign idCD = new idCardDesign(idNumber);
                    idCD.Show();

                    if (Xml.checkIfExist(@".\data\Accepted.Xml", idNumber, "DrivingLicense"))
                    {
                        DrivingLicenseDesign dld = new DrivingLicenseDesign(idNumber, "", null);
                        dld.Show();
                    }
                    if (Xml.checkIfExist(@".\data\Accepted.Xml", idNumber, "CruiseLicense"))
                    {
                        CruiseLicenseDesign cld = new CruiseLicenseDesign(idNumber, "", null);
                        cld.Show();
                    }
                    if (Xml.checkIfExist(@".\data\Accepted.Xml", idNumber, "WeaponLicense"))
                    {
                        WeaponLicenseDesign cld = new WeaponLicenseDesign(idNumber, null, null, null);
                        cld.Show();
                    }
                    break;
                case "DrivingLicense":
                    {
                        Xml.editElement(idNumber, comboBox.SelectedItem.ToString(), newEdit, "DrivingLicense");
                        if (newEdit != "")
                        {
                            DrivingLicenseDesign dld = new DrivingLicenseDesign(idNumber, "", newEdit);
                            dld.Show();
                        }
                    }
                    break;
                case "CruiseLicense":
                    Xml.editElement(idNumber, comboBox.SelectedItem.ToString(), newEdit, "CruiseLicense");
                    if (newEdit != "")
                    {
                        CruiseLicenseDesign cld = new CruiseLicenseDesign(idNumber, "", newEdit);
                        cld.Show();
                    }
                    break;
                case "WeaponLicense":
                    Xml.editElement(idNumber, comboBox.SelectedItem.ToString(), newEdit, "WeaponLicense");
                    if (newEdit != "")
                    {
                        WeaponLicenseDesign wp = new WeaponLicenseDesign(idNumber, null, newEdit, null);
                        wp.Show();
                    }
                    break;
                case "CarLicense":
                    {
                        Xml.editElement(idNumber, comboBox.SelectedItem.ToString(), newEdit, "CarLicense");
                        if (newEdit != "")
                        {
                            CarLicenseDesign cr = new CarLicenseDesign(idNumber, int.Parse(index));

                            cr.Show();
                        }
                    }
                    break;
                  

            }
            this.Hide();
        }
        //input of image file
        private void insert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                newEdit = dialog.FileName;
                Bitmap image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;                
            }
        }
    }
}


