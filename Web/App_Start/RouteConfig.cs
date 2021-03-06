﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace SourceCodeReader.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "SolutionApi",
                routeTemplate: "api/solution/{action}",
                defaults: new { controller = "Solution" }
            );

            routes.MapHttpRoute(
                name: "ProjectApi",
                routeTemplate: "api/project/{username}/{project}/{*path}",
                defaults: new { controller = "Project", path = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}