using System;
using System.Web;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Helpers
{
    /// <summary>
    /// Contient des méthodes pour générer des URL pour MVC ASP.NET dans une application.
    /// </summary>
    public static class UrlExtensions
    {
        /// <summary>
        /// Génère une URL qualifiée complète et absolue pour une méthode d'action à l'aide du nom d'action, du nom de contrôleur et des valeurs d'itinéraire.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="actionName">Nom de la méthode d'action.</param>
        /// <param name="controllerName">Nom du contrôleur.</param>
        /// <param name="routeValues">Objet qui contient les paramètres d'un itinéraire.</param>
        /// <returns></returns>
        public static string AbsoluteAction(this UrlHelper url, string actionName, string controllerName, object routeValues = null)
        {
            return url.Action(actionName, controllerName, routeValues, url.RequestContext.HttpContext.Request.Url.Scheme);
        }

        /// <summary>
        /// Convertit un chemin d'accès (relatif) virtuel en chemin d'accès absolu.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path">Chemin d'accès absolu de l'application.</param>
        /// <returns></returns>
        public static string AbsoluteContent(this UrlHelper url, string path)
        {
            Uri uri = new Uri(path, UriKind.RelativeOrAbsolute);

            //If the URI is not already absolute, rebuild it based on the current request.
            if (!uri.IsAbsoluteUri)
            {
                Uri requestUrl = url.RequestContext.HttpContext.Request.Url;
                UriBuilder builder = new UriBuilder(requestUrl.Scheme, requestUrl.Host, requestUrl.Port);

                builder.Path = VirtualPathUtility.ToAbsolute(path);
                uri = builder.Uri;
            }

            return uri.ToString();
        }
    }
}