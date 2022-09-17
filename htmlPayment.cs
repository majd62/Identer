using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identer
{
    class htmlPayment
    {
        //html page to print receipts
        public static string textRender()
        {
            string myHtml = @"<!DOCTYPE html>
<html lang=""he"" xmlns=""http://www.w3.org/1999/xhtml"">

<head>
    <meta charset = ""utf-8"" content = ""text/html""/>
   
       <title> שירות התשלומים הממשלתי -אישור תשלום </title>
     </head>
     

     <body style = ""direction: rtl;"">
      
          <form id = ""form1"">
       
               <table cellspacing = ""0"" cellpadding = ""0"" style = ""width: 800px; margin: 0 auto; border: 1px solid #c0e0ff; border-spacing: 0px; table-layout:fixed; "">
            
                        <tr style = ""height:73px;background-color:#285c7e;"">
             
                             <td style = ""padding:15px;"">
              
                                  <div style = ""font-size: 18px; font-family: ariel; color: #fff;""> מדינת ישראל </div>
                   
                                       <div style = ""font-size: 18px; font-family: ariel; color: #fff;""> יצירת תעודת זהות</div>
                        
                                        </td>
                        
                                    </tr>
                        
                                </table>
                        
                                <table style = ""width: 800px; margin: 0 auto; border: 1px solid #c0e0ff; border-spacing: 0px; padding:15px;"">
                         
                                     <tr>
                         
                                         <td>
                         
                                             <div style = ""font-family: Arial; font-weight: bold; font-size: 26px; color: #285c7e;""> משרד הפנים | תעודת זהות </div>
                              
                                              </td>
                              
                                          </tr>
                              
                                          <tr>
                              
                                              <td>
                              
                                                  <div style = ""font-family: Arial; font-weight: bold; font-size: 18px; color: #285c7e;""> אישור תשלום </div>
                                   
                                                   </td>
                                   
                                               </tr>
                                   
                                               <tr>
                                   
                                                   <td><span style = ""color: #285c7e; font-family: Arial; font-weight: bold; font-size: 18px;""> התשלום עבור משרד הפנים | ייצור תעודת זהות בוצע בהצלחה</span></td>
                                          
                                                      </tr>
                                          
                                                      <tr>
                                          
                                                          <td style = ""font-size: 18px; font-family: Arial; padding: 5px; direction:rtl;"">
                                           
                                                               <table style = ""border-spacing: 5px 8px; font-size: 18px; font-family: Arial; padding: 5px;"">
                                            
                                                                    <tr>
                                            
                                                                        <td> מספר אישור תשלום:</td>
                                               
                                                                           <td> &nbsp;000001</td>
                                                  
                                                                          </tr>
                                                  
                                                                          <tr>
                                                  
                                                                              <td> תאריך ההזמנה
                                                                                     :</td>
                                                     
                                                                                 <td> &nbsp;000002</td>
                                                        
                                                                                </tr>
                                                        
                                                                                <tr>
                                                        
                                                                                    <td> שם לקוח להפקת אישור תשלום:

                            </td>
                            <td> &nbsp; 000003</td>
   
                           </tr>
   
                       </table>
   
                       <div style = ""padding:5px;""> שלום רב <br/> להלן פרטי אישור התשלום עבור שירות התשלומים הממשלתי <br/></div><br/>
           
                               <div style = ""background: #263c4a; padding: 7px; color:#fff;width:100%;font-family:Arial;font-weight:bold;font-size:18px;""> פרטים לעסקה
                                    </div>
                
                                    <div style = ""padding:5px;"">
                 
                                         <table border = ""1"" style = ""border-collapse:collapse; border-spacing:10px 8px;font-size:18px; font-family: Arial; padding: 5px;"">
                    
                                                <tr>
                    
                                                    <td> &nbsp; &nbsp; &nbsp;</td>
                         
                                                         <td> &nbsp;<b> שם השובר </b> &nbsp;</td>
                                   
                                                                   <td> &nbsp;<b> כמות </b> &nbsp;</td>
                                             
                                                                             <td> &nbsp;<b> מחיר </b> &nbsp;</td>
                                                       
                                                                                   </tr>
                                                       
                                                                                   <tr>
                                                       
                                                                                       <td> 1 </td>
                                                       
                                                                                       <td> משרד הפנים - ייצור תעודת זהות<br/></td>
                                                          
                                                                                          <td> 1 </td>
                                                          
                                                                                          <td> ₪000004</td>
                                                            
                                                                                        </tr>
                                                            
                                                                                    </table><br/><b> עלות כוללת
                                                                                              : ₪000005</b>
                                                                  
                                                                                      </div>
                                                                  
                                                                                      <div style = ""background: #263c4a; padding: 7px; color: #fff; width:100%;font-family: Arial; font-weight: bold; font-size: 18px;""> פרטי תשלום </div><br/>
                                                                       
                                                                                           <div style = ""padding:10px;""> צורת תשלום: תשלום רגיל, כרטיס אשראי 000006<br/><span> ארבע ספרות אחרונות: </span>000007<span> </span><br/><span>  
                                                                                                                     </span><span></span><br/> מספר אישור מחברת האשראי / בנק: 0254474 <br/></div><br/> <br/>
                                                                                                        
                                                                                                                        </td>
                                                                                                        
                                                                                                                    </tr>
                                                                                                        
                                                                                                                    <tr>
                                                                                                        
                                                                                                                        <td>
                                                                                                        
                                                                                                                            <pstyle = ""font-size: 18px; font-family: Arial; color: Black;""><b> נתקלת בבעיה</b>?<br/><span>ניתן לייצור איתנו קשר במייל</span>&nbsp; &nbsp;<span style=""color: #3c65ec;""><a href=""theHackers""> moked@mail.gov.il</a></span><br/><span>&nbsp; או בטלפון<b>&nbsp;1299(ללא כוכבית) </b></span><span> &nbsp;<br/> שעות הפעילות: ראשון עד חמישי בין השעות 08:00 - 19:00 <br/></span></p>
                                                                                                                                                      
                                                                                                                                                                      </td>
                                                                                                                                                      
                                                                                                                                                                  </tr>
                                                                                                                                                      
                                                                                                                                                              </table>
                                                                                                                                                      
                                                                                                                                                          </form>
                                                                                                                                                      <body>
                                                                                                                                                      

                                                                                                                                                      </html>
                                                                                                                                                      ";
            return myHtml;
        }
    }
}
