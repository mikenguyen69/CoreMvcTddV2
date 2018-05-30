using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMvcTDD.Web.Models;

namespace CoreMvcTDD.Web.Controllers
{
    public class HomeController : Controller
    {               
        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is my application page";

            return View();
        }
    }
}