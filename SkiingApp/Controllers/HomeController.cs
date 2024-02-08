using Microsoft.AspNetCore.Mvc;
// using SkiingApp.Models; // Include this only if you're using models within your controller
using System.Diagnostics;

namespace SkiingApp.Controllers
{
    public class HomeController : Controller // Rename the class as needed, commonly HomeController for the default controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }
    }
}


