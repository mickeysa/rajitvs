using System.Web;
using System.Web.Optimization;

namespace outsourcing.rajitservices
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", "~/assets/css/animate.css",
                      "~/assets/css/bootsnav.css", "~/assets/css/bootstrap.min.css",
                      "~/assets/css/font-awesome.min.css", "~/assets/css/hover-min.css", 
                      "~/assets/css/icon-font.min.css", "~/assets/css/magnific-popup.css",
                      "~/assets/css/owl.carousel.min.css", "~/assets/css/owl.theme.default.min.css",
                      "~/assets/css/responsive.css","~/assets/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/myscripts").Include(
                    "~/assets/js/bootnav.js",
                    "~/assets/js/custome.js", "~/assets/js/jak-menusearch.js", 
                    "~/assets/js/jquery.counterup.min.js", "~/assets/js/jquery.easing.min.js",
                    "~/assets/js/jquery.hc-sticky.min.js", "~/assets/js/jquery.js",
                    "~/assets/js/jquery.magnific-popup.min.js", "~/assets/js/jquery.sticky.js",
                    "~/assets/js/modernizr.min.js", "~/assets/js/owl.carousel.min.js",
                    "~/assets/js/waypoints.min.js"));

        }
    }
}
