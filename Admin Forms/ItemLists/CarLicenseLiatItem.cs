using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identer.Admin_Forms
{
    public partial class CarLicenseLiatItem : UserControl
    {
        public CarLicenseLiatItem()
        {
            InitializeComponent();
        }
        #region Properties
        private string _CarOwn;
        private string _IdNumber;
        private string _Address;
        private string _carNum;
        private string _Vehicles;
        private string _YearOfCarProduction;
        private string _gasComb;
        private string _Chassisnumbe;
        private string _Engineproduct;
        private string _Color;
        private string _propulsion;
        private string _Fronttire;
        private string _Reartire;
        private string _TheHook;
        private string _Previousowners;
        private string _Enginenumber;
        private string _totalweight;
        private string _Powerhp;
        private string _volume;
        private string _ABS;
        private string _Index;

        [Category("Custom Props")]
        public string IdNumber
        {
            get { return _IdNumber; }
            set { _IdNumber = value; label1.Text = value; }
        }

        [Category("Custom Props")]
        public string CarOwner
        {
            get { return _CarOwn; }
            set { _CarOwn = value; label2.Text = value; }
        }

        [Category("Custom Props")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; label3.Text = value; }
        }

        [Category("Custom Props")]
        public string CarNum
        {
            get { return _carNum; }
            set { _carNum = value; label4.Text = value; }
        }
        [Category("Custom Props")]
        public string Vehicles
        {
            get { return _Vehicles; }
            set { _Vehicles = value; label5.Text = value; }
        }
        [Category("Custom Props")]
        public string YearOfCarProduction
        {
            get { return _YearOfCarProduction; }
            set { _YearOfCarProduction = value; label6.Text = value; }
        }
        [Category("Custom Props")]
        public string GasComb
        {
            get { return _gasComb; }
            set { _gasComb = value; label7.Text = value; }
        }
        [Category("Custom Props")]
        public string Chassisnumbe
        {
            get { return _Chassisnumbe; }
            set { _Chassisnumbe = value; label8.Text = value; }
        }
        [Category("Custom Props")]
        public string Engineproduct
        {
            get { return _Engineproduct; }
            set { _Engineproduct = value; label9.Text = value; }
        }
        [Category("Custom Props")]
        public string CarColor
        {
            get { return _Color; }
            set { _Color = value; label10.Text = value; }
        }
        [Category("Custom Props")]
        public string propulsion
        {
            get { return _propulsion; }
            set { _propulsion = value; label11.Text = value; }
        }
        [Category("Custom Props")]
        public string Fronttire
        {
            get { return _Fronttire; }
            set { _Fronttire = value; label12.Text = value; }
        }
        [Category("Custom Props")]
        public string Reartire
        {
            get { return _Reartire; }
            set { _Reartire = value; label13.Text = value; }
        }
        [Category("Custom Props")]
        public string TheHook
        {
            get { return _TheHook; }
            set { _TheHook = value; label14.Text = value; }
        }
        [Category("Custom Props")]
        public string Previousowners
        {
            get { return _Previousowners; }
            set { _Previousowners = value; label15.Text = value; }
        }
        [Category("Custom Props")]
        public string Enginenumber
        {
            get { return _Enginenumber; }
            set { _Enginenumber = value; label16.Text = value; }
        }
        [Category("Custom Props")]
        public string totalweight
        {
            get { return _totalweight; }
            set { _totalweight = value; label17.Text = value; }
        }
        [Category("Custom Props")]
        public string Powerhp
        {
            get { return _Powerhp; }
            set { _Powerhp = value; label18.Text = value; }
        }
        [Category("Custom Props")]
        public string Volume
        {
            get { return _volume; }
            set { _volume = value; label19.Text = value; }
        }
        [Category("Custom Props")]
        public string ABS
        {
            get { return _ABS; }
            set { _ABS = value; label20.Text = value; }
        }
        [Category("Custom Props")]
        public string Index
        {
            get { return _Index; }
            set { _Index = value; indexlbl.Text = value; }
        }
        #endregion

        private void acceptDLBtn_Click(object sender, EventArgs e)
        {
            Requests.acceptRequest(_IdNumber, int.Parse(_Index), @".\data\CarLRequests.Xml", "CarLicense");
        }
    }
}
