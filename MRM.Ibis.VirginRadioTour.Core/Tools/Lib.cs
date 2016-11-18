using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Routing;

namespace MRM.Ibis.VirginRadioTour.Core.Tools
{
    /// <summary>
    /// Fournit des propriétés et des méthodes pour diverses opérations
    /// </summary>
    public static class Lib
    {
        /// <summary>
        /// Vérifie si la chaine de caracteres spécifiée est au format email
        /// </summary>
        /// <param name="string2Verify">Chaine de caractères à vérifier</param>
        /// <returns>Booléen determinant si la chaine est au format email ou non</returns>
        public static bool IsMailFormat(string string2Verify)
        {
            try
            {
                System.Net.Mail.MailAddress test = new System.Net.Mail.MailAddress(string2Verify);
                return Regex.IsMatch(string2Verify,
                    @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"); 
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Transforme une NameValueCollection en RouteValueDictionary
        /// </summary>
        /// <param name="nvc">NameValueCollection devant être transformée</param>
        /// <returns>RouteValueDictionary contenant l'ensemble des clés/valeurs de la NameValueCollection</returns>
        public static RouteValueDictionary ToRouteValues(this NameValueCollection nvc)
        {
            if (nvc == null || nvc.HasKeys() == false) return new RouteValueDictionary();

            var routeValues = new RouteValueDictionary();
            foreach (string key in nvc.AllKeys)
                routeValues.Add(key, nvc[key]);

            return routeValues;
        }

        /// <summary>
        /// Transforme une NameValueCollection en QueryString
        /// </summary>
        /// <param name="nvc">NameValueCollection devant être transformée</param>
        /// <returns>Chaine de caractères contenant l'ensemble des clés/valeurs de la NameValueCollection</returns>
        public static string ToQueryString(this NameValueCollection nvc)
        {
            return string.Join("&", Array.ConvertAll(nvc.AllKeys, key => string.Format("{0}={1}", key, nvc[key])));
        }

        /// <summary>
        /// Implémente TextWriter pour l'écriture d'informations dans une chaîne au format UTF-8
        /// </summary>
        public class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get { return Encoding.UTF8; }
            }
        }

        /// <summary>
        /// Retourne une valeur utilisée pour l'affichage 
        /// </summary>
        /// <param name="value">Valeur de l'énumérateur</param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum value)
        {
            if (value == null)
                return string.Empty;

            var type = value.GetType();
            if (!type.IsEnum) throw new ArgumentException(String.Format("Type '{0}' is not Enum", type));

            var members = type.GetMember(value.ToString());
            if (members.Length == 0) throw new ArgumentException(String.Format("Member '{0}' not found in type '{1}'", value, type.Name));

            var member = members[0];
            var attributes = member.GetCustomAttributes(typeof(DisplayAttribute), false);
            if (attributes.Length == 0) throw new ArgumentException(String.Format("'{0}.{1}' doesn't have DisplayAttribute", type.Name, value));

            var attribute = (DisplayAttribute)attributes[0];
            return attribute.GetName();
        }

        /// <summary>
        /// retourne l'adresse IP
        /// </summary>
        /// <returns></returns>
        public static IPAddress GetLocalIpAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                return null;

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }
    }
}
