using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.HoldPage
{
    public class UpdateHoldModel : PageModel
    {
        public IEnumerable<Hold> Holds { get; set; }

        IHoldService holdService;

        [BindProperty]
        public Hold hold { get; set; }

        public UpdateHoldModel(IHoldService service)
        {
            holdService = service;

        }

        public void OnGet(int id)
        {
            hold = holdService.GetHoldById(id);
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            holdService.UpdateHold(hold);
            return RedirectToPage("GetHold");

        }
    }
}