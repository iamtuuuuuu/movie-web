using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Movie_Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TuHome", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "TuDetailFilm",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "TuDetailFilm", action = "Detail", name = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Watch",
                url: "{controller}/{action}/{idFilm}/{Episode}",
                defaults: new { controller = "Watch", action = "Watch", idFilm = UrlParameter.Optional, Episode = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Loc",
                url: "{controller}/{action}/{slug}",
                defaults: new { controller = "Loc", action = "Index", slug = UrlParameter.Optional }
            );
        }
    }
}
