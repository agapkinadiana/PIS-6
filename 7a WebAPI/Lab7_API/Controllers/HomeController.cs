using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab7_API.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ContentResult Index()
        {
            return Content(
                System.IO.File.ReadAllText(@"/Users/dianaagapkina/Desktop/PIS-6/Lab7_API/Lab7_API/Views/main_page.html"),
                "text/html"
            );
        }
    }
}
