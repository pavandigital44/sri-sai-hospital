using System.Web;
using System.Web.Optimization;

namespace SSH.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/assets/vendor/jquery-1.12.4.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/unob").Include(
                       "~/Scripts/jquery.unobtrusive-ajax.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/unobval").Include(
                      "~/Scripts/jquery.validate.unobtrusive.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //           "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                        "~/Scripts/assets/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/Bootstrap").Include(
                        "~/Scripts/assets/bootstrap.min.js"));
            

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //            "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/carousel").Include(
                        "~/Scripts/assets/owl.carousel.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Counter").Include(
                        "~/Scripts/assets/owl.counterup.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/waypoints").Include(
                        "~/Scripts/assets/owl.waypoints.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/meanmenu").Include(
                        "~/Scripts/assets/jquery.meanmenu.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/formvalidation").Include(
                        "~/Scripts/assets/form.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        "~/Scripts/plugins.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                        "~/Scripts/custom.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css"));
        }
    }
}
