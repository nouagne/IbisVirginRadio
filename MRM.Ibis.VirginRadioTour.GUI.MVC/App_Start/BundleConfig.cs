using System.Web;
using System.Web.Optimization;

namespace MRM.Ibis.VirginRadioTour.GUI.MVC
{
    public class BundleConfig
    {
        // Pour plus d’informations sur le regroupement, rendez-vous sur http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Statics/js/jquery-{version}.js"));

            // Utilisez la version de développement de Modernizr pour développer et apprendre. Puis, lorsque vous êtes
            // prêt pour la production, utilisez l’outil de génération sur http://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Statics/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Statics/js/bootstrap.js",
                      "~/Statics/js/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Statics/css/bootstrap.css",
                      "~/Statics/css/site.css"));
        }
    }
}
