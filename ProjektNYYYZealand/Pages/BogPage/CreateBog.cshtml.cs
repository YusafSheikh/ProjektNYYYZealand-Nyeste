using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.BogPage
{
    public class CreateBogModel : PageModel
    {
        public IEnumerable<Bog> Bøger { get; set; }

        IBogservice bogservice;
       
        [BindProperty]
        public Bog bog { get; set; }

        public CreateBogModel(IBogservice service)
        {
            bogservice = service;
        
        }

        public IActionResult OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            bogservice.AddBog(bog);
            return RedirectToPage("GetBøger");

        }
    }
}
    