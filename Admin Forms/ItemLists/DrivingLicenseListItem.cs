using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Identer.Admin_Forms
{
    public partial class DrivingLicenseListItem : UserControl
    {
        public DrivingLicenseListItem()
        {
            InitializeComponent();
            causelbl.Text = "";
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
        private string _weaponType;
        private string _cDegree;
        private string _imageFilePath;
        private Color _backColor;
        private string _cause;

        [Category("Custom Props")]
        public string Cause
        {
            get { return _cause; }
            set { _cause = value; causelbl.Text = value; }
        }

        [Category("Custom Props")]
        public Color panelBackColor
        {
            get { return _backColor; }
            set { _backColor = value; panel1.BackColor = value; }
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
        public string Cdegree
        {
            get { return _cDegree; }
            set { _cDegree = value; degreeLbl.Text = value; }
        }

        [Category("Custom Props")]
        public string WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; degreeLbl.Text = value; }
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
            set { _imageFilePath = value;}
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

   
        private void acceptDLBtn_Click(object sender, EventArgs e)
        {
            if(_degree!=null)
                Requests.acceptRequest(_idNumber, int.Parse(_index), @".\data\DLRequests.Xml", "DrivingLicense");
            else if(_cDegree!=null)
                Requests.acceptRequest(_idNumber, int.Parse(_index), @".\data\CLRequests.Xml", "CruiseLicense");
            else if (_weaponType != null)
                Requests.acceptRequest(_idNumber, int.Parse(_index), @".\data\WLRequests.Xml", "WeaponLicense");
            acceptedMark.Visible = true;
            acceptDLBtn.Enabled = false;
            declinetDLBtn.Enabled = false;
        }

        private void declinetDLBtn_Click(object sender, EventArgs e)
        {
            if (_degree != null)
                Xml.declineRequest(_idNumber, @".\data\DLRequests.Xml");
            else if (_cDegree != null)
                Xml.declineRequest(_idNumber, @".\data\CLRequests.Xml");
            else if (_weaponType != null)
                Xml.declineRequest(_idNumber, @".\data\WLRequests.Xml");

            rejectedMark.Visible = true;
            acceptDLBtn.Enabled = false;
            declinetDLBtn.Enabled = false;
        }

        private void ShowFile_Click(object sender, EventArgs e)
        {
            Process.Start(_imageFilePath);
        }
    }
}
