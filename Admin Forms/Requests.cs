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
    public partial class Requests : Form
    {
        private Random rnd = new Random();
        //create all the requst lists
        public static string newEmail;
        public static string newPhoneNumber;
        private static List<User> userReqList = new List<User>();
        private static List<drivingLicenseUser> userDLReqList = new List<drivingLicenseUser>();
        private static List<drivingLicenseUser> userCLReqList = new List<drivingLicenseUser>();
        private static List<drivingLicenseUser> userWLReqList = new List<drivingLicenseUser>();
        private static List<CarLicenseData> userCarLReqList = new List<CarLicenseData>();
        public Requests()
        {
            InitializeComponent();
            //load all the lists requst
            userReqList = Xml.LoadIdsList();
            userDLReqList = Xml.LoadLicensesList("DrivingLicense", @".\data\DLRequests.Xml");
            userCLReqList = Xml.LoadLicensesList("CruiseLicense", @".\data\CLRequests.Xml");
            userWLReqList = Xml.LoadLicensesList("WeaponLicense", @".\data\WLRequests.Xml", "");

            userCarLReqList = Xml.LoadCarLicensesList();
            userItems("");
        }
        public void userItems(string searchId)
        {
            ListItem[] ItemList = new ListItem[userReqList.Count];
            DrivingLicenseListItem[] ItemList2 = new DrivingLicenseListItem[userDLReqList.Count];
            DrivingLicenseListItem[] ItemList3 = new DrivingLicenseListItem[userCLReqList.Count];
            DrivingLicenseListItem[] ItemList4 = new DrivingLicenseListItem[userWLReqList.Count];
            CarLicenseLiatItem[] ItemList5 = new CarLicenseLiatItem[userCarLReqList.Count];
            userReqList = Xml.LoadIdsList();
            userDLReqList = Xml.LoadLicensesList("DrivingLicense", @".\data\DLRequests.Xml");

            userCLReqList = Xml.LoadLicensesList("CruiseLicense", @".\data\CLRequests.Xml");

            userWLReqList = Xml.LoadLicensesList("WeaponLicense", @".\data\WLRequests.Xml", "");
            userCarLReqList = Xml.LoadCarLicensesList();
            //Math.Max(userReqList.Count, Math.Max(userDLReqList.Count , Math.Max(userCLReqList.Count, userWLReqList.Count)))
            for (int i = 0; i < userReqList.Count + userDLReqList.Count + userCLReqList.Count + userWLReqList.Count + userCarLReqList.Count; i++)
            {
                if (searchId == "")
                {
                    if (i < userReqList.Count)
                        addIdToPanel(ItemList, i);

                    if (i < userDLReqList.Count)
                        addDLLicenseToPanel(ItemList2, i);

                    if (i < userCLReqList.Count)
                        addCLLicenseToPanel(ItemList3, i);

                    if (i < userWLReqList.Count)
                        addWLLicenseToPanel(ItemList4, i);

                    if (i < userCarLReqList.Count)
                        addCarLicenseToPanel(ItemList5, i);
                }
                else
                {
                    if (i < userReqList.Count)
                        if (userReqList[i].userId.Contains(searchId) || userReqList[i].FirstName.ToLower().Contains(searchId.ToLower()) || userReqList[i].LastName.ToLower().Contains(searchId.ToLower())) addIdToPanel(ItemList, i);

                    if (i < userDLReqList.Count)
                        if (userDLReqList[i].userId.Contains(searchId)) addDLLicenseToPanel(ItemList2, i);
                    if (i < userCLReqList.Count)
                        if (userCLReqList[i].userId.Contains(searchId)) addCLLicenseToPanel(ItemList3, i);
                    if (i < userWLReqList.Count)
                        if (userWLReqList[i].userId.Contains(searchId)) addWLLicenseToPanel(ItemList4, i);
                    if (i < userCarLReqList.Count)
                        if (userCarLReqList[i].userId.Contains(searchId)) addCarLicenseToPanel(ItemList5, i);
                }
            }
        }
        //add to panel all id card requests 
        private void addIdToPanel(ListItem[] ItemList, int i)
        {
            userReqList = Xml.LoadIdsList();
            ItemList[i] = new ListItem
            {
                PanelBackColor = Color.LightGray,
                IdNumber = userReqList[i].userId,
                FirstName = userReqList[i].FirstName,
                FatherName = userReqList[i].FatherName,
                LastName = userReqList[i].LastName,
                MotherName = userReqList[i].MotherName,
                GfatherName = userReqList[i].GfatherName,
                Gender = userReqList[i].Gender,
                Address = userReqList[i].Address,
                DateOfBirth = userReqList[i].DateOfBirth,
                Imagepath = userReqList[i].ImagePath,
                Index = i.ToString()
            };

            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();
            else flowLayoutPanel1.Controls.Add(ItemList[i]);
        }
        //add to panel all driving license cards requests 
        private void addDLLicenseToPanel(DrivingLicenseListItem[] ItemList, int i)
        {
            User x = new User();
            x = Xml.FillData(userDLReqList[i].userId);
            userDLReqList = Xml.LoadLicensesList("DrivingLicense", @".\data\DLRequests.Xml");
            ItemList[i] = new DrivingLicenseListItem
            {
                panelBackColor = Color.LightPink,
                IdNumber = userDLReqList[i].userId,
                Degree = userDLReqList[i].degree,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                ImageFilepath = userDLReqList[i].imageFilePath,
                Imagepath = userDLReqList[i].imgPath,
                DateOfBirth = x.DateOfBirth,
                Index = i.ToString()
            };
            newEmail = userDLReqList[i].Email;
            newPhoneNumber = userDLReqList[i].PhoneNumber;

            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();
            else flowLayoutPanel1.Controls.Add(ItemList[i]);
        }
        //add to panel all cruise license cards requests 
        private void addCLLicenseToPanel(DrivingLicenseListItem[] ItemList, int i)
        {
            User x = new User();
            x = Xml.FillData(userCLReqList[i].userId);
            userCLReqList = Xml.LoadLicensesList("CruiseLicense", @".\data\CLRequests.Xml");
            ItemList[i] = new DrivingLicenseListItem
            {
                panelBackColor = Color.Aqua,
                IdNumber = userCLReqList[i].userId,
                Cdegree = userCLReqList[i].degree,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                ImageFilepath = userCLReqList[i].imageFilePath,
                Imagepath = userCLReqList[i].imgPath,
                DateOfBirth = x.DateOfBirth,
                Index = i.ToString()
            };
            newEmail = userCLReqList[i].Email;
            newPhoneNumber = userCLReqList[i].PhoneNumber;

            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();
            else flowLayoutPanel1.Controls.Add(ItemList[i]);
        }
        //add to panel all weapon license cards requests 
        private void addWLLicenseToPanel(DrivingLicenseListItem[] ItemList, int i)
        {
            User x = new User();
            x = Xml.FillData(userWLReqList[i].userId);

            userWLReqList = Xml.LoadLicensesList("WeaponLicense", @".\data\WLRequests.Xml", "");
            ItemList[i] = new DrivingLicenseListItem
            {
                panelBackColor = Color.Green,
                IdNumber = userWLReqList[i].userId,
                WeaponType = userWLReqList[i].degree,
                Cause = userWLReqList[i].cause,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Address = x.Address,
                ImageFilepath = userWLReqList[i].imageFilePath,
                Imagepath = userWLReqList[i].imgPath,
                DateOfBirth = x.DateOfBirth,
                Index = i.ToString()
            };
            newEmail = userWLReqList[i].Email;
            newPhoneNumber = userWLReqList[i].PhoneNumber;

            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();
            else flowLayoutPanel1.Controls.Add(ItemList[i]);
        }
        //add to panel all car license cards requests 
        private void addCarLicenseToPanel(CarLicenseLiatItem[] ItemList, int i)
        {
            User x = new User();
            x = Xml.FillData(userCarLReqList[i].userId);
            userCarLReqList = Xml.LoadCarLicensesList();
            ItemList[i] = new CarLicenseLiatItem
            {
                IdNumber = userCarLReqList[i].userId,
                CarOwner = userCarLReqList[i].CarOwn,
                Address = userCarLReqList[i].Address,
                CarNum = userCarLReqList[i].carNum,
                YearOfCarProduction = userCarLReqList[i].YearOfCarProduction,
                GasComb = userCarLReqList[i].gasComb,
                Chassisnumbe = userCarLReqList[i].Chassisnumbe,
                Engineproduct = userCarLReqList[i].Engineproduct,
                CarColor = userCarLReqList[i].CarColor,
                propulsion = userCarLReqList[i].propulsion,
                Fronttire = userCarLReqList[i].Fronttire,
                Reartire = userCarLReqList[i].Reartire,
                TheHook = userCarLReqList[i].TheHook,
                Previousowners = userCarLReqList[i].Previousowners,
                Enginenumber = userCarLReqList[i].Enginenumber,
                totalweight = userCarLReqList[i].totalweight,
                Powerhp = userCarLReqList[i].Powerhp,
                Volume = userCarLReqList[i].volume,
                Vehicles = userCarLReqList[i].Vehicles,
                ABS = userCarLReqList[i].ABS,
                Index = i.ToString()
            };
            newEmail = userCarLReqList[i].Email;
            newPhoneNumber = userCarLReqList[i].PhoneNumber;

            if (flowLayoutPanel1.Controls.Count < 0)
                flowLayoutPanel1.Controls.Clear();
            else flowLayoutPanel1.Controls.Add(ItemList[i]);
        }

        private void idOnlyItems(string searchId)
        {
            ListItem[] acceptedListItems = new ListItem[userReqList.Count];
            userReqList = Xml.LoadIdsList();

            for (int i = 0; i < userReqList.Count; i++)
            {
                if (searchId == "")
                {
                    if (userReqList.Count > i)
                        addIdToPanel(acceptedListItems, i);
                }
                else
                {
                    if (userReqList.Count > i)
                        if (userReqList[i].userId.Contains(searchId) || userReqList[i].FirstName.ToLower().Contains(searchId.ToLower()) || userReqList[i].LastName.ToLower().Contains(searchId.ToLower())) addIdToPanel(acceptedListItems, i);

                }
            }
        }
        private void dlOnlyItems(string searchId)
        {
            DrivingLicenseListItem[] acceptedDLListItems = new DrivingLicenseListItem[userDLReqList.Count];
            userDLReqList = Xml.LoadLicensesList("DrivingLicense", @".\data\DLRequests.Xml");
            for (int i = 0; i < userDLReqList.Count; i++)
            {
                if (searchId == "")
                {
                    if (userDLReqList.Count > i && userDLReqList.Count > 0)
                        addDLLicenseToPanel(acceptedDLListItems, i);
                }
                else
                {
                    if (i < userDLReqList.Count)
                        if (userDLReqList[i].userId.Contains(searchId)) addDLLicenseToPanel(acceptedDLListItems, i);
                }

            }
        }
        private void clOnlyItems(string searchId)
        {
            DrivingLicenseListItem[] acceptedCLListItems = new DrivingLicenseListItem[userCLReqList.Count];
            userCLReqList = Xml.LoadLicensesList("CruiseLicense", @".\data\CLRequests.Xml");
            for (int i = 0; i < userCLReqList.Count; i++)
            {
                if (searchId == "")
                {
                    if (userCLReqList.Count > i && userCLReqList.Count > 0)
                        addCLLicenseToPanel(acceptedCLListItems, i);
                }
                else
                {
                    if (i < userCLReqList.Count)
                        if (userCLReqList[i].userId.Contains(searchId)) addCLLicenseToPanel(acceptedCLListItems, i);
                }
            }
        }
        private void wlOnlyItems(string searchId)
        {
            DrivingLicenseListItem[] acceptedWLListItems = new DrivingLicenseListItem[userWLReqList.Count];
            userWLReqList = Xml.LoadLicensesList("WeaponLicense", @".\data\WLRequests.Xml", "");
            for (int i = 0; i < userWLReqList.Count; i++)
            {
                if (searchId == "")
                {
                    if (userWLReqList.Count > i && userWLReqList.Count > 0)
                        addWLLicenseToPanel(acceptedWLListItems, i);
                }
                else
                {
                    if (i < userWLReqList.Count)
                        if (userWLReqList[i].userId.Contains(searchId)) addWLLicenseToPanel(acceptedWLListItems, i);
                }
            }
        }
        private void carlOnlyItems(string searchId)
        {
            CarLicenseLiatItem[] acceptedCarLListItems = new CarLicenseLiatItem[userCarLReqList.Count];
            userCarLReqList = Xml.LoadCarLicensesList();
            for (int i = 0; i < userCarLReqList.Count; i++)
            {
                if (searchId == "")
                {
                    if (userCarLReqList.Count > i && userCarLReqList.Count > 0)
                        addCarLicenseToPanel(acceptedCarLListItems, i);
                }
                else
                {
                    if (i < userCarLReqList.Count)
                        if (userCarLReqList[i].userId.Contains(searchId)) addCarLicenseToPanel(acceptedCarLListItems, i);
                }
            }
        }

        //refresh the form
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadWithSearch();
        }
        //search in the panel
        private void button1_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                flowLayoutPanel1.Controls.Clear();
                userItems(searchBox.Text);
            }
        }

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
        //accept request
        public static void acceptRequest(string idNumber, int i, string requestPath, string requestType)
        {
            newEmail = Xml.searchAndReturn(requestPath, idNumber, "email");
            newPhoneNumber = Xml.searchAndReturn(requestPath, idNumber, "phoneNumber");
            
            if (requestType == "DrivingLicense")
            {
                Xml.acceptCard(requestPath, requestType, userDLReqList[i].userId, userDLReqList[i].degree, userDLReqList[i].imgPath,
                                userDLReqList[i].imageFilePath, newEmail, newPhoneNumber);
                DrivingLicenseDesign dld = new DrivingLicenseDesign(userDLReqList[i].userId, userDLReqList[i].degree, userDLReqList[i].imgPath);
                dld.Show();
            }
            else if (requestType == "CruiseLicense")
            {
                Xml.acceptCard(requestPath, requestType, userCLReqList[i].userId, userCLReqList[i].degree, userCLReqList[i].imgPath,
                                userCLReqList[i].imageFilePath, newEmail, newPhoneNumber);
                CruiseLicenseDesign cld = new CruiseLicenseDesign(userCLReqList[i].userId, userCLReqList[i].degree, userCLReqList[i].imgPath);
                cld.Show();
            }
            else if (requestType == "WeaponLicense")
            {
                Xml.acceptCard(requestPath, requestType, userWLReqList[i].userId, userWLReqList[i].degree, userWLReqList[i].cause, userWLReqList[i].imgPath,
                                userWLReqList[i].imageFilePath, newEmail, newPhoneNumber);

                WeaponLicenseDesign wld = new WeaponLicenseDesign(userWLReqList[i].userId, userWLReqList[i].degree, userWLReqList[i].imgPath, userWLReqList[i].cause);
                wld.Show();
            }
            else if (requestType == "CarLicense")
            {
                Xml.acceptCarLicense(userCarLReqList[i], newEmail, newPhoneNumber);

                CarLicenseDesign cld = new CarLicenseDesign(userCarLReqList[i].userId, i);
                cld.Show();
            }
        }
    }
}
