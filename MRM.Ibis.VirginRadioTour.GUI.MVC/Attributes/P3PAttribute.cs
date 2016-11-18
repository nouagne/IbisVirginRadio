using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Attributes
{
    /// <summary>
    /// Représente un attribut qui ajoute le Header P3P à la réponse
    /// </summary>
    public class P3PAttribute : ActionFilterAttribute
    {        
        /// <summary>
        /// Appelée avant la méthode d'action
        /// </summary>
        /// <param name="filterContext">Informations sur les requêtes et actions actuelles</param>        
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.AddHeader("p3p", "CP=\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\"");
            base.OnActionExecuting(filterContext);
        }
    }
}