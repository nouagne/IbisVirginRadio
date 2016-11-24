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
               new { controller = "Home", action = "NoEvent" },
               namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers" }
            );

            routes.MapRoute(
                name: "Index",
                url: "{eventId}",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers" }
            );

            routes.MapRoute(
               "Confirm",
               "{eventId}/confirm",
               new { controller = "Home", action = "Confirm" },
                namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers" }
           );

            routes.MapRoute(
                name: "Validate",
                url: "{eventId}/validate",
                defaults: new { controller = "Home", Action = "Validate" },
                namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers" }
            );

            routes.MapRoute(
               "Invite",
               "{eventId}/invite",
               new { controller = "Home", action = "Invite" },
                namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers" }
            );

            routes.MapRoute(
               "EventEnded",
               "{eventId}/fin",
               new { controller = "Home", action = "End" },
                namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers" }
            );

            routes.MapRoute(
                "Default", 
                "{controller}/{action}/{id}", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Controllers" }
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
