﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCSamples.Models;

namespace MVCSamples.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {

            string Name = HttpContext.Session.GetString("Name");
            int? Alter = HttpContext.Session.GetInt32("Age");

            string jsonString = HttpContext.Session.GetString("MovieObj");
            Movie movie = JsonSerializer.Deserialize<Movie>(jsonString);

            return View();
        }

        public IActionResult Test()
        {
            Person person = new Person();
            
            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


    public class Person
    {
        public Person()
        {

        }
        public string Name { get; set; } = "Snoopy";
    }
}
