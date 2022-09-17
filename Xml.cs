using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using Identer.Cards_Designs;
using System.Windows.Forms;

namespace Identer
{
    class Xml
    {
       // public static string PhoneNumber;
       // public static string Email;
        public static string personDataTemp = @".\data\PersonDataTemp.Xml";// Path of Temp File 
        public static string Accepted = @".\data\Accepted.Xml";//Path of Accepted Licenes
        public static string IdRequests = @".\data\IdRequests.Xml";//Path of IdCards Requests
        public static string DrivingLRequests = @".\data\DLRequests.Xml";//Path of Driving License Requests
        public static string CruiseLRequests = @".\data\CLRequests.Xml";//Path of Cruise License Requests
        public static string CarLRequests = @".\data\CarLRequests.Xml";//Path of Car Requests
        

        //add person to xml temp file to save the email and phone number
        public static void AddNewUser(string idNumber, string email, string phoneNumber)
        {
            XElement xe;
            xe = new XElement("Users");
            XElement newUser = new XElement("User");
            newUser.Add(new XAttribute("idNumber", idNumber));                                                            
            newUser.Add(new XElement("email", email),new XElement("phoneNumber", phoneNumber));
            xe.Add(newUser);
            xe.Save(personDataTemp);
        }
        /*-------------------------------------------------------------------------------*/
       
        //add person (new user) to xml temp file
        public static void AddNewUser(User newUser)
        {
            Random rnd = new Random();
            XDocument document = XDocument.Load(personDataTemp);
            document.Element("Users").Elements("User")
                    .First(c => c.Attribute("idNumber").Value == newUser.userId).Add
                             (new XElement("FirstName", newUser.FirstName),
                             new XElement("LastName", newUser.LastName),
                             new XElement("FatherName", newUser.FatherName),
                             new XElement("MotherName", newUser.MotherName),
                             new XElement("GfatherName", newUser.GfatherName),
                             new XElement("DateOfBirth", newUser.DateOfBirth),
                             new XElement("ImagePath", newUser.ImagePath),
                             new XElement("Address", newUser.Address),
                             new XElement("Gender", newUser.Gender));
            document.Save(personDataTemp);
        }
        /*-------------------------------------------------------------------------------*/

        //add Car Licence to xml temp file
        public static void AddNewCarTemp(string idNumber,string name, string value)
        {
            Random rnd = new Random();
            XDocument document = XDocument.Load(personDataTemp);
            if (value == "")
            {
                document.Element("Users").Elements("User")
                        .First(c => c.Attribute("idNumber").Value == idNumber).Add
                                 (new XElement(name, new XAttribute("idNumber", idNumber)));
            }
            else
            {
                document.Element("Users").Elements("User")
                        .First(c => c.Attribute("idNumber").Value == idNumber).Element("CarLicense").Add
                                 (new XElement(name, value));
            }    
            document.Save(personDataTemp);
        }
        /*-------------------------------------------------------------------------------*/

        //Add a License(Cruise or driving) to temp file 
        public static void AddLicense(string idNumber, string degree, string imgPath, string imageFilePath, string cardType)
        {

            XDocument document = XDocument.Load(personDataTemp);
            document.Element("Users").Elements("User")
                    .First(c => c.Attribute("idNumber").Value == idNumber).Add
                             (new XElement(cardType,
                             new XAttribute("idNumber", idNumber),
                             new XElement("Degree", degree),
                             new XElement("ImgPath", imgPath),
                             new XElement("ImageFilePath", imageFilePath)));
            document.Save(personDataTemp);
        }
        /*-------------------------------------------------------------------------------*/

        //Add a new Weapon License to Temp file
        public static void AddLicence(string idNumber, string degree,string cause, string imgPath, string imageFilePath, string cardType)
        {

            XDocument document = XDocument.Load(personDataTemp);
            document.Element("Users").Elements("User")
                    .First(c => c.Attribute("idNumber").Value == idNumber).Add
                             (new XElement(cardType,
                             new XAttribute("idNumber", idNumber),
                             new XElement("Degree", degree),
                             new XElement("Cause", cause),
                             new XElement("ImgPath", imgPath),
                             new XElement("ImageFilePath", imageFilePath)));
            document.Save(personDataTemp);
        }
        /*-------------------------------------------------------------------------------*/

