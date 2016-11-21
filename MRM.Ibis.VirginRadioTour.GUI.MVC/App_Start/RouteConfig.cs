using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
               "NoEvent",
               "aucun-live",
               new { controller = "Home", action = "NoEvent" }
            );

            routes.MapRoute(
                name: "Index",
                url: "{eventId}",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
               "Confirm",
               "{eventId}/confirm",
               new { controller = "Home", action = "Confirm" }
           );

            routes.MapRoute(
                name: "Validate",
                url: "{eventId}/validate",
                defaults: new { controller = "Home", Action = "Validate" }
            );

            routes.MapRoute(
               "Invite",
               "{eventId}/invite",
               new { controller = "Home", action = "Invite" }
            );

            routes.MapRoute(
               "EventEnded",
               "{eventId}/fin",
               new { controller = "Home", action = "End" }
            );

            routes.MapRoute(
                "Default", 
                "{controller}/{action}/{id}", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

    /// <summary>
    /// Détermine si le paramètre d'URL contient une valeur représentant un GUID
    /// </summary>
    public class GuidConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (values.ContainsKey(parameterName))
            {
                string stringValue = values[parameterName] as string;

                if (!string.IsNullOrEmpty(stringValue))
                {
                    Guid guidValue;

                    return Guid.TryParse(stringValue, out guidValue) && (guidValue != Guid.Empty);
                }
            }
            return false;
        }
    }
}
