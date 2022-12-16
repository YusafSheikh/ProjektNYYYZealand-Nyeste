using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.BogPage
{
    public class UpdateBogModel : PageModel
    {
        public IEnumerable<Bog> Bøger { get; set; }

        IBogservice bogservice;

        [BindProperty]
        public Bog bog { get; set; }

        public UpdateBogModel(IBogservice service)
        {
            bogservice = service;

        }

        public void OnGet(int id)
        {
            bog = bogservice.GetBogById(id);
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            bogservice.UpdateBog(bog);
            return RedirectToPage("GetBøger");

        }
    }
}