using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HolaMundo.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> paises = new List<string> { "España", "Portugal", "Francia", "Italia", "Alemania", "Inglaterra" };
            return View(paises);
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
