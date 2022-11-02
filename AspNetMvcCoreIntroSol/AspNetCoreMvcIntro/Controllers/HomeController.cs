using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreMvcIntro.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        //public ViewResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult GetPerson()

        //public JsonResult GetPerson()
        {
            var obj = new
            {
                name = "Samir",
                surname="Hemidov"
            };

            return Json(obj);
        }
    }
}

