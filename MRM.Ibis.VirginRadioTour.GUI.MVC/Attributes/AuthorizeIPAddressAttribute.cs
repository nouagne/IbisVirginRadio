using System;
using System.Configuration;
using System.Web;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Attributes
{
    public class AuthorizeIPAddressAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            string ipAddress = HttpContext.Current.Request.UserHostAddress;

            if (!IsIpAddressValid(ipAddress.Trim()))
            {
                filterContext.Result = new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
        }

        public static bool IsIpAddressValid(string ipAddress)
        {
            string[] incomingOctets = ipAddress.Trim().Split(new char[] { '.' });

            string addresses =
              Convert.ToString(ConfigurationManager.AppSettings["AuthorizeIPAddresses"]);

            string[] validIpAddresses = addresses.Trim().Split(new char[] { ',' });

            foreach (var validIpAddress in validIpAddresses)
            {
                if (validIpAddress.Trim() == ipAddress)
                {
                    return true;
                }

                string[] validOctets = validIpAddress.Trim().Split(new char[] { '.' });

                bool matches = true;

                for (int index = 0; index < validOctets.Length; index++)
                {
                    if (validOctets[index] != "*")
                    {
                        if (validOctets[index] != incomingOctets[index])
                        {
                            matches = false;
                            break; 
                        }
                    }
                }

                if (matches)
                {
                    return true;
                }
            }

            return false;
        } 
    }
}