using System.Web.Optimization;

namespace Project_Insecap.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            /*

             */
            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/vendors/ti-icons/css/themify-icons.css",
                "~/Content/vendors/css/vendor.bundle.base.css",
                "~/Content/vendors/iconfonts/mdi/font/css/materialdesignicons.min.css",
                "~/Content/css/vertical-layout-light/style.css"));
            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include("~/Content/vendors/js/vendor.bundle.base.js",
                        "~/Content/vendors/chart.js/Chart.min.js'",
                        "~/Content/js/off-canvas.js'",
                        "~/Content/js/hoverable-collapse.js'",
                        "~/Content/js/template.js'",
                        "~/Content/js/settings.js'",
                        "~/Content/js/todolist.js' ",
                        "~/Content/js/dashboard.js'"));

        }
    }
}