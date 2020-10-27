using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCSamples.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult ShowBlogs(int Day, int Month, int Year)
        {
            return View();
        }
    }
}
