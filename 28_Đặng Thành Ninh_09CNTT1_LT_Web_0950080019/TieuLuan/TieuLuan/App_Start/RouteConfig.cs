using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TieuLuan
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "SinhVien", action = "Index"}
            );
            routes.MapRoute(
                name: "",
                url: "{controller}/{action}",
                defaults: new { controller = "SinhVien", action = "Index" }
            );
        }
    }
}
