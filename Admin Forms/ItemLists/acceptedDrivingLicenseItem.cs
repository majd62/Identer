using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Identer.Cards_Designs;

namespace Identer.Admin_Forms
{
    public partial class acceptedDrivingLicenseItem : UserControl
    {
        public acceptedDrivingLicenseItem()
        {
            InitializeComponent();
        }
        #region Properties
        private string _idNumber;
        private string _firstName;
        private string _lastName;
        private string _dateOfBirth;
        private string _address;
        private string _index;
        private string _imagePath;
        private string _degree;
        private string _cause;
        private string _imageFilePath;
        private string _iconImage;
        private Color _backColor;

        [Category("Custom Props")]
        public Color panelBackColor
        {
            get { return _backColor; }
            set { _backColor = value; panel1.BackColor = value; }
        }

        [Category("Custom Props")]
        public string IconPath
        {
            get { return _iconImage; }
            set { _iconImage = value; pictureBox1.Image = Image.FromFile(value); }
        }
        [Category("Custom Props")]
        public string cause
        {
            get { return _cause; }
            set { _cause = value; causelbl.Text = value; }
          
        }


        [Category("Custom Props")]
        public string IdNumber
        {
            get { return _idNumber; }
            set { _idNumber = value; idNumberlbl.Text = value; }
        }

        [Category("Custom Props")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; firstNamelbl.Text = value; }
        }

        [Category("Custom Props")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; lastNamelbl.Text = value; }
        }

        [Category("Custom Props")]
        public string Degree
        {
            get { return _degree; }
            set { _degree = value; degreeLbl.Text = value; }
        }

        [Category("Custom Props")]
        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; dateOfBirthlbl.Text = value; }
        }

        [Category("Custom Props")]
        public string Address
        {
            get { return _address; }
            set { _address = value; addresslbl.Text = value; }
        }

        [Category("Custom Props")]
        public string ImageFilepath
        {
            get { return _imageFilePath; }
            set { _imageFilePath = value; }
        }

        [Category("Custom Props")]
        public string Imagepath
        {
            get { return _imagePath; }
            set { _imagePath = value; pictureBox.Image = Image.FromFile(value); }
        }

        [Category("Custom Props")]
        public string Index
        {
            get { return _index; }
            set { _index = value; indexlbl.Text = value; }
        }
        #endregion

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (_backColor == Color.LightPink)
            {
                Edit ed = new Edit(_idNumber, "DrivingLicense");
                ed.Show();
            }
            else if (_backColor == Color.Aqua)
            {
                Edit ed = new Edit(_idNumber, "CruiseLicense");
                ed.Show();
            }
            else if (_backColor == Color.Green)
            {

                Edit ed = new Edit(_idNumber, "WeaponLicense");
                ed.Show();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_backColor == Color.LightPink)
            {
                Xml.deleteOldLicense(_idNumber, "DrivingLicense", degreeLbl.Text);
                if (Xml.checkIfExist(@".\data\Accepted.Xml", _idNumber, "DrivingLicense"))
                {
                    DrivingLicenseDesign dld = new DrivingLicenseDesign(_idNumber, _degree, _imagePath);
                    dld.Show();
                }
            }
            else if (_backColor == Color.Aqua)
            {
                Xml.deleteOldLicense(_idNumber, "CruiseLicense", degreeLbl.Text);
                if (Xml.checkIfExist(@".\data\Accepted.Xml", _idNumber, "CruiseLicense"))
                {
                    CruiseLicenseDesign cld = new CruiseLicenseDesign(_idNumber, _degree, _imagePath);
                    cld.Show();
                }
            }
            else if (_backColor == Color.Green)
            {
                Xml.deleteOldLicense(_idNumber, "WeaponLicense", degreeLbl.Text);
            }

            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            //  Xml.RemoveDegree(_idNumber, _degree, "DrivingLicense");
        }
    }


}