        //check if user exists in the xml file
        public static string CheckUser(string idNumber2)
        {
            XElement xe;
            if (File.Exists(Accepted))
            {
                xe = XElement.Load(Accepted);
                IEnumerable<XElement> users = xe.Elements();
                foreach (XElement user in users)
                {
                    if (user.Attribute("idNumber").Value == idNumber2)
                    {
                        //the user already has ID card
                        return "accepted";
                    }
                }
            }
            if (File.Exists(IdRequests))
            {
                xe = XElement.Load(IdRequests);
                IEnumerable<XElement> users = xe.Elements();
                foreach (XElement user in users)
                {
                    if (user.Attribute("idNumber").Value == idNumber2)
                    {
                        //the user has requested an id card
                        return "in progress";
                    }
                }
            }
            return "new user";

        }
        public static string CheckUser(string idNumber2,string CardType)
        {
            XElement xe;
            if (File.Exists(CardType))
            {
                xe = XElement.Load(CardType);
                IEnumerable<XElement> users = xe.Elements();
                foreach (XElement user in users)
                {
                    if (user.Attribute("idNumber").Value == idNumber2)
                    {
                        //the user has requested an id card
                        return "in progress";
                    }
                }
                
            }
            return "";
        }
        /*-------------------------------------------------------------------------------*/

        //Move the temp data to request file 
        public static void AddRequest(string requestType)
        {
            XElement xe1, xe2;
            if (File.Exists(requestType))
            {
                xe1 = XElement.Load(requestType);
            }
            else
                xe1 = new XElement("Users");

            XDocument input = XDocument.Load(personDataTemp);
            XElement firstChild = input.Root.Elements().First();
            firstChild.Save(personDataTemp);

            xe2 = XElement.Load(personDataTemp);
            xe1.Add(xe2);
            xe1.Save(requestType);
            File.Delete(personDataTemp);
        }
        /*-------------------------------------------------------------------------------*/

        //Check Admin login
        public static Boolean CheckAdmin(string Name, string Password)
        {
            XElement xe;
            if (File.Exists(@".\data\Admins.xml"))
            {
                xe = XElement.Load(@".\data\Admins.xml");
                IEnumerable<XElement> Admins = xe.Elements();
                foreach (XElement Admin in Admins)
                {
                    if (Admin.Attribute("Name").Value == Name)
                    {
                        if (Admin.Element("Password").Value == Password) return true;
                    }
                }
                return false;
            }
            else
                return false;
        }
        /*-------------------------------------------------------------------------------*/

        //Create List of All users 
        public static List<User> AllusersList = new List<User>();
        //Create list of driving license of all the users
        public static List<drivingLicenseUser> AllusersDLList = new List<drivingLicenseUser>();
        //Load all the user are accepted to the list
        public static List<User> LoadAllUsersList()
        {
            if (File.Exists(Accepted))
            {
                AllusersList = (
                    from e in XDocument.Load(Accepted).Root.Elements("User")
                    select new User
                    {
                        userId = e.Attribute("idNumber").Value,
                        FirstName = e.Element("FirstName").Value,
                        LastName = e.Element("LastName").Value,
                        FatherName = e.Element("FatherName").Value,
                        MotherName = e.Element("MotherName").Value,
                        GfatherName = e.Element("GfatherName").Value,
                        DateOfBirth = e.Element("DateOfBirth").Value,
                        ImagePath = e.Element("ImagePath").Value,
                        Gender = e.Element("Gender").Value,
                        Address = e.Element("Address").Value,
                    }).ToList();
            }
            return AllusersList;
        }
        /*-------------------------------------------------------------------------------*/

