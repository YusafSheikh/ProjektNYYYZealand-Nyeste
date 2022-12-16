using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.BogHoldPage
{
    public class UpdateBogHoldModel : PageModel
    {
        public IEnumerable<BogHold> BogHolds { get; set; }
        
        IBogHoldService service;

        [BindProperty]
        public BogHold bogHold { get; set; }

        public UpdateBogHoldModel(IBogHoldService service)
        {
            this.service = service;

        }
        public IActionResult OnGet(int id)
        {
            bogHold = this.service.GetBogHoldById(id);
            return Page();
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                this.service.UpdateBogHold(bogHold);
            }

            catch
            {
                return RedirectToPage("GetBogHoldPage");
            }


            return RedirectToPage("GetBogHoldPage");

        }
    }
}
