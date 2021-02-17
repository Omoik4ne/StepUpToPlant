using System.Web;
using System.Web.Optimization;

namespace StepUpToPlants
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/main.css",
                      "~/Content/css/noscript.css",
                      "~/Content/bootstrap.css"));

            //bundles.Add(new StyleBundle("~/Content/sass").Include(
            //    "~/Content/sass/main.scss",
            //    "~/Content/sass/noscript.scss"
            //    ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"
                       //"~/Scripts/js/bootstrap.js"
                       //"~/Scripts/js/browser.min.js",
                       //"~/Scripts/js/jquery.min.js",
                       //"~/Scripts/js/jquery.scrollex.min.js",
                       //"~/Scripts/js/jquery.scrolly.min.js",
                       //"~/Scripts/js/main.js",
                       // "~/Scripts/js/util.js"
                       ));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/assets/js/util.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/assets/js/main.js"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include( 
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/bootstrap.bundle.min.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
