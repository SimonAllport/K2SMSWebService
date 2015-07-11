using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using K2SMS.SendSMS;

namespace SendSMS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public void SendMessage(string Mobile,string Message)
        {
            string[] numbers = Mobile.Split(';');
            if (numbers.Count() == 0)
            {
                K2SMS.SendTxt.SendMessage(Message, Mobile);
            }
            else
            {
                foreach (string number in numbers)
                {
                    K2SMS.SendTxt.SendMessage(Message, number);
                }
            }
           

        }
      
    }
}