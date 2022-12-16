using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.UnderviserPage
{
    public class CreateUnderviserModel : PageModel
    {
        public IEnumerable<Underviser> Undervisers { get; set; }

        IUnderviserService underviserService;

        [BindProperty]
        public Underviser underviser { get; set; }

        public CreateUnderviserModel(IUnderviserService service)
        {
            underviserService = service;
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            underviserService.AddUnderviser(underviser);
            return RedirectToPage("GetUnderviser");

        }
    }
}
