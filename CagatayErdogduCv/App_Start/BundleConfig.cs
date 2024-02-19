using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CagatayErdogduCv.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) 
        {
            bundles.Add(new StyleBundle("~/cssBundle/allstyles").Include(
                "~/assets/vendor/aos/aos.css",
                "~/assets/vendor/bootstrap/css/bootstrap.min.css",
                "~/assets/vendor/bootstrap-icons/bootstrap-icons.css",
                "~/assets/vendor/boxicons/css/boxicons.min.css",
                "~/assets/vendor/glightbox/css/glightbox.min.css",
                "~/assets/vendor/swiper/swiper-bundle.min.css",
                "~/assets/css/style.css"));

            bundles.Add(new ScriptBundle("~/jsBunlde/allscripts").Include(
                "~/assets/vendor/purecounter/purecounter_vanilla.js",
                "~/assets/vendor/aos/aos.js",
                "~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/assets/vendor/glightbox/js/glightbox.min.js",
                "~/assets/vendor/isotope-layout/isotope.pkgd.min.js",
                "~/assets/vendor/swiper/swiper-bundle.min.js",
                "~/assets/vendor/typed.js/typed.umd.js",
                "~/assets/vendor/waypoints/noframework.waypoints.js",
                "~/assets/vendor/php-email-form/validate.js",
                "~/assets/js/main.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}