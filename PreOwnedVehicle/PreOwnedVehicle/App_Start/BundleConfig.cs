using System.Web;
using System.Web.Optimization;

namespace PreOwnedVehicle
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/newjquery").Include(
            "~/Content/newstrap/lib/jquery/jquery.min.js",
            "~/Content/newstrap/lib/jquery/jquery-migrate.min.js",
            "~/Content/newstrap/lib/bootstrap/js/bootstrap.bundle.min.js",
            "~/Content/newstrap/lib/easing/easing.min.js",
            "~/Content/newstrap/lib/mobile-nav/mobile-nav.js",
            "~/Content/newstrap/lib/wow/wow.min.js",
            "~/Content/newstrap/lib/waypoints/waypoints.min.js",
            "~/Content/newstrap/lib/counterup/counterup.min.js",
            "~/Content/newstrap/lib/owlcarousel/owl.carousel.min.js",
            "~/Content/newstrap/lib/isotope/isotope.pkgd.min.js",
            "~/Content/newstrap/lib/lightbox/js/lightbox.min.js",
            "~/Content/newstrap/contactform/contactform.js",
            "~/Content/newstrap/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/newcss").Include(
          "~/Content/newstrap/lib/bootstrap/css/bootstrap.min.css",
          "~/Content/newstrap/lib/font-awesome/css/font-awesome.min.css",
          "~/Content/newstrap/lib/animate/animate.min.css",
          "~/Content/newstrap/lib/ionicons/css/ionicons.min.css",
          "~/Content/newstrap/lib/owlcarousel/assets/owl.carousel.min.css",
          "~/Content/newstrap/lib/lightbox/css/lightbox.min.css",
          "~/Content/newstrap/css/style.css"));
        }
    }
}
