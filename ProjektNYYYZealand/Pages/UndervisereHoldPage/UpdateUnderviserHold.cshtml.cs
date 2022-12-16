using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Services;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.UndervisereHoldPage
{
    public class UpdateUnderviserHoldModel : PageModel
    {
        public IEnumerable<UndervisereHold> UndervisereHolds { get; set; }

        IUndervisereHoldService service;

        [BindProperty]
        public UndervisereHold undervisereHold { get; set; }

        public UpdateUnderviserHoldModel(IUndervisereHoldService service)
        {
            this.service = service;

        }
        public IActionResult OnGet(int id)
        {
            undervisereHold = this.service.GetUnderviserHoldById(id);
            return Page();
        }

        public IActionResult OnPost(UndervisereHold undervisereHold)
        {

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            //try
            //{
            //    this.service.UpdateUndervisereHold(undervisereHold);
            //}

            //catch
            //{
            //    return Page();
            //}
            if (!ModelState.IsValid)
            {
                return Page();
            }
            service.UpdateUndervisereHold(undervisereHold);
            return RedirectToPage("UnderviserHoldPage");


            //this.service.UpdateUndervisereHold(undervisereHold);
            //return RedirectToPage("UnderviserHoldPage");

        }
    }
}
