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

namespace Identer.User_Forms.Creaters
{
    public partial class CreateCarLicense : Form
    {
        public static Panel panel3;
        public CreateCarLicense()
        {
            InitializeComponent();
            IdTxt.Text = UserLogin.idNumber;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
           //check all input data
            Boolean checkFlag = true;
            if (CheckInput.check(CarOwnTxt.Text, "Name"))//1 name
                errorProvider1.Clear();
            else
            {
                errorProvider1.SetError(CarOwnTxt, "owner Name is not valid");
                checkFlag = false;
            }

            if (CheckInput.check(AddressTxt.Text, "Address"))//3 address
                errorProvider3.Clear();
            else
            {
                errorProvider3.SetError(AddressTxt, "address is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(carNumTxt.Text, "Number"))//4n number
                errorProvider4.Clear();
            else
            {
                errorProvider4.SetError(carNumTxt, "Car number is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(VehiclesTxt.Text, "Name"))//5 name
                errorProvider5.Clear();
            else
            {
                errorProvider5.SetError(VehiclesTxt, "Vehicles  is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(ChassisnumbeTxt.Text, "Number"))//8
                errorProvider8.Clear();
            else
            {
                errorProvider8.SetError(ChassisnumbeTxt, "Chassis number is not valid");
                checkFlag = false;
            }


            if (CheckInput.check(EngineproductTxt.Text, "Name"))//9
                errorProvider9.Clear();
            else
            {
                errorProvider9.SetError(EngineproductTxt, "Engine product is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(ColorText.Text, "Name"))//10
                errorProvider10.Clear();
            else
            {
                errorProvider10.SetError(ColorText, "color is not valid");
                checkFlag = false;
            }

            if (CheckInput.check(propulsionTxt.Text, "Name"))//11
                errorProvider11.Clear();
            else
            {
                errorProvider11.SetError(propulsionTxt, "propulsion is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(FronttireTxt.Text, "Address"))//12
                errorProvider12.Clear();
            else
            {
                errorProvider12.SetError(FronttireTxt, "Front tire is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(ReartireTxt.Text, "Address"))//13
                errorProvider13.Clear();
            else
            {
                errorProvider13.SetError(ReartireTxt, "rear tire is not valid");
                checkFlag = false;
            }
            //
            if (CheckInput.check(PreviousownersTxt.Text, "Name"))
                errorProvider14.Clear();
            else
            {
                errorProvider14.SetError(PreviousownersTxt, "Previous owners Name is not valid");
                checkFlag = false;
            }

            if (CheckInput.check(EnginenumberTxt.Text, "Number"))
                errorProvider15.Clear();
            else
            {
                errorProvider15.SetError(EnginenumberTxt, "Engine number is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(totalweightTxt.Text, "Number"))
                errorProvider16.Clear();
            else
            {
                errorProvider16.SetError(totalweightTxt, "total weight is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(PowerhpTxt.Text, "Number"))
                errorProvider17.Clear();
            else
            {
                errorProvider17.SetError(PowerhpTxt, "Power is not valid");
                checkFlag = false;
            }
            if (CheckInput.check(volumeTxt.Text, "Number"))
                errorProvider18.Clear();
            else
            {
                errorProvider18.SetError(volumeTxt, "Motor volume is not valid");
                checkFlag = false;
            }

            if (checkFlag)//there are no errors
            {
                Xml.AddNewCarTemp(IdTxt.Text, "CarLicense", "");//add license to temp xml file
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        Xml.AddNewCarTemp(IdTxt.Text, x.Name, x.Text);
                    }
                    else
                    if (x is ComboBox)
                    {
                        AlertClass.Error("hay " + x.Name + " " + x.Text);
                        Xml.AddNewCarTemp(IdTxt.Text, x.Name, x.Text);
                    }
                }
                string ABS = ABSNoRdBtn.Checked ? ABSNoRdBtn.Text : ABSYesRdBtn.Text;
                Xml.AddNewCarTemp(IdTxt.Text, "ABS", ABS);
                string TheHookHauled = TheHookHauledNoRdBtn.Checked ? TheHookHauledNoRdBtn.Text : TheHookHauledYesRdBtn.Text;
                Xml.AddNewCarTemp(IdTxt.Text, "TheHookHauled", TheHookHauled);

                PaymentMethod pm = new PaymentMethod("car license", IdTxt.Text)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                panel2.Controls.Add(pm);
                panel2.Tag = pm;
                pm.BringToFront();
                pm.Show();
                panel2.Visible = true;
                panel3 = panel2;

            }
        }
    }
}
