﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcGround
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "FeverCheck",
                url: "FeverCheck/",
                defaults: new { controller = "Home", action = "FeverCheck" }
            );
            routes.MapRoute(
               name: "GuessingGame",
               url: "GuessingGame/",
               defaults: new { controller = "Home", action = "GuessingGame" }
           );
            routes.MapRoute(
               name: "ViewPeople",
               url: "ViewPeople/",
               defaults: new { controller = "Home", action = "ViewPeople" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
