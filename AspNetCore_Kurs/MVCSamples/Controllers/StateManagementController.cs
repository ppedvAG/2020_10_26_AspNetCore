using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCSamples.Models;
using MVCSamples.ViewModel;


using System.Text.Json;


namespace MVCSamples.Controllers
{
    public class StateManagementController : Controller
    {
        ILogger _logger;
        public StateManagementController(Microsoft.Extensions.Logging.ILogger<StateManagementController> logger)
        {
            _logger = logger;

        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ViewDataSample()
        {
            //IDictionary<int, Movie> dict = new Dictionary<int, Movie>();
            //dict.Add(1, new Movie { Id = 1, IMDB_Bewertung = 10, Title = "abc" });


            ViewData["CoronaID"] = 123;
            ViewData["IrgendEinEintrag"] = "Das Wetter ist schön";
            ViewData.Add("ABC", 123);


            var value = ViewData["CoronaID"];
            return View();
        }


        public IActionResult ViewBagSample()
        {
            ViewBag.ABC = 1;
            ViewBag.EDF = "abc";
            ViewBag.EarthVM = new EarthLifeVM();

            return View();
        }


        public IActionResult TempDataFirst()
        {

            TempData["UserId"] = 777;
            //TempData.Keep();
            return View();
        }

        public IActionResult TempDataSecond()
        {

            //var userId = TempData["UserId"] ?? null;
            //TempData.Keep();
            return View();
        }

        public IActionResult TempDataThird()
        {
            //var userId = TempData["UserId"] ?? null;
            //TempData.Keep();
            return View();
        }
        public IActionResult TempDataFour()
        {

            var value = ViewData["CoronaID"];
            //var userId = TempData["UserId"] ?? null;
            //TempData.Keep();
            return View();
        }



        public IActionResult SessionInit()
        {
            HttpContext.Session.SetInt32("Age", 33);
            HttpContext.Session.SetString("Name", "Mustermann");

            Movie movie = new Movie()
            {
                Id = Guid.NewGuid(),
                Title = "Jurassic Park - Das verrückte DataView",
                Start = DateTime.Now,
            };

            string jsonString = JsonSerializer.Serialize(movie);

            HttpContext.Session.SetString("MovieObj", jsonString);

            return View();
        }
    }
}
