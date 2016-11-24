using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC.Areas
{
    public class AdminAresRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //context.MapRoute(
            //   "Admin_search",
            //   "admin/search",
            //   new { controller = "Home", action = "Search" },
            //   namespaces: new[] { "MRM.Delacre.MailBox.GUI.MVC.Areas.Admin.Controllers" }
            //   );
            //context.MapRoute(
            //   "Admin_client",
            //   "admin/client/{id}",
            //   new { controller = "Client", action = "Index" },
            //   namespaces: new[] { "MRM.Delacre.MailBox.GUI.MVC.Areas.Admin.Controllers" }
            //   );

            context.MapRoute(
                "Admin_login",
                "admin/login",
                new { controller = "Home", action = "LogIn" },
                namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Areas.Admin.Controllers" }
            );


            context.MapRoute(
                "Admin_default",
                "admin/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MRM.Ibis.VirginRadioTour.GUI.MVC.Areas.Admin.Controllers" }
            );

        }
    }
}