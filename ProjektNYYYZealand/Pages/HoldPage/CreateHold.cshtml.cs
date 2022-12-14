using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.HoldPage
{
    public class CreateHoldModel : PageModel
    {
        public IEnumerable<Hold> Holds { get; set; }

        IHoldService holdService;

        [BindProperty]
        public Hold hold { get; set; }

        public CreateHoldModel(IHoldService service)
        {
            holdService = service;
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            holdService.AddHold(hold);
            return RedirectToPage("GetHolds");

        }
    }
}
