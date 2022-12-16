using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Services;

namespace ProjektNYYYZealand.Pages.UndervisereHoldPage
{
    public class DeleteUnderviserHoldModel : PageModel
    {
        private IUndervisereHoldService service;
        [BindProperty]
        public UndervisereHold undervisereHold { get; set; }
        public DeleteUnderviserHoldModel (IUndervisereHoldService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
        undervisereHold = service.GetUnderviserHoldById(id);
            return Page();
        
        }

        public IActionResult OnPost(int id)
        {
            this.service.DeleteUndervisereHold(id);
            return RedirectToPage("UnderviserHoldPage");
        }
    }
}