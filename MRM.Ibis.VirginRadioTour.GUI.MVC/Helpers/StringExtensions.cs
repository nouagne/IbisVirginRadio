using System;
using System.Web;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Helpers
{
    /// <summary>
    /// Contient des méthodes pour manipuler les chaines de caractères.
    /// </summary>
    public static partial class StringExtensions
    {
        /// <summary>
        /// Tronque une chaine de caractères au dela d'une taille spécifiée et ajoute la pontuation, sinon retourne la chaine d'origine.
        /// </summary>
        /// <param name="text">Chaine de caractères à tronquer.</param>
        /// <param name="maxLength">Longueur maximale de la chaine à retourner.</param>
        /// <param name="punctuation">Caractères à ajouter en fin de chaine.</param>
        /// <returns></returns>
        public static string Truncate(this string text, int maxLength, string punctuation)
        {
            if (text.Length > maxLength) return String.Format("{0}{1}", text.Substring(0, maxLength), punctuation ?? "...");
            return text;
        }

        /// <summary>
        /// Transforme une chaine de caractères en HTML, en remplacant les \n en br
        /// </summary>
        /// <param name="text">Chaine de caractères à transformer.</param>
        /// <returns></returns>
        public static HtmlString Html(this string text)
        {
            return new HtmlString(text.Replace("\n", "<br/>"));
        } 
    }
}