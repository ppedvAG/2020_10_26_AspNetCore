using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MVCSamples.Models;
using MVCSamples.ViewModel;

namespace MVCSamples.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StronglyTypedPartials ()
        {
            IList<Animal> animals = new List<Animal>();
            animals.Add(new Animal { Name = "Hund" });
            animals.Add(new Animal { Name = "Katze" });
            animals.Add(new Animal { Name = "Maus" });

            return View(animals);
        }

        public IActionResult StronglyTypedPartials2()
        {
            EarthLifeVM earthVM = new EarthLifeVM();

            earthVM.AlleTiere.Add(new Animal { Name = "Katze" });
            earthVM.AlleTiere.Add(new Animal { Name = "Maus" });
            earthVM.AlleTiere.Add(new Animal { Name = "Tiger" });


            earthVM.AllHumans.Add(new Humans { Name = "Mustermann", Birthday = DateTime.Now });
            earthVM.AllHumans.Add(new Humans { Name = "Musterfrau", Birthday = DateTime.Now });
            earthVM.AllHumans.Add(new Humans { Name = "Dagobert Duck", Birthday = DateTime.Now });

            earthVM.TheEarth = new TheEarth{ StufeDerErdverschmutzung = 98};

            return View(earthVM);
        }

        public IActionResult PartialWithAjax()
        {

            return View();
        }

        public PartialViewResult OnGetAnimalPartial()
        {
            IList<Animal> animals = new List<Animal>();
            animals.Add(new Animal { Name = "Hund" });
            animals.Add(new Animal { Name = "Katze" });
            animals.Add(new Animal { Name = "Maus" });

            return new PartialViewResult
            {
                ViewName = "_AnimalPartialView",
                ViewData = new ViewDataDictionary<List<Animal>>(ViewData, animals)
            };
        }
    }
}
