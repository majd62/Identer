using Identer.User_Forms.Creaters;
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
using System.Xml;
using System.Xml.Linq;

namespace Identer.User_Forms
{
    public partial class PaymentMethod : Form
    {
       
        private string visaType = "VISA";
        private string cardType;
        private string idNumber;
        public PaymentMethod()
        {
            InitializeComponent();
            masterCardBtn.FlatAppearance.BorderSize = 0;
            masterCardBtn.Enabled = true;
            visaBtn.Enabled = false;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(30);
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(2191);
        }
        public PaymentMethod(string cardType, string idNumber):this()
        {
            this.cardType = cardType;
            this.idNumber = idNumber;
        }
       

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //check all input data
            Boolean checkFlag = true;
            if (CheckInput.IsCreditCardInfoValid(ownerTxt.Text, "name", null))
                errorProvider1.Clear();
            else
            {
                errorProvider1.SetError(ownerTxt, "Owner name is not vaild");
                checkFlag = false;
            }
            if (CheckInput.IsCreditCardInfoValid(cardNum1Txt.Text, "CardNumber", visaBtn))
                errorProvider2.Clear();
            else
            {
                errorProvider2.SetError(cardNum1Txt, "Card Number is not valid");
                checkFlag = false;
            }
            if (CheckInput.checkDatePayment(dateTimePicker1))
                errorProvider3.Clear();
            else
            {
                errorProvider3.SetError(dateTimePicker1, "Please check a vaild Date");
                checkFlag = false;
            }

