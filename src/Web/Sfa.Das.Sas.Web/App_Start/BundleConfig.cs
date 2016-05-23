﻿using System.Web.Optimization;

namespace Sfa.Das.Sas.Web
{
    public static class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/styles/").Include(
                      "~/Content/dist/css/screen.min.css"));

            bundles.Add(new ScriptBundle("~/scripts/app").Include(
                "~/scripts/app/*.js",
                "~/scripts/standard-detail.js",
                "~/scripts/appsettings.js"));

            bundles.Add(new ScriptBundle("~/static_js_footer").Include(
                "~/scripts/vendor/modernizr.js",
                "~/scripts/vendor/jquery.js",
                "~/scripts/vendor/jquery-cookie.js"
                ));
        }
    }
}