        //return all users license list
        public static List<drivingLicenseUser> LoadAllUsersLicenseList(string cardType)
        {
            if (File.Exists(Accepted))
            {
                AllusersDLList = (
                    from e in XDocument.Load(Accepted).Root.Elements("User").Elements(cardType)
                    select new drivingLicenseUser
                    {
                        userId = e.Attribute("idNumber").Value,
                        degree = e.Element("Degree").Value,
                        imageFilePath = e.Element("imageFilePath").Value,
                        imgPath = e.Element("ImagePath").Value,
                   
                    
                    }).ToList();
            }
            return AllusersDLList;
        }
        //return all users license list
        public static List<drivingLicenseUser> LoadAllUsersLicenseList(string cardType,string isWeapon)
        {
            if (File.Exists(Accepted))
            {
                AllusersDLList = (
                    from e in XDocument.Load(Accepted).Root.Elements("User").Elements(cardType)
                    select new drivingLicenseUser
                    {
                        userId = e.Attribute("idNumber").Value,
                        degree = e.Element("Degree").Value,
                        imageFilePath = e.Element("imageFilePath").Value,
                        imgPath = e.Element("ImagePath").Value,
                        cause = e.Element("Cause").Value,

                    }).ToList();
            }
            return AllusersDLList;
        }
        /*-------------------------------------------------------------------------------*/

        //Craete list of all users Car list
        public static List<CarLicenseData> AllusersCarLList = new List<CarLicenseData>();
        //return all users Car license list
        public static List<CarLicenseData> LoadAllCarLicenseList()
        {
            if (File.Exists(Accepted))
            {
                AllusersCarLList = (
                    from e in XDocument.Load(Accepted).Root.Elements("User").Elements("CarLicense")
                    select new CarLicenseData
                    {
                        userId = e.Attribute("idNumber").Value,
                        CarOwn = e.Element("CarOwnTxt").Value,
                        Address = e.Element("AddressTxt").Value,
                        carNum = e.Element("carNumTxt").Value,
                        Vehicles = e.Element("VehiclesTxt").Value,
                        YearOfCarProduction = e.Element("yearComb").Value,
                        gasComb = e.Element("gasComb").Value,
                        Chassisnumbe = e.Element("ChassisnumbeTxt").Value,
                        Engineproduct = e.Element("EngineproductTxt").Value,
                        CarColor = e.Element("ColorText").Value,
                        propulsion= e.Element("propulsionTxt").Value,   
                        Fronttire = e.Element("FronttireTxt").Value,
                        Reartire = e.Element("ReartireTxt").Value,
                       TheHook = e.Element("TheHookHauled").Value,                  
                        Previousowners = e.Element("PreviousownersTxt").Value,
                        Enginenumber = e.Element("EnginenumberTxt").Value,
                        totalweight = e.Element("totalweightTxt").Value,
                        Powerhp = e.Element("PowerhpTxt").Value,
                        volume = e.Element("volumeTxt").Value,
                        ABS = e.Element("ABS").Value,
                    }).ToList();
            }
            return AllusersCarLList;
        }
        /*-------------------------------------------------------------------------------*/

        //Create user list
        public static List<User> userList = new List<User>();
        //return all id card to list 
        public static List<User> LoadIdsList()
        {
            if (File.Exists(IdRequests))
            {
                userList = (
                    from e in XDocument.Load(IdRequests).Root.Elements("User")
                    select new User
                    {
                        userId = e.Attribute("idNumber").Value,
                        FirstName = e.Element("FirstName").Value,
                        LastName = e.Element("LastName").Value,
                        FatherName = e.Element("FatherName").Value,
                        MotherName = e.Element("MotherName").Value,
                        GfatherName = e.Element("GfatherName").Value,
                        DateOfBirth = e.Element("DateOfBirth").Value,
                        ImagePath = e.Element("ImagePath").Value,
                        Gender = e.Element("Gender").Value,
                        Address = e.Element("Address").Value,
                    }).ToList();
            }
            return userList;
        }
        /*-------------------------------------------------------------------------------*/

        //Create list of all driving license data
        public static List<drivingLicenseUser> userDLList = new List<drivingLicenseUser>();
        //return all license card to list 
        public static List<drivingLicenseUser> LoadLicensesList(string cardType, string requestPath)
        {
            if (File.Exists(requestPath))
            {
                userDLList = (
                from e in XDocument.Load(requestPath).Root.Elements("User").Elements(cardType)
                select new drivingLicenseUser
                {
                    userId = e.Attribute("idNumber").Value,
                    degree = e.Element("Degree").Value,
                    imageFilePath = e.Element("ImageFilePath").Value,
                  
                    
                    imgPath = e.Element("ImgPath").Value,
                }).ToList();
                return userDLList;
            }
            return new List<drivingLicenseUser>();

        }
        public static List<drivingLicenseUser> LoadLicensesList(string cardType, string requestPath,string isweapon)
        {
            if (File.Exists(requestPath))
            {
                userDLList = (
                from e in XDocument.Load(requestPath).Root.Elements("User").Elements(cardType)
                select new drivingLicenseUser
                {
                    userId = e.Attribute("idNumber").Value,
                    degree = e.Element("Degree").Value,
                    imageFilePath = e.Element("ImageFilePath").Value,
                    cause=e.Element("Cause").Value,
                    imgPath = e.Element("ImgPath").Value,
                }).ToList();
                return userDLList;
            }
            return new List<drivingLicenseUser>();

        }


      
        /*-------------------------------------------------------------------------------*/

        //Create list of Car license requests
        public static List<CarLicenseData> userCarLList = new List<CarLicenseData>();
        //return the list of car license
        public static List<CarLicenseData> LoadCarLicensesList()
        {
            if (File.Exists(CarLRequests))
            {
                userCarLList = (
                from e in XDocument.Load(CarLRequests).Root.Elements("User").Elements("CarLicense")
                select new CarLicenseData
                {
                    userId = e.Attribute("idNumber").Value,
                    CarOwn = e.Element("CarOwnTxt").Value,
                    Address = e.Element("AddressTxt").Value,
                    carNum = e.Element("carNumTxt").Value,
                    Vehicles= e.Element("VehiclesTxt").Value,
                    YearOfCarProduction = e.Element("yearComb").Value,
                    gasComb = e.Element("gasComb").Value,
                    Chassisnumbe = e.Element("ChassisnumbeTxt").Value,
                    Engineproduct = e.Element("EngineproductTxt").Value,
                    CarColor = e.Element("ColorText").Value,
                    propulsion = e.Element("propulsionTxt").Value,
                    Fronttire = e.Element("FronttireTxt").Value,
                    Reartire = e.Element("ReartireTxt").Value,
                    TheHook = e.Element("TheHookHauled").Value,
                    Previousowners = e.Element("PreviousownersTxt").Value,
                    Enginenumber = e.Element("EnginenumberTxt").Value,
                    totalweight = e.Element("totalweightTxt").Value,
                    Powerhp = e.Element("PowerhpTxt").Value,
                    volume = e.Element("volumeTxt").Value,
                    ABS = e.Element("ABS").Value,               
                }).ToList();
                return userCarLList;
            }
            return new List<CarLicenseData>();

        }
        /*-------------------------------------------------------------------------------*/

        //delete User From Accepted by id number
        public static void deleteUserFromAccepted(string idNumber)
        {
            User user = Xml.FillData(idNumber);

            XDocument xDoc = XDocument.Load(Accepted);
            var itemsToMove = xDoc.Root.Descendants("User")
                               .Where(x => x.Attribute("idNumber").Value == idNumber).ToList();
            //remove the Accepted card from the requests file
            itemsToMove.Remove();
            xDoc.Save(Accepted);
            AlertClass.sendEmail("תעודתך נמחקה מהמערכת", "תעודתך נמחקה מהמערכת שלנו, אם יש לך שאלות כלשהן, תפנה למוקד שלנו", user.Email);
        }
        /*-------------------------------------------------------------------------------*/

        //decline the Request "Remove the request "
        public static void declineRequest(string idNumber, string requestType)
        {
            User user = Xml.FillData(idNumber);
            XDocument xDoc = XDocument.Load(requestType);
            var itemsToMove = xDoc.Root.Descendants("User")
                               .Where(x => x.Attribute("idNumber").Value == idNumber).ToList();

            //remove the Accepted card from the requests file
            itemsToMove.Remove();
            xDoc.Save(requestType);
            AlertClass.createPdf(htmlPayment.textRender(), @".\data\html\Payment.html", @".\data\Bills\charge back\ זיכוי כספי - " + idNumber + ".pdf", "- 150",
                                                      "זיכוי תעודת זהות", user.FirstName + " " + user.LastName);
            AlertClass.sendEmail(@".\data\Bills\charge back\ זיכוי כספי - " + idNumber + ".pdf", "זיכוי כספי", "בקשתך לא התקבלה בהצלחה, כך זיכוי", user.Email);
        }
        /*-------------------------------------------------------------------------------*/
    
        //return all the data of specific person by id number
        public static User FillData(string idNumber)
        {
            User pd = new User();
            XElement xe;

            if (File.Exists(Accepted))
            {
                xe = XElement.Load(Accepted);
                IEnumerable<XElement> users = xe.Elements();
                foreach (var user in users)
                {
                    if (user.Attribute("idNumber").Value == idNumber)
                    {
                        pd.FirstName = user.Element("FirstName").Value;
                        pd.LastName = user.Element("LastName").Value;
                        pd.MotherName = user.Element("MotherName").Value;
                        pd.FatherName = user.Element("FatherName").Value;
                        pd.GfatherName = user.Element("GfatherName").Value;
                        pd.Gender = user.Element("Gender").Value;
                        pd.ImagePath = user.Element("ImagePath").Value;
                        pd.DateOfBirth = user.Element("DateOfBirth").Value;
                        pd.Address = user.Element("Address").Value;
                        pd.PhoneNumber = user.Element("phoneNumber").Value;
                        pd.Email = user.Element("email").Value;
                    }
                }
            }
            return pd;
        }

        /*-------------------------------------------------------------------------------*/
        //Accept the id request "Move the license to accepted xml file and remove it from request xml file "
        public static void acceptCard(string idNumber)
        {
            XDocument otherDoc;
            XDocument xDoc = XDocument.Load(IdRequests);
            if (!File.Exists(Accepted))
            {
                otherDoc = new XDocument(new XElement("Users"));
            }
            else
            {
                otherDoc = XDocument.Load(Accepted);
            }

            var itemsToMove = xDoc.Root.Descendants("User")
                               .Where(x => x.Attribute("idNumber").Value == idNumber).ToList();
            //copy the Accepted card to the Accepted xml file
            otherDoc.Root.Add(itemsToMove);
            //remove the Accepted card from the requests file
            itemsToMove.Remove();

            xDoc.Save(IdRequests);
            otherDoc.Save(Accepted);
            idCardDesign idCD = new idCardDesign(idNumber);
            idCD.Show();
        }
        /*-------------------------------------------------------------------------------*/
        //Accept the driving/cruise request "Move the license to accepted xml file and remove it from request xml file "
        public static void acceptCard(string requestPath, string requsetType, string idNumber, string degree, string imgPath, string imageFilePath, string newEmail, string phoneNumber)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Accepted);
            XmlNode t = xmlDoc.SelectSingleNode("/Users/User[@idNumber='" + idNumber + "']/email");
            t.ParentNode.RemoveChild(t);
            t = xmlDoc.SelectSingleNode("/Users/User[@idNumber='" + idNumber + "']/phoneNumber");
            t.ParentNode.RemoveChild(t);
            xmlDoc.Save(Accepted);

            Random rnd = new Random();
            XDocument document = XDocument.Load(Accepted);
            document.Element("Users").Elements("User")
                    .First(c => c.Attribute("idNumber").Value == idNumber).Add
                             (new XElement("email", newEmail),
                             new XElement("phoneNumber", phoneNumber),
                             new XElement(requsetType,
                             new XAttribute("idNumber", idNumber),
                             new XElement("ImagePath", imgPath),
                             new XElement("imageFilePath", imageFilePath),
                             new XElement("Degree", degree),
                             new XElement("ReleaseDate", DateTime.Today.ToString("dd/MM/yyyy").Replace('-', '/')),
                             new XElement("Validation", DateTime.Today.AddYears(10).ToString("dd/MM/yyyy").Replace('-', '/')),
                             new XElement("CardNumber", rnd.Next(1000000, 9999999).ToString())));
            document.Save(Accepted);

            //remove the Accepted card from the requests file
            XDocument xDoc = XDocument.Load(requestPath);
            var itemsToMove = xDoc.Root.Descendants("User")
                               .Where(x => x.Attribute("idNumber").Value == idNumber).ToList();
            itemsToMove.Remove();
            xDoc.Save(requestPath);
        }
        /*-------------------------------------------------------------------------------*/

        //Accept the weapon request "Move the license to accepted xml file and remove it from request xml file "
        public static void acceptCard(string requestPath, string requsetType, string idNumber, string degree,string cause, string imgPath, string imageFilePath, string newEmail, string phoneNumber)
        {
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Accepted);
            XmlNode t = xmlDoc.SelectSingleNode("/Users/User[@idNumber='" + idNumber + "']/email");
            t.ParentNode.RemoveChild(t);
            t = xmlDoc.SelectSingleNode("/Users/User[@idNumber='" + idNumber + "']/phoneNumber");
            t.ParentNode.RemoveChild(t);
            xmlDoc.Save(Accepted);

            Random rnd = new Random();
            XDocument document = XDocument.Load(Accepted);
            document.Element("Users").Elements("User")
                    .First(c => c.Attribute("idNumber").Value == idNumber).Add
                             (new XElement("email", newEmail),
                             new XElement("phoneNumber", phoneNumber),
                             new XElement(requsetType,
                             new XAttribute("idNumber", idNumber),
                             new XElement("ImagePath", imgPath),
                             new XElement("imageFilePath", imageFilePath),
                             new XElement("Degree", degree),
                             new XElement("Cause", cause),
                             new XElement("ReleaseDate", DateTime.Today.ToString("dd/MM/yyyy").Replace('-', '/')),
                             new XElement("Validation", DateTime.Today.AddYears(10).ToString("dd/MM/yyyy").Replace('-', '/')),
                             new XElement("CardNumber", rnd.Next(1000000, 9999999).ToString())));
            document.Save(Accepted);

            //remove the Accepted card from the requests file
            XDocument xDoc = XDocument.Load(requestPath);
            var itemsToMove = xDoc.Root.Descendants("User")
                               .Where(x => x.Attribute("idNumber").Value == idNumber).ToList();
            itemsToMove.Remove();
            xDoc.Save(requestPath);
        }
        /*-------------------------------------------------------------------------------*/

        //accept car license request and send email and SMS (user by admin) 
        public static void acceptCarLicense(CarLicenseData carData, string newEmail, string phoneNumber)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Accepted);
            XmlNode t = xmlDoc.SelectSingleNode("/Users/User[@idNumber='" + carData.userId + "']/email");
            t.ParentNode.RemoveChild(t);
            t = xmlDoc.SelectSingleNode("/Users/User[@idNumber='" + carData.userId + "']/phoneNumber");
            t.ParentNode.RemoveChild(t);
            xmlDoc.Save(Accepted);

            Random rnd = new Random();
            XDocument document = XDocument.Load(Accepted);
            document.Element("Users").Elements("User")
                    .First(c => c.Attribute("idNumber").Value == carData.userId).Add
                             (new XElement("email", newEmail),
                             new XElement("phoneNumber", phoneNumber),
                             new XElement("CarLicense",
                             new XAttribute("idNumber", carData.userId),
                             new XElement("CarOwnTxt", carData.CarOwn),
                             new XElement("AddressTxt", carData.Address),
                             new XElement("carNumTxt", carData.carNum),
                             new XElement("gasComb", carData.gasComb),
                             new XElement("volumeTxt", carData.volume),
                             new XElement("PowerhpTxt", carData.Powerhp),
                             new XElement("totalweightTxt", carData.totalweight),
                             new XElement("EnginenumberTxt", carData.Enginenumber),
                             new XElement("PreviousownersTxt", carData.Previousowners),
                             new XElement("ReartireTxt", carData.Reartire),
                             new XElement("FronttireTxt", carData.Fronttire),
                             new XElement("ColorText", carData.CarColor),
                             new XElement("TheHookHauled", carData.TheHook),
                             new XElement("propulsionTxt", carData.propulsion),
                             new XElement("EngineproductTxt", carData.Engineproduct),
                             new XElement("ChassisnumbeTxt", carData.Chassisnumbe),
                             new XElement("VehiclesTxt", carData.Vehicles),
                             new XElement("yearComb", carData.YearOfCarProduction),
                             new XElement("ABS", carData.ABS),
                             new XElement("ReleaseDate", DateTime.Today.ToString("dd/MM/yyyy").Replace('-', '/')),
                             new XElement("Validation", DateTime.Today.AddYears(10).ToString("dd/MM/yyyy").Replace('-', '/')),
                             new XElement("CardNumber", rnd.Next(1000000, 9999999).ToString())));
            document.Save(Accepted);

            //remove the Accepted card from the requests file
            XDocument xDoc = XDocument.Load(CarLRequests);
            var itemsToMove = xDoc.Root.Descendants("User")
                               .Where(x => x.Attribute("idNumber").Value == carData.userId).ToList();
            itemsToMove.Remove();
            xDoc.Save(CarLRequests);
        }
        /*-------------------------------------------------------------------------------*/

        //deletes old license of type "cardType" from accepted file
        public static void deleteOldLicense(string idNumber, string cardType)
        {
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Accepted);

            XmlNode t = xmlDoc.SelectSingleNode("/Users/User/" + cardType + "[@idNumber='" + idNumber + "']");
            t.ParentNode.RemoveChild(t);
            xmlDoc.Save(Accepted);
        }
        //delete one degree of driving license
        public static void deleteOldLicense(string idNumber, string cardType,string Degree)
        {
     
          

            if (cardType == "CarLicense")
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Accepted);
            
                XmlNode t = xmlDoc.SelectSingleNode("/Users/User/" + cardType + "[@idNumber='" + idNumber + "']" + " [ChassisnumbeTxt = '" + Degree + "']");
                t.ParentNode.RemoveChild(t);
                xmlDoc.Save(Accepted);
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Accepted);
                
                XmlNode t = xmlDoc.SelectSingleNode("/Users/User/" + cardType + "[@idNumber='" + idNumber + "']" + " [Degree = '" + Degree + "']");
                t.ParentNode.RemoveChild(t);
                xmlDoc.Save(Accepted);
            }
           
            
        }
        /*-------------------------------------------------------------------------------*/

        //search for element "elementName" in the file "path" for specific user "idNumber"
        public static string searchAndReturn(string path, string idNumber, string elementName)
        {
            XElement xe;
            if (File.Exists(path))
            {
                xe = XElement.Load(path);
                IEnumerable<XElement> Users = xe.Elements();
                foreach (XElement user in Users)
                {
                    if (user.Attribute("idNumber").Value == idNumber)
                    {
                        if(user.Element(elementName).Value!=null)
                        return user.Element(elementName).Value;
                    }
                }
                return null;
            }
            else
                return null;
        }
        /*-------------------------------------------------------------------------------*/

        //check if specific user has license of type "cardType"
        public static Boolean checkIfExist(string path, string idNumber,string cardType)
        {
            XElement xe;

            xe = XElement.Load(path);
            IEnumerable<XElement> Users = xe.Elements();
            foreach (XElement user in Users)
            {
                if (user.Attribute("idNumber").Value == idNumber)
                {
                    return user.Elements(cardType).Any();
                }
            }
            return false;
        }
        /*-------------------------------------------------------------------------------*/

        //edit an element value in the accepted xml file
        public static void editElement(string idNumber, string element,string newValue)
        {
            XElement xe;
            xe = XElement.Load(Accepted);
            IEnumerable<XElement> Users = xe.Elements();
            foreach (XElement user in Users)
            {
                if (user.Attribute("idNumber").Value == idNumber)
                {
                     user.Element(element).Value=newValue;
                }
            }
            xe.Save(Accepted);
        }

        public static void editElement(string idNumber, string element, string newValue,string CardType)
        {
            XElement xe;
            xe = XElement.Load(Accepted);
            IEnumerable<XElement> Users = xe.Elements();
            foreach (XElement user in Users)
            {
                if (user.Attribute("idNumber").Value == idNumber)
                {
                    user.Element(CardType).Element(element).Value = newValue;
                }
            }
            xe.Save(Accepted);
        }
    }
}
