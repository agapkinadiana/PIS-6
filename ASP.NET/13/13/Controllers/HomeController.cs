using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Application.Controllers
{
    //[RoutePrefix("home")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("{id:int}/{name}")]
        public string Test(int id, string name)
        {
            return id.ToString() + ". " + name;
        }

        [Route("~/test/twit/{id:int}")]
        public string Twit(int id)
        {
            return id.ToString();
        }
    }
}
