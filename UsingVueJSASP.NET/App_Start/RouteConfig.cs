using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace UsingVueJSASP.NET
{
    public class RouteConfig
    {
        protected virtual void Application_Start()
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Vue", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
