using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Lab_3_MVC.Utils;
using Ninject.Web.Mvc;

namespace Lab_3_MVC
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            DependencyResolver.SetResolver(new NinjectDependencyResolver(new StandardKernel(new NinjectRegistrations())));
        }
    }
}
