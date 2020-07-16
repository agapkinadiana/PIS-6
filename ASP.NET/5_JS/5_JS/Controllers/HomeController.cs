using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_JS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ContentResult Index()
        {
            return Content(
                System.IO.File.ReadAllText(@"/Users/dianaagapkina/Desktop/ASP.NET/5_JS/5_JS/Views/index.html"),
                "text/html"
            );
        }
    }
}