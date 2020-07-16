using System.Web;
using System.Web.Mvc;

namespace _14_MVC_CONTROLLER_MODEL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
