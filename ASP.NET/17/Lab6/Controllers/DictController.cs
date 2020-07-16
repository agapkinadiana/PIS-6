using DLLJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3_MVC.Controllers
{
    public class DictController : Controller
    {
        private Interface1 interface1 = null;

        public DictController(Interface1 interface1)//иньекция
        {
            this.interface1 = interface1;
            // request -> .net prinimaet ego -> создает экземпляр контроллера new DictController(repository) -> вызываем нужный метод .Index()
        }
      
        public ActionResult M01()
        {
            int r1 = interface1.add(5, 10);
            int r2 = interface1.sub(15, 10);
            return Content($"<h1>Add - r1 = {r1}, Sub - r2 = {r2}</h1>");
        }


    }
}