using System.Configuration;
using System.Net.Mail;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.Core.Tools
{
    /// <summary>
    /// Fournit des propriétés et des méthodes pour l'envoi d'email
    /// </summary>
    public static class Email
    {
        /// <summary>
        /// Envoie un email à partir d'un template et à l'aide d'un modèle
        /// </summary>
        /// <param name="mailMessage">Objet MailMessage à envoyer</param>
        /// <param name="viewName">Nom de la vue/template devant être utiliséé comme support du mail</param>
        /// <param name="model">Objet représentant le model à envoyer à la vue</param>
        /// <param name="isBodyHtml">Indique si le mail doit être expédié au format HTML ou non</param>
        public static void Send(MailMessage mailMessage, string viewName, object model, bool isBodyHtml = true)
        {
            MvcRenderEngine.RenderEngineBase renderEngine = new MvcRenderEngine.RenderEngineBase();
            renderEngine.ViewData = new ViewDataDictionary() { Model = model };
            renderEngine.ViewData.Add("MailMessage", mailMessage);
            mailMessage.Body = renderEngine.Render(viewName, new EmailViewEngine());
            mailMessage.IsBodyHtml = isBodyHtml;
            SmtpClient client = new SmtpClient(ConfigurationManager.AppSettings.Get("SMTP"));
            client.Send(mailMessage);
        }
    }

    /// <summary>
    /// Représente un moteur d'affichage permettant de restituer une page Web qui utilise la synthaxe ASP.NET Razor
    /// </summary>
    public class EmailViewEngine : RazorViewEngine
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe EmailViewEngine
        /// </summary>
        public EmailViewEngine()
            : base()
        {
            ViewLocationFormats = new[] {
                "~/Views/Email/{0}.cshtml",
                "~/Views/Shared/Email/{0}.cshtml"
            };

            PartialViewLocationFormats = ViewLocationFormats;
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            return base.CreateView(controllerContext, viewPath, masterPath);
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            return base.CreatePartialView(controllerContext, partialPath);
        }

        protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        {
            return base.FileExists(controllerContext, virtualPath);
        }
    }
}
