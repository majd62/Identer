using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Collections.Specialized;


namespace Identer
{
    class AlertClass
    {
        public static void success(string msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, Form_Alert.enmType.Success);
        }
        public static void Warning(string msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, Form_Alert.enmType.Warning);
        }
        public static void Error(string msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, Form_Alert.enmType.Error);
        }
        public static void Info(string msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, Form_Alert.enmType.Info);
        }
        public static void SendVerifyCode(string msg, int phoneNum)
        {
            const string accountSid = "AC3f5cdaa20ace2488e6f7f613d5a7fff6";//server account sid
            const string authToken = "148b0cd4b16ef2031033e788269f63d3";
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                body: "This is your 4 digit code " + msg,
                from: new Twilio.Types.PhoneNumber("+13343731527"),
                to: new Twilio.Types.PhoneNumber("+972" + phoneNum)
            );
        }
        public static void createPdf(string htmlCode, string htmlFilePath, string outputPath, string price, string cardType,string name,string visaType,string cardNumber)//htmlFilePath ==>the path where we want to save the Html File , outputpath ==> the path where we want to save the  File 
        {
            Random randomNumber = new Random();
            FileStream fs = new FileStream(@".\data\html\Payment.html", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sr = new StreamWriter(fs);
            // היא מקבלת ערך טקסט מחפשת עליו ומחליפה אותו בכל המקומות REPLACE
            htmlCode = htmlCode.Replace("000001", randomNumber.Next(10000000, 99999999).ToString());// מספר אישור תשלום
            htmlCode = htmlCode.Replace("000002", DateTime.Now.ToString());//תאריך ההזמנה
            htmlCode = htmlCode.Replace("000003", name);//שם לקוח להפקת אישור תשלום
            htmlCode = htmlCode.Replace("000004", price); //מחיר
            htmlCode = htmlCode.Replace("000005", price);//כוללת עלות
            htmlCode = htmlCode.Replace("000006", visaType); //סוג תשלום
            htmlCode = htmlCode.Replace("000007", cardNumber.Substring(12).ToString());//ארבע ספרות אחרונות
            htmlCode = htmlCode.Replace("תעודת זהות", cardType);// סוג כרטיס       
            sr.WriteLine(htmlCode);
            sr.Close();
            var Renderer2 = new IronPdf.HtmlToPdf();
            var PDF2 = Renderer2.RenderHTMLFileAsPdf(htmlFilePath);
            var OutputPath2 = outputPath;
            PDF2.SaveAs(OutputPath2);
        }

        public static void createPdf(string htmlCode, string htmlFilePath, string outputPath, string price, string cardType, string name)//htmlFilePath ==>the path where we want to save the Html File , outputpath ==> the path where we want to save the  File 
        {
            Random randomNumber = new Random();
            FileStream fs = new FileStream(@".\data\html\Payment.html", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sr = new StreamWriter(fs);
            // היא מקבלת ערך טקסט מחפשת עליו ומחליפה אותו בכל המקומות REPLACE
            htmlCode = htmlCode.Replace("000001", randomNumber.Next(10000000, 99999999).ToString());// מספר אישור תשלום
            htmlCode = htmlCode.Replace("000002", DateTime.Now.ToString());//תאריך ההזמנה
            htmlCode = htmlCode.Replace("000003", name);//שם לקוח להפקת אישור תשלום
            htmlCode = htmlCode.Replace("000004", price); //מחיר
            htmlCode = htmlCode.Replace("000005", price);//כוללת עלות
            htmlCode = htmlCode.Replace("תעודת זהות", cardType);// סוג כרטיס       
            sr.WriteLine(htmlCode);
            sr.Close();
            var Renderer2 = new IronPdf.HtmlToPdf();
            var PDF2 = Renderer2.RenderHTMLFileAsPdf(htmlFilePath);
            var OutputPath2 = outputPath;
            PDF2.SaveAs(OutputPath2);
        }
        //send Email with attachment
        public static void sendEmail(string path, string msgsubject, string msgbody, string email)
        {
            try
            {
                success(email);
                MailMessage mail = new MailMessage("majx1972@gmail.com", email, msgsubject, msgbody);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                mail.Attachments.Add(new Attachment(path));
                client.Port = 587;
                client.Credentials = new NetworkCredential("majx1972@gmail.com", "majd.sadi");
                client.EnableSsl = true;
                client.Send(mail);
                success("Email Sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        //send Email without attachment
        public static void sendEmail(string msgsubject, string msgbody, string email)
        {
            try
            {
                success(email);
                MailMessage mail = new MailMessage("majx1972@gmail.com", email, msgsubject, msgbody);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new NetworkCredential("majx1972@gmail.com", "majd.sadi");
                client.EnableSsl = true;
                client.Send(mail);
                success("Email Sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
