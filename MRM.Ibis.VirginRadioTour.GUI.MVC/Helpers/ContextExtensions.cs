using System.Net.Mail;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Helpers
{
    /// <summary>
    /// Contient des méthodes pour manipuler des objets présent dans le contexte.
    /// </summary>
    public static class ContextExtensions
    {
        /// <summary>
        /// Retourne l'objet MailMessage présent dans le ViewContext
        /// </summary>
        /// <param name="viewContext">Informations relatives au rendu de la vue actuelle.</param>
        /// <returns></returns>
        public static MailMessage MailMessage(this ViewContext viewContext)
        {
            return (MailMessage)viewContext.ViewData["mailMessage"];
        }
    }
}