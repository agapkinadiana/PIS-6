using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_HTML_CSS_DOM.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ContentResult Index()
        {
            return Content(
                System.IO.File.ReadAllText(@"/Users/dianaagapkina/Desktop/ASP.NET/3_HTML_CSS_DOM/3_HTML_CSS_DOM/Views/index.html"),
                "text/html"
            );
        }
    }
}