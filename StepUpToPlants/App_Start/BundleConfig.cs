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
                     "~/Content/css/fontawesome-all.min.css",
                      "~/Content/css/main.css",
                      "~/Content/css/noscript.css",
                      "~/Content/bootstrap.css",
                      "~/Content/style.css"));

            bundles.Add(new StyleBundle("~/Content/sass").Include(
                "~/Content/sass/base/_page.scss",
                "~/Content/sass/base/_reset.scss",
                "~/Content/sass/components/_actions.scss",
                "~/Content/sass/components/_box.scss",
                "~/Content/sass/components/_button.scss",
                "~/Content/sass/components/_form.scss",
                "~/Content/sass/components/_icon.scss",
                "~/Content/sass/components/_icons.scss",
                "~/Content/sass/components/_image.scss",
                "~/Content/sass/components/_list.scss",
                "~/Content/sass/components/_pagination.scss",
                "~/Content/sass/components/_row.scss",
                "~/Content/sass/components/_section.scss",
                "~/Content/sass/components/_table.scss",
                "~/Content/sass/layout/_footer.scss",
                "~/Content/sass/layout/_header.scss",
                "~/Content/sass/layout/_intro.scss",
                "~/Content/sass/layout/_main.scss",
                "~/Content/sass/layout/_nav.scss",
                "~/Content/sass/layout/_navPanel.scss",
                "~/Content/sass/layout/_wrapper.scss",
                "~/Content/sass/libs/_breakpoint.scss",
                "~/Content/sass/libs/_fixed-grid.scss",
                "~/Content/sass/libs/_functions.scss",
                "~/Content/sass/libs/_html-grid.scss",
                "~/Content/sass/libs/_mixins.scss",
                "~/Content/sass/libs/_vars.scss",
                "~/Content/sass/libs/_vendor.scss",
                "~/Content/sass/main.scss",
                "~/Content/sass/noscript.scss"
                )) ;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js",
                       "~/Scripts/js/bootstrap.js",
                       "~/Scripts/js/browser.min.js",
                       "~/Scripts/js/jquery.min.js",
                       "~/Scripts/js/jquery.scrollex.min.js",
                       "~/Scripts/js/jquery.scrolly.min.js",
                       "~/Scripts/js/main.js",
                        "~/Scripts/js/util.js"
                       ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/util.js"));


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
