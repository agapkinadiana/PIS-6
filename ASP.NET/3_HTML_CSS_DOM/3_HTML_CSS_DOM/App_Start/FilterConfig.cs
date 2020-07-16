using System.Web;
using System.Web.Mvc;

namespace _3_HTML_CSS_DOM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
