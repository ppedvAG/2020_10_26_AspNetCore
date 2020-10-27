using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCSamples.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowBasicGallery()
        {
            IList<string> Bilder = new List<string>();

            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\";

            Bilder = Directory.GetFiles(pfad);

            return View(Bilder);
        }

        public IActionResult ShowFormattedGallery()
        {
            IList<string> Bilder = new List<string>();

            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\";

            Bilder = Directory.GetFiles(pfad);

            return View(Bilder);
        }
    }
}
