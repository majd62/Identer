using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identer
{
    class CheckInput
    {
        //recives an input and it's type and check if it's valid
        public static Boolean check(string input, string type)//retrurn true if  vaild input
        {
            bool flag = false;
            Regex regemail = new Regex(@"^\w+([-_.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");//check mail
            Regex regPn = new Regex("^\\d{10}$");//to check phone number if 10 digits
            Regex regNum = new Regex("^\\d");
            Regex regId = new Regex("^\\d{9}$");//check id if 9 digits
            Regex regName = new Regex(@"^[a-zA-Z]+$");//check if the string input is vaild
            Regex regAddress = new Regex("[/A-Za-z0-9.-]");//check Address
            switch (type)
            {
                case "email":
                    if (!regemail.IsMatch(input) || input == "")
                        AlertClass.Error("Invalid email");
                    else flag = true;
                    break;

                case "phoneNumber":
                    if (!regPn.IsMatch(input) || input == "")
                        AlertClass.Error("Invalid Phone Number");
                    else flag = true;
                    break;

                case "Number":
                    if (!regNum.IsMatch(input) || input == "")
                        AlertClass.Error("Invalid input");
                    else flag = true;
                    break;
                case "ID":
                    if (!regId.IsMatch(input) || input == "")
                        AlertClass.Error("Invalid Id Number");
                    else flag = true;
                    break;

                case "Name":
                    if (!regName.IsMatch(input) || input == "")
                        AlertClass.Error("Invalid input");
                    else flag = true;
                    break;
                case "Address":
                    if (!regAddress.IsMatch(input) || input == "")
                        AlertClass.Error("invalid input");
                    else
                        flag = true;
                    break;

                    

            }
            return flag;
        }

        public static Boolean check(Image img)
        {
            return true;
        }

        public static Boolean check(DateTime date, int agewithTotalDays)
        {
            DateTime today = DateTime.Today;
            double days = (today - date).TotalDays;
            return days >= agewithTotalDays ? true : false;
        }
        public static Boolean checkDatePayment(DateTimePicker date)
        {
            // DateTime today = DateTime.Today;
            //double days = (date-today ).TotalDays;
            return ((date.MinDate < date.Value) && (date.MaxDate > date.Value)) ? true : false;
        }

        //check if credit card number is valid
        public static Boolean IsCreditCardInfoValid(string input, string type, Button btn)
        {
            bool flag = false;
            Regex regName = new Regex(@"^[a-zA-Z]+$");//check if the string input is vaild
            Regex regFullName = new Regex(@"^[a-zA-Z' ']+$");//check if the string input is vaild
            Regex regVisa = new Regex(@"^4[0-9]{6,}$");//check visa card number
            Regex regMaster = new Regex(@"^5[1-5][0-9]{5,}|222[1-9][0-9]{3,}|22[3-9][0-9]{4,}|2[3-6][0-9]{5,}|27[01][0-9]{4,}|2720[0-9]{3,}$");//check master card numver
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");
            switch (type)
            {
                case "name":
                    if (!regName.IsMatch(input) || input == "")
                        AlertClass.Error("Invalid name input");
                    else flag = true;
                    break;
                case "Fullname":
                    if (!regFullName.IsMatch(input) || input == "")
                        AlertClass.Error("Invalid name input");
                    else flag = true;
                    break;
                case "CardNumber":

                    if (btn.Enabled == false)
                    {
                        if (!regVisa.IsMatch(input) || input == "")
                            AlertClass.Error("Invalid Visa Card Number input");
                        else flag = true;
                    }
                    else
                    {
                        if (!regMaster.IsMatch(input) || input == "")
                            AlertClass.Error("Invalid Master Card Number input");
                        else flag = true;
                    }
                    break;

                case "ccv":
                    if (!cvvCheck.IsMatch(input) || input == "") // <2>check cvv is valid as "999"
                        AlertClass.Error("Invalid CVV");
                    else flag = true;
                    break;
                
            }
            return flag;
        }
        //to check if the person can create this licence return true
        public static Boolean CheckDegree(string degree, DateTime dateOfBirth)
        {
            bool flag = true;
            
            switch (degree)
            {
                case "A2":
                    if (!check(dateOfBirth, 16 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 16 years   ");
                    else flag = false;
                    break;
                case "A1":
                    if (!check(dateOfBirth, 18 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 18 years   ");
                    else flag = false;
                    break;
                case "A":
                    if (!check(dateOfBirth, 21 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 21 years   ");
                    else flag = false;
                    break;
                case "B":
                    if (!check(dateOfBirth, 17 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 17 years   ");
                    else flag = false;
                    break;
                case "C1":
                    if (!check(dateOfBirth, 18 * 365))  
                        
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 18 years   ");
                    else flag = false;
                    break;
                case "C":
                    if (!check(dateOfBirth, 19 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 19 years   ");
                    else flag = false;
                    break;
                case "C+E":
                    if (!check(dateOfBirth, 17 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 20 years   ");
                    else flag = false;
                    break;
                case "D1":
                    if (!check(dateOfBirth, 21 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 21 years   ");
                    else flag = false;
                    break;
                case "D3":
                    if (!check(dateOfBirth, 19 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 19 years   ");
                    else flag = false;
                    break;
                case "D":
                    if (!check(dateOfBirth, 20 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 20 years   ");
                    else flag = false;
                    break;
                case "דרגה 1":
                    if (!check(dateOfBirth, 16 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 16 years   ");
                    else flag = false;
                    break;
                /*---------------------------------------------------------------------------------------------*/
                case "11":
                    if (!check(dateOfBirth, 16 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 16 years   ");
                    else flag = false;
                    break;
                case "12":
                    if (!check(dateOfBirth, 17 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 17 years   ");
                    else flag = false;
                    break;
                case "13":
                    if (!check(dateOfBirth, 18 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 18  years   ");
                    else flag = false;
                    break;
                case"20":
                    if (!check(dateOfBirth, 19 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 19  years   ");
                    else flag = false;
                    break;
                case "21":
                    if (!check(dateOfBirth, 16 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 16 years   ");
                    else flag = false;
                    break;
                case "30":
                    if (!check(dateOfBirth, 18 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 18  years   ");
                    else flag = false;
                    break;
                case "40":
                    if (!check(dateOfBirth, 20 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 20  years   ");
                    else flag = false;
                    break;
                case "50":
                    if (!check(dateOfBirth, 20 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 20  years   ");
                    else flag = false;
                    break;
                case "60":
                    if (!check(dateOfBirth, 19 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 19 years   ");
                    else flag = false;
                    break;
                case "WeaponLicence":
                    if (!check(dateOfBirth, 18 * 365))
                        AlertClass.Error("Invalid Age to create licence becaus yor age is less than 18  years   ");
                    else flag = false;
                    break;

            }
            return flag;
        }
    }
}

