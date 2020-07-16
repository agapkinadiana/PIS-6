using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _22_Core_MVC_RouterAtrib.Models;

namespace _22_Core_MVC_RouterAtrib.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Exam")]
        [Route("Home/Exam")]
        public IActionResult Exam()
        {
            return View();
        }
    }
}
