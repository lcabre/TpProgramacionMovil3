using System.Web;
using System.Web.Optimization;

namespace TpProgramacionMovil3
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/jquery/jquery-3.3.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryvalidate").Include(
                        "~/js/jquery/jquery.validate.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/js/bootstrap/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/bootstrap/bootstrap.min.css",
                      "~/css/fontawesome/css/all.min.css",
                      "~/css/estilos.css"));
        }
    }
}
