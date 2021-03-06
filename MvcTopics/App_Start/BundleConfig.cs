﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MvcTopics.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection  bundles)
        {
            bundles.Add(new ScriptBundle("~/bundle/scripts").Include("~/Scripts/jquery-1.8.0.min.js"));
            bundles.Add(new ScriptBundle("~/bundle/scripts").Include("~/Scripts/jquery-{version}.min.js"));
            bundles.Add(new ScriptBundle("~/bundle/scripts").Include("~/Scripts/jquery*"));//* başlayanları getir

            bundles.Add(new ScriptBundle("~/bundle/scripts").IncludeDirectory("~/Scripts/","JavaScript*",true));//alt klasörler dahil edildi.

            bundles.Add(new StyleBundle("~/bundle/style").Include("~/content/css/site.css").Include("~/ content/css/site.css",new CssRewriteUrlTransform()));

            BundleTable.EnableOptimizations = true;//minification devreye girer
        }
    }
}  