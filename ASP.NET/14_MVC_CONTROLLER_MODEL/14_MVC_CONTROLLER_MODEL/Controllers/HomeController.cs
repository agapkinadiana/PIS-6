using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _14_MVC_CONTROLLER_MODEL.Models;

namespace _14_MVC_CONTROLLER_MODEL.Controllers
{
    public class HomeController : Controller
    {
        private PersonRepository PersonModel { get; set; } = new PersonRepository();


        public ActionResult Index()
        {
            return View(viewName: "Index", model: PersonModel);
        }

        public ActionResult Add()
        {
            return View(viewName: "Add", model: new Person());
        }

        [HttpPost]
        public ActionResult AddSave(string lastName, string phone)
        {
            return View(viewName: "Add", model: PersonModel.InsertOne(new Person { LastName = lastName, Phone = phone }));
        }
    }
}