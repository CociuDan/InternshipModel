﻿using System.Web.Optimization;

namespace GeekStore.UI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js",
                       "~/Scripts/bootstrap.js",
                       "~/Scripts/jquery-ui-{version}.js",
                       "~/Scripts/jtable/jquery.jtable.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/").Include(
                      "~/Content/CSS.css",
                      "~/Content/bootstrap.css",
                      "~/Content/themes/base/jquery-ui*",                      
                      "~/Scripts/jtable/themes/metro/darkgray/jtable.css"
                      ));
        }
    }
}