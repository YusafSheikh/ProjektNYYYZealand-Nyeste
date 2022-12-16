using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.UndervisereHoldPage
{
    public class CreateUnderviserHoldModel : PageModel
    {
        public IEnumerable<UndervisereHold> UndervisereHolds { get; set; }

        IUndervisereHoldService service;

            [BindProperty]
            public UndervisereHold undervisereHold { get; set; }

            public CreateUnderviserHoldModel(IUndervisereHoldService service)
            {
            this.service = service;

            }

            public IActionResult OnPost()
            {

                if (!ModelState.IsValid)
                {
                    return Page();
                }
                try
            {
                this.service.AddUnderviserHold(undervisereHold);
            }

            catch
            {
                return Page();
            }


                return RedirectToPage("UnderviserHoldPage");

            }
        }
    }
    