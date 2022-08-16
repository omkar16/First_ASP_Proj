using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Tom";
            int age = 30;
            ViewBag.Name = name;
            ViewData["Age"] = age;
            TempData["Name"] = name;
            return View();
        }
        public IActionResult About() 
        {
            ViewBag.Name = TempData["Name"];
            return View();
        }
        public IActionResult Contact() 
        {
            return View();
        }
    }
}
