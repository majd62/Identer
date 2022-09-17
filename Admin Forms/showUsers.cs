using Identer.User_Forms;
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
    public partial class showUsers : Form
    {
        //create all the lists 
        private static List<User> AllusersList = new List<User>();
        private static List<drivingLicenseUser> AllusersDLList = new List<drivingLicenseUser>();
        private static List<drivingLicenseUser> AllusersCLList = new List<drivingLicenseUser>();
        private static List<drivingLicenseUser> AllusersWLList = new List<drivingLicenseUser>();
        private static List<CarLicenseData> AllusersCarLList = new List<CarLicenseData>();
        public showUsers()
        {
            InitializeComponent();
            //load the lists
            AllusersList = Xml.LoadAllUsersList();
            AllusersDLList = Xml.LoadAllUsersLicenseList("DrivingLicense");
            AllusersCLList = Xml.LoadAllUsersLicenseList("CruiseLicense");
            AllusersWLList = Xml.LoadAllUsersLicenseList("WeaponLicense", "");

            AllusersCarLList = Xml.LoadAllCarLicenseList();
            userItems("");
        }

        public void userItems(string searchId)
        {
            acceptedListItem[] acceptedListItems = new acceptedListItem[AllusersList.Count];
            acceptedDrivingLicenseItem[] acceptedDLListItems = new acceptedDrivingLicenseItem[AllusersDLList.Count];
            acceptedDrivingLicenseItem[] acceptedCLListItems = new acceptedDrivingLicenseItem[AllusersCLList.Count];
            acceptedDrivingLicenseItem[] acceptedWLListItems = new acceptedDrivingLicenseItem[AllusersWLList.Count];
            acceptedCarLicenseListItem[] acceptedCarLListItems = new acceptedCarLicenseListItem[AllusersCarLList.Count];
            AllusersList = Xml.LoadAllUsersList();
            AllusersDLList = Xml.LoadAllUsersLicenseList("DrivingLicense");
            AllusersCLList = Xml.LoadAllUsersLicenseList("CruiseLicense");
            AllusersWLList = Xml.LoadAllUsersLicenseList("WeaponLicense", "");

            AllusersCarLList = Xml.LoadAllCarLicenseList();
            for (int i = 0; i < AllusersList.Count + AllusersWLList.Count + AllusersDLList.Count + AllusersCLList.Count + AllusersCarLList.Count; i++)
            {
                if (searchId == "")
                {
                    if (AllusersList.Count > i)
                        addToPanel(acceptedListItems, i);

                    if (AllusersDLList.Count > i && AllusersDLList.Count > 0)
                        addDLToPanel(acceptedDLListItems, i);
                    if (AllusersCLList.Count > i && AllusersCLList.Count > 0)
                        addCLToPanel(acceptedCLListItems, i);
                    if (AllusersWLList.Count > i && AllusersWLList.Count > 0)
                        addWLToPanel(acceptedWLListItems, i);

                    if (AllusersCarLList.Count > i && AllusersCarLList.Count > 0)
                        addCarLToPanel(acceptedCarLListItems, i);
                }
                else
                {
                    if (AllusersList.Count > i)
                        if (AllusersList[i].userId.Contains(searchId) || AllusersList[i].FirstName.ToLower().Contains(searchId.ToLower()) || AllusersList[i].LastName.ToLower().Contains(searchId.ToLower())) addToPanel(acceptedListItems, i);

                    if (i < AllusersDLList.Count)
                        if (AllusersDLList[i].userId.Contains(searchId)) addDLToPanel(acceptedDLListItems, i);

                    if (i < AllusersCLList.Count)
                        if (AllusersCLList[i].userId.Contains(searchId)) addCLToPanel(acceptedCLListItems, i);

                    if (i < AllusersWLList.Count)
                        if (AllusersWLList[i].userId.Contains(searchId)) addWLToPanel(acceptedWLListItems, i);

                    if (i < AllusersCarLList.Count)
                        if (AllusersCarLList[i].userId.Contains(searchId)) addCarLToPanel(acceptedCarLListItems, i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                flowLayoutPanel1.Controls.Clear();
                userItems(searchBox.Text);
            }
        }
        //add to panel all the users
        private void addToPanel(acceptedListItem[] acceptedListItems, int i)
        {
            AllusersList = Xml.LoadAllUsersList();
            acceptedListItems[i] = new acceptedListItem
            {
                IdNumber = AllusersList[i].userId,
                FirstName = AllusersList[i].FirstName,
                FatherName = AllusersList[i].FatherName,
                LastName = AllusersList[i].LastName,
                MotherName = AllusersList[i].MotherName,
                GfatherName = AllusersList[i].GfatherName,
                Gender = AllusersList[i].Gender,
                Address = AllusersList[i].Address,
                DateOfBirth = AllusersList[i].DateOfBirth,
                Imagepath = AllusersList[i].ImagePath,
                Index = i.ToString()
            };

            if (flowLayoutPanel1.Controls.Count < 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            else
                flowLayoutPanel1.Controls.Add(acceptedListItems[i]);
        }
        //add to panel all accepted driving license
        private void addDLToPanel(acceptedDrivingLicenseItem[] ItemList2, int i)
        {
            User x = new User();
            x = Xml.FillData(AllusersDLList[i].userId);
            AllusersDLList = Xml.LoadAllUsersLicenseList("DrivingLicense");
            ItemList2[i] = new acceptedDrivingLicenseItem
            {
                IconPath = @".\data\icons\steering.png",
                panelBackColor = Color.LightPink,
                IdNumber = AllusersDLList[i].userId,
                Degree = AllusersDLList[i].degree,
                FirstName = x.FirstName,
                LastName = x.LastName,

                Address = x.Address,
                ImageFilepath = AllusersDLList[i].imageFilePath,
                Imagepath = AllusersDLList[i].imgPath,
                DateOfBirth = x.DateOfBirth,
                Index = i.ToString()
            };

            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();

            else flowLayoutPanel1.Controls.Add(ItemList2[i]);
        }
        //add to panel all accepted cruis license
        private void addCLToPanel(acceptedDrivingLicenseItem[] ItemList2, int i)
        {
            User x = new User();
            x = Xml.FillData(AllusersCLList[i].userId);
            AllusersCLList = Xml.LoadAllUsersLicenseList("CruiseLicense");
            ItemList2[i] = new acceptedDrivingLicenseItem
            {
                IconPath = @".\data\icons\boat.png",
                panelBackColor = Color.Aqua,
                IdNumber = AllusersCLList[i].userId,
                Degree = AllusersCLList[i].degree,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                ImageFilepath = AllusersCLList[i].imageFilePath,
                Imagepath = AllusersCLList[i].imgPath,
                DateOfBirth = x.DateOfBirth,
                Index = i.ToString()
            };

            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();

            else flowLayoutPanel1.Controls.Add(ItemList2[i]);
        }
        //add to panel all accepted weapon license
        private void addWLToPanel(acceptedDrivingLicenseItem[] ItemList2, int i)
        {
            User x = new User();
            x = Xml.FillData(AllusersWLList[i].userId);
            AllusersWLList = Xml.LoadAllUsersLicenseList("WeaponLicense", "");

            ItemList2[i] = new acceptedDrivingLicenseItem
            {
                IconPath = @".\data\icons\unnamed.png",
                panelBackColor = Color.Green,
                IdNumber = AllusersWLList[i].userId,
                Degree = AllusersWLList[i].degree,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                cause = AllusersWLList[i].cause,


                ImageFilepath = AllusersWLList[i].imageFilePath,
                Imagepath = AllusersWLList[i].imgPath,
                DateOfBirth = x.DateOfBirth,
                Index = i.ToString()
            };
            
            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();

            else flowLayoutPanel1.Controls.Add(ItemList2[i]);
        }
        //add to panel all accepted car license
        private void addCarLToPanel(acceptedCarLicenseListItem[] ItemList2, int i)
        {
            User x = new User();
            x = Xml.FillData(AllusersCarLList[i].userId);
            AllusersCarLList = Xml.LoadAllCarLicenseList();
            ItemList2[i] = new acceptedCarLicenseListItem
            {
                IdNumber = AllusersCarLList[i].userId,
                CarOwner = AllusersCarLList[i].CarOwn,
                Address = AllusersCarLList[i].Address,
                CarNum = AllusersCarLList[i].carNum,
                YearOfCarProduction = AllusersCarLList[i].YearOfCarProduction,
                GasComb = AllusersCarLList[i].gasComb,
                Chassisnumbe = AllusersCarLList[i].Chassisnumbe,
                Engineproduct = AllusersCarLList[i].Engineproduct,
                CarColor = AllusersCarLList[i].CarColor,
                propulsion = AllusersCarLList[i].propulsion,
                Fronttire = AllusersCarLList[i].Fronttire,
                Reartire = AllusersCarLList[i].Reartire,
                TheHook = AllusersCarLList[i].TheHook,
                Previousowners = AllusersCarLList[i].Previousowners,
                Enginenumber = AllusersCarLList[i].Enginenumber,
                totalweight = AllusersCarLList[i].totalweight,
                Powerhp = AllusersCarLList[i].Powerhp,
                Volume = AllusersCarLList[i].volume,
                Vehicles = AllusersCarLList[i].Vehicles,
                ABS = AllusersCarLList[i].ABS,
                Index = i.ToString()
            };

            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();

            else flowLayoutPanel1.Controls.Add(ItemList2[i]);
        }
        //refresh the form
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadWithSearch();
        }
        //search in the form
        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            loadWithSearch();
        }
        private void loadWithSearch()
        {
            flowLayoutPanel1.Controls.Clear();
            switch (comboBox1.Text)
            {
                case "All":
                    userItems(searchBox.Text);
                    break;
                case "ID Cards":
                    idOnlyItems(searchBox.Text);
                    break;
                case "Driving Licenses":
                    dlOnlyItems(searchBox.Text);
                    break;
                case "Cruise Licenses":
                    clOnlyItems(searchBox.Text);
                    break;
                case "Weapon Licenses":
                    wlOnlyItems(searchBox.Text);
                    break;
                case "Car Licenses":
                    carlOnlyItems(searchBox.Text);
                    break;
                default:
                    userItems(searchBox.Text);
                    break;
            }
        }
        //edit user i
        public static void deleteUser(string idNumber)
        {
            Xml.deleteUserFromAccepted(idNumber);
            AlertClass.success("User Deleted Succesfully");
        }
        private void idOnlyItems(string searchId)
        {
            acceptedListItem[] acceptedListItems = new acceptedListItem[AllusersList.Count];
            AllusersList = Xml.LoadAllUsersList();

            for (int i = 0; i < AllusersList.Count; i++)
            {
                if (searchId == "")
                {
                    if (AllusersList.Count > i)
                        addToPanel(acceptedListItems, i);
                }
                else
                {
                    if (AllusersList.Count > i)
                        if (AllusersList[i].userId.Contains(searchId) || AllusersList[i].FirstName.ToLower().Contains(searchId.ToLower()) || AllusersList[i].LastName.ToLower().Contains(searchId.ToLower())) addToPanel(acceptedListItems, i);

                }
            }
        }
        private void dlOnlyItems(string searchId)
        {
            acceptedDrivingLicenseItem[] acceptedDLListItems = new acceptedDrivingLicenseItem[AllusersDLList.Count];
            AllusersDLList = Xml.LoadAllUsersLicenseList("DrivingLicense");
            for (int i = 0; i < AllusersDLList.Count; i++)
            {
                if (searchId == "")
                {
                    if (AllusersDLList.Count > i && AllusersDLList.Count > 0)
                        addDLToPanel(acceptedDLListItems, i);
                }
                else
                {
                    if (i < AllusersDLList.Count)
                        if (AllusersDLList[i].userId.Contains(searchId)) addDLToPanel(acceptedDLListItems, i);
                }

            }
        }
        private void clOnlyItems(string searchId)
        {
            acceptedDrivingLicenseItem[] acceptedCLListItems = new acceptedDrivingLicenseItem[AllusersCLList.Count];
            AllusersCLList = Xml.LoadAllUsersLicenseList("CruiseLicense");
            for (int i = 0; i < AllusersCLList.Count; i++)
            {
                if (searchId == "")
                {
                    if (AllusersCLList.Count > i && AllusersCLList.Count > 0)
                        addCLToPanel(acceptedCLListItems, i);
                }
                else
                {
                    if (i < AllusersCLList.Count)
                        if (AllusersCLList[i].userId.Contains(searchId)) addCLToPanel(acceptedCLListItems, i);
                }
            }
        }
        private void wlOnlyItems(string searchId)
        {
            acceptedDrivingLicenseItem[] acceptedWLListItems = new acceptedDrivingLicenseItem[AllusersWLList.Count];
            AllusersWLList = Xml.LoadAllUsersLicenseList("WeaponLicense", "");
            for (int i = 0; i < AllusersWLList.Count; i++)
            {
                if (searchId == "")
                {
                    if (AllusersWLList.Count > i && AllusersWLList.Count > 0)
                        addWLToPanel(acceptedWLListItems, i);
                }
                else
                {

                    if (i < AllusersWLList.Count)
                        if (AllusersWLList[i].userId.Contains(searchId)) addWLToPanel(acceptedWLListItems, i);
                }
            }
        }
        private void carlOnlyItems(string searchId)
        {
            acceptedCarLicenseListItem[] acceptedCarLListItems = new acceptedCarLicenseListItem[AllusersCarLList.Count];
            AllusersCarLList = Xml.LoadAllCarLicenseList();
            for (int i = 0; i < AllusersCarLList.Count; i++)
            {
                if (searchId == "")
                {
                    if (AllusersCarLList.Count > i && AllusersCarLList.Count > 0)
                        addCarLToPanel(acceptedCarLListItems, i);
                }
                else
                {
                    if (i < AllusersCarLList.Count)
                        if (AllusersCarLList[i].userId.Contains(searchId)) addCarLToPanel(acceptedCarLListItems, i);
                }
            }
        }
            //sort all the card by one card type
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                flowLayoutPanel1.Controls.Clear();

            if (comboBox1.SelectedItem.ToString() == "All")
            {
                userItems(searchBox.Text);
            }
            else

           if (comboBox1.SelectedItem.ToString() == "ID Cards")
            {
                idOnlyItems(searchBox.Text);
            }

            else
                 if (comboBox1.SelectedItem.ToString() == "Driving Licenses")
            {
                dlOnlyItems(searchBox.Text);
            }
            else
                 if (comboBox1.SelectedItem.ToString() == "Cruise Licenses")
            {
                clOnlyItems(searchBox.Text);
            }

            else
                 if (comboBox1.SelectedItem.ToString() == "Weapon Licenses")
            {
                wlOnlyItems(searchBox.Text);
            }

            else if (comboBox1.SelectedItem.ToString() == "Car Licenses")
            {
                carlOnlyItems(searchBox.Text);
            }          
        }
    }
}   
