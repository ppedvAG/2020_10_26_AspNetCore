using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore_RazorPagesSamples.Pages._003_PageModel
{
    public class _001_HandlerMethodsInRazorPagesModel : PageModel
    {
        public string Message { get; set; }

        //Formular wird aufbereitet und wird fertig gerendert an den browser gesendet
        public void OnGet()
        {
            Message = "Get used";
        }

        //Bei Formularen z.b wird das fertig ausgefüllte Formular vom Broser zurück an den Server gesendet
        public void OnPost() //wird aufgerufen, wenn die Seite nur ein Button hat. Bei mehrere Buttons, wäre das der Button mit dem type "submit"
        {
            Message = "Post used";
        }
    }
}
