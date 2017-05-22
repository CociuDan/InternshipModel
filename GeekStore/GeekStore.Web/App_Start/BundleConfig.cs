using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace GeekStore.UI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js",
                       "~/Scripts/jquery-ui-{version}.js",
                       "~/Scripts/jtable/jquery.jtable.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/").Include(
                      "~/Content/bootstrap-custom.css",
                      "~/Content/jquery-ui*",
                      "~/Content/CSS.css",
                      "~/Scripts/jtable/themes/metro/darkgray/jtable.css"
                      ));
        }
    }
}