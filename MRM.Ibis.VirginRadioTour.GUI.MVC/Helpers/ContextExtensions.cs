using MRM.Ibis.VirginRadioTour.Core.BLL;
using MRM.Ibis.VirginRadioTour.Core.BO;
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

        public static Event GetEventDetails (this ViewContext viewContext)
        {
            try
            {
                var eventManager = new EventManager();

                var model = (Participation)viewContext.ViewData.Model;
                return eventManager.FindByName(model.EventId);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            
        }
    }
}