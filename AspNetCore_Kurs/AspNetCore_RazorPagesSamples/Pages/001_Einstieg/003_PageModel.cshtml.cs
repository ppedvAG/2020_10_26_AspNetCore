using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore_RazorPagesSamples.Pages._001_Einstieg
{
    public class _003_PageModelModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public int abcdefg { get; set; }
        public void OnGet()
        {
        }


        public void OnPost() // Push auf Submit-Button, gelangt man in die OnPost Methode
        {
            if (Request.HasFormContentType) 
            {
                Name = Request.Form["name"]; // obselte, weil das Binding den Wert vom Formular in die Variable Name übertragt. Beide sind miteinander Verbunden. 
            }
        }
    }
}
