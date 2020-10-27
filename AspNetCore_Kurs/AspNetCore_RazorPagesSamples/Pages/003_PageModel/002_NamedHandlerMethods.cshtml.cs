using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore_RazorPagesSamples.Pages._003_PageModel
{
    public class _002_NamedHandlerMethodsModel : PageModel
    {
        public string Message { get; set; } = "Initial Request";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Message = "Form Posted";
        }

        public void OnPostDelete()
        {
            Message = "Delete handler fired";
        }
        public void OnPostEdit(int id)
        {
            Message = "Edit handler fired";
        }
        public void OnPostView(int id)
        {
            Message = "View handler fired";
        }

        public async Task<IActionResult> OnPostRegisterAsync()
        {
            //…
            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostRequestInfo()
        {
            //…
            return RedirectToPage();
        }


        [NonHandler] //Mit NoHandler blende ich die jeweilige OnPost Methode aus. 
        public void OnPostABCMachwas()
        {

        }
    }
}
