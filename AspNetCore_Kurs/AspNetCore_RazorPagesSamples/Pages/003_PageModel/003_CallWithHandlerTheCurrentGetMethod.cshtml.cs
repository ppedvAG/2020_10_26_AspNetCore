using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore_RazorPagesSamples.Pages._003_PageModel
{
    public class _003_CallWithHandlerTheCurrentGetMethodModel : PageModel
    {
        public int Ergebnis { get; set; }


        public void OnGet()
        {
        }

        public void OnGetHannes()
        {
            Ergebnis = 42;
        }


        public void OnPost() // Wenn Submit Button geklickt wurde-> Wird der Post-Block ausgeführt
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());
            Ergebnis = eins + zwei;
        }
    }
}