            if (CheckInput.IsCreditCardInfoValid(cvvTxt.Text, "ccv", null))
                errorProvider4.Clear();
            else
            {
                errorProvider4.SetError(cvvTxt, "cvv is not vail");
                checkFlag = false;
            }
            if (checkFlag)
            {
                string billHtmlCode = htmlPayment.textRender();
              //  AlertClass.success("Payment submitted successfully!");
                switch (cardType)
                {
                    case "idCard":
                        {

                            Xml.AddRequest(@".\data\IdRequests.Xml");
                            string SavePath = @".\data\Bills\ID BILLS\ ID bill - " + idNumber + ".pdf";
                            AlertClass.createPdf(billHtmlCode, @".\data\html\Payment.html", SavePath, "149.99", "תעודת זהות", ownerTxt.Text, visaType, cardNum1Txt.Text);
                            AlertClass.sendEmail(SavePath, "קבלת תשלום תעודת זהות", "תודה שבחרתם להשתמש במערכת שלנו", UserLogin.emailAddress);
                            AlertClass.SendVerifyCode("התשלום בוצע בהצלחה", int.Parse(UserLogin.phoneNumber));                         
                        }break;

                    case "driving license":
                        {
                            Xml.AddRequest(@".\data\DLRequests.Xml");
                            string SavePath = @".\data\Bills\DL BILLS\ Driving License bill - " + idNumber + ".pdf";
                            AlertClass.createPdf(billHtmlCode, @".\data\html\Payment.html", SavePath, "129.99", "רשיון נהיגה", ownerTxt.Text, visaType, cardNum1Txt.Text);
                            AlertClass.sendEmail(SavePath, "קבלת תשלום רשיון נהיגה", "תודה שבחרתם להשתמש במערכת שלנו", UserLogin.emailAddress);
                            AlertClass.SendVerifyCode("התשלום בוצע בהצלחה", int.Parse(UserLogin.phoneNumber));                  
                        }break;

                    case "CruiseLicense":
                        {
                            Xml.AddRequest(@".\data\CLRequests.Xml");
                            string SavePath = @".\data\Bills\CL BILLS\ Cruise License bill - " + idNumber + ".pdf";
                            AlertClass.createPdf(billHtmlCode, @".\data\html\Payment.html", SavePath, "199.99", "רשיון שייט", ownerTxt.Text, visaType, cardNum1Txt.Text);
                            AlertClass.sendEmail(SavePath, "קבלת תשלום רשיון שייט", "תודה שבחרתם להשתמש במערכת שלנו", UserLogin.emailAddress);
                            AlertClass.SendVerifyCode("התשלום בוצע בהצלחה", int.Parse(UserLogin.phoneNumber));
                        }
                        break;

                    case "WeaponLicense":
                        {
                            Xml.AddRequest(@".\data\WLRequests.Xml");
                            string SavePath = @".\data\Bills\WL BILLS\ Weapon License bill - " + idNumber + ".pdf";
                            AlertClass.createPdf(billHtmlCode, @".\data\html\Payment.html", SavePath, "239.99", "רשיון נשק", ownerTxt.Text, visaType, cardNum1Txt.Text);
                            AlertClass.sendEmail(SavePath, "קבלת תשלום רשיון נשק", "תודה שבחרתם להשתמש במערכת שלנו", UserLogin.emailAddress);
                            AlertClass.SendVerifyCode("התשלום בוצע בהצלחה", int.Parse(UserLogin.phoneNumber));
                        }
                        break;

                    case "car license":
                        {
                            Xml.AddRequest(@".\data\CarLRequests.Xml");
                            string SavePath = @".\data\Bills\WL BILLS\ Car License bill - " + idNumber + ".pdf";
                            AlertClass.createPdf(billHtmlCode, @".\data\html\Payment.html", SavePath, "649.99", "רשיון רכב", ownerTxt.Text, visaType, cardNum1Txt.Text);
                            AlertClass.sendEmail(SavePath, "קבלת תשלום רשיון רכב", "תודה שבחרתם להשתמש במערכת שלנו", UserLogin.emailAddress);
                            AlertClass.SendVerifyCode("התשלום בוצע בהצלחה", int.Parse(UserLogin.phoneNumber));                       
                        }
                        break;

                }
                finish fnsh = new finish()
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                panel1.Controls.Add(fnsh);
                panel1.Tag = fnsh;
                fnsh.BringToFront();
                fnsh.Show();
                panel1.Visible = true;
            }
        }
        //back to last form and remove all the data from temp xml file
        private void backBtn_Click(object sender, EventArgs e)
        {
            //File.Delete(@".\data\PersonDataTemp.Xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@".\data\PersonDataTemp.Xml");
            switch (cardType)
            {
                case "idCard":
                    {                        
                        CreateId.panel2.Visible = false;
                        XmlNode t = xmlDoc.SelectSingleNode("/Users/User/FirstName");
                         t.ParentNode.RemoveChild(t);
                         t = xmlDoc.SelectSingleNode("/Users/User/LastName");
                         t.ParentNode.RemoveChild(t);
                         t = xmlDoc.SelectSingleNode("/Users/User/FatherName");
                         t.ParentNode.RemoveChild(t);
                         t = xmlDoc.SelectSingleNode("/Users/User/MotherName");
                         t.ParentNode.RemoveChild(t);
                         t = xmlDoc.SelectSingleNode("/Users/User/GfatherName");
                         t.ParentNode.RemoveChild(t);
                         t = xmlDoc.SelectSingleNode("/Users/User/DateOfBirth");
                         t.ParentNode.RemoveChild(t);
                         t = xmlDoc.SelectSingleNode("/Users/User/ImagePath");
                         t.ParentNode.RemoveChild(t);
                         t = xmlDoc.SelectSingleNode("/Users/User/Address");
                         t.ParentNode.RemoveChild(t);
                         t = xmlDoc.SelectSingleNode("/Users/User/Gender");
                         t.ParentNode.RemoveChild(t);
                        
                        xmlDoc.Save(@".\data\PersonDataTemp.Xml");
                    }
                    break;

                case "driving license":
                    {
                        CreateDrivingLicense.panel2.Visible = false;
                        XmlNode t = xmlDoc.SelectSingleNode("/Users/User/DrivingLicense");
                        t.ParentNode.RemoveChild(t);
                        xmlDoc.Save(@".\data\PersonDataTemp.Xml");
                    }
                        break;
                case "CruiseLicense":
                    {
                        CreateCruiseLicense.panel2.Visible = false;
                        XmlNode t = xmlDoc.SelectSingleNode("/Users/User/CruiseLicense");
                        t.ParentNode.RemoveChild(t);
                        xmlDoc.Save(@".\data\PersonDataTemp.Xml");
                    }
                    break;

                case "WeaponLicense":
                    {
                        CreateWeaponLicense.panel2.Visible = false;
                        XmlNode t = xmlDoc.SelectSingleNode("/Users/User/WeaponLicense");
                        t.ParentNode.RemoveChild(t);
                        xmlDoc.Save(@".\data\PersonDataTemp.Xml");
                    }
                    break;

                case "car license":
                    {
                        CreateCarLicense.panel3.Visible = false;
                        XmlNode t = xmlDoc.SelectSingleNode("/Users/User/CarLicense");
                        t.ParentNode.RemoveChild(t);
                        xmlDoc.Save(@".\data\PersonDataTemp.Xml");
                    }
                    break;
            }
                       
        }
        //visa card button
        private void visaBtn_Click(object sender, EventArgs e)
        {
            visaBtn.FlatAppearance.BorderColor = Color.Green;
            visaBtn.FlatAppearance.BorderSize = 2;
            masterCardBtn.FlatAppearance.BorderSize = 0;
            masterCardBtn.Enabled = true;
            visaBtn.Enabled = false;
            visaType = "VISA";
        }
        //master card button
        private void masterCardBtn_Click(object sender, EventArgs e)
        {
            masterCardBtn.FlatAppearance.BorderColor = Color.Green;
            masterCardBtn.FlatAppearance.BorderSize = 2;
            visaBtn.FlatAppearance.BorderSize = 0;
            masterCardBtn.Enabled = false;
            visaBtn.Enabled = true;
            visaType = "MASTER CARD";
        }
    }
}
