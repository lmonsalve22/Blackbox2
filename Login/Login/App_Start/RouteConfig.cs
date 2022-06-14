using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Login
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                //data/underconstruction
                url: "{controller}/{action}/{id}",
                //url: "",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                defaults: new { controller = "Data", action = "Index", id = UrlParameter.Optional }
                //defaults: new { controller = "data", action = "underconstruction", id = UrlParameter.Optional }
            );
        }
    }
}
