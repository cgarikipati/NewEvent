using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewEvent.Services;

namespace NewEvent.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Test code
            //var mail = new MKitTest();
            //  mail.send();
            

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
