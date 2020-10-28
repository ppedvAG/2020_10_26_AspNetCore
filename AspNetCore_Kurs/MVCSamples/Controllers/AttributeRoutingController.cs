using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCSamples.Controllers
{
    public class AttributeRoutingController : Controller
    {
        [Route("Kevin/Index2")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("Kevin/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
