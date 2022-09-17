using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identer.User_Forms
{
    public partial class CreateId : Form
    {
        private Boolean Picflag = false;
        private int ageInDays = 16 * 365;
        private string imgPath = "";
        private string idNumber;
        public static Panel panel2;
       

        public CreateId(string idNumber)
        {
            InitializeComponent();
            this.idNumber = idNumber;
            idNumberTxt.Text = idNumber;
            idNumberTxt.Enabled = false;
        }
       

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //check all input data
            Boolean checkFlag = true;
            if (CheckInput.check(firstNameTxt.Text, "Name"))
                errorProvider1.Clear();
            else
            {
                errorProvider1.SetError(firstNameTxt, "first Name is not valid");
                checkFlag = false;
            }

            if (CheckInput.check(fatherNameTxt.Text, "Name"))
                errorProvider2.Clear();
            else
            {
                errorProvider2.SetError(fatherNameTxt, "Father Name is not valid");
                checkFlag = false;
            }

            if (CheckInput.check(gfatherNameTxt.Text, "Name"))
                errorProvider3.Clear();
            else
            {
                errorProvider3.SetError(gfatherNameTxt, "Grand Father Name is not valid");
                checkFlag = false;
            }

            if (CheckInput.check(lastNameTxt.Text, "Name"))
                errorProvider4.Clear();
            else
            {
                errorProvider4.SetError(lastNameTxt, "Last Name is not valid");
                checkFlag = false;
            }

            if (CheckInput.check(motherNameTxt.Text, "Name"))
                errorProvider5.Clear();
            else
            {
                errorProvider5.SetError(motherNameTxt, "Mother Name is not valid");
                checkFlag = false;
            }

            if (CheckInput.check(addressTxt.Text, "Address"))
                errorProvider7.Clear();
            else
            {
                errorProvider7.SetError(addressTxt, "Adrress is not valid");
                checkFlag = false;
            }



            if (CheckInput.check(dateTimeCreateId.Value, ageInDays))
                errorProvider10.Clear();
            else
            {
                errorProvider10.SetError(dateTimeCreateId, "Date is not valid");
                checkFlag = false;
            }
            if (Picflag) errorProvider9.Clear();
            else
            {
                errorProvider9.SetError(pictureBox, "You need to pick a picture!");
                checkFlag = false;
            }

            //if there is no error
            if (checkFlag)
            {

                string gender = maleRb.Checked ? maleRb.Text : femaleRb.Text;
                User person = new User();
                person.userId = idNumber;
                person.FirstName = firstNameTxt.Text;
                person.LastName = lastNameTxt.Text;
                person.FatherName = fatherNameTxt.Text;
                person.MotherName = motherNameTxt.Text;
                person.GfatherName = gfatherNameTxt.Text;
                person.DateOfBirth = dateTimeCreateId.Value.ToString("dd/MM/yyyy").Replace('-', '/');
                person.ImagePath = imgPath;
                person.Address = addressTxt.Text;
                person.Gender = gender;

                Xml.AddNewUser(person);
                PaymentMethod pm = new PaymentMethod("idCard", idNumber)
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
        //to insert image 
        private void uploadPicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = dialog.FileName;
                Bitmap image = new Bitmap(dialog.FileName);
                pictureBox.Image = image;
                Picflag = true;
            }
        }
        //web cam
        private void takePicBtn_Click(object sender, EventArgs e)
        {
            using (cameraForm form2 = new cameraForm())
            {
                form2.ShowDialog();

                if (form2.TheValue() != null)
                {
                    imgPath = @".\data\PersonalImages\" + idNumberTxt.Text + ".png";
                    pictureBox.Image = form2.TheValue();
                    pictureBox.Image.Save(imgPath);                   
                    Picflag = true;
                }
            }
        }
    }
}
