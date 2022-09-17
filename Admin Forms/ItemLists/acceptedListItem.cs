using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Identer.User_Forms;

namespace Identer.Admin_Forms
{
    public partial class acceptedListItem : UserControl
    {
        public acceptedListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _idNumber;
        private string _firstName;
        private string _lastName;
        private string _fatherName;
        private string _motherName;
        private string _gfatherName;
        private string _dateOfBirth;
        private string _address;
        private string _gender;
        private string _index;
        private string _imagePath;


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
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; fatherNamelbl.Text = value; }
        }

        [Category("Custom Props")]
        public string MotherName
        {
            get { return _motherName; }
            set { _motherName = value; motherNamelbl.Text = value; }
        }

        [Category("Custom Props")]
        public string GfatherName
        {
            get { return _gfatherName; }
            set { _gfatherName = value; gfatherNamelbl.Text = value; }
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
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; genderlbl.Text = value; }
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

        private void approve_Click(object sender, EventArgs e)
        {
            // showUsers.editUser(idNumberlbl.Text);
            Edit edt = new Edit(idNumberlbl.Text,"idCard");
            edt.Show();
        }

        private void decline_Click(object sender, EventArgs e)
        {
            showUsers.deleteUser(idNumberlbl.Text);
        }
    }
}
