using System.Web.Mvc;
using System.Web.Routing;
using System.Text.RegularExpressions;

namespace Application
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Default2",
            //    url: "{id}/{name}",
            //    defaults: new { controller = "Home", action = "Test" },
            //    constraints: new { id = @"\d+" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
