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
        public IEnumerable<Bog> B?ger { get; set; }

        IBogservice bogservice;
       public string Error { get; set; }
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
            try
            {
                bogservice.AddBog(bog);
            }
            catch
            {
                Error = "Bog_id findes, FORS?G IGEN ";
                return Page();
            }
            return RedirectToPage("GetB?ger");

        }
    }
}
    