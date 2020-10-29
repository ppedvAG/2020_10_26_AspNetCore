using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataViewTempDataSample.Models;

namespace DataViewTempDataSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewData verliert seine Werte, wenn ich jetzt versuche den unter mir stehende Text z.b in Privacy ausgeben möchte
            ViewData["FunktioniertNurInIndex"] = "Ich kann nur in der IndexView oder in seiner Masterpage-> _Layout verwendet";


            TempData["FunktionierControllerWeit"] = "Ich kann nur einmal ausgelesen werden und danach löche ich meine Daten!";
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
