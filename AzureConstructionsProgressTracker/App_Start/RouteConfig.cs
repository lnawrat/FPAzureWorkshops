﻿using System.Web.Mvc;
using System.Web.Routing;

namespace AzureConstructionsProgressTracker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ConstructionProjects", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
