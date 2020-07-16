using System.Web.Mvc;
using System.Web.Routing;

namespace Application
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "M01",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MResearch", action = "M01", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "M02",
                url: "V2/{controller}/{action}",
                defaults: new { controller = "MResearch", action = "M02" }
            );

            routes.MapRoute(
                name: "M03",
                url: "V3/{controller}/{X}/{action}",
                defaults: new { controller = "MResearch", action = "M03", X = UrlParameter.Optional },
                constraints: new { X = "^X$|^$" }
            );
        }
    }
}
