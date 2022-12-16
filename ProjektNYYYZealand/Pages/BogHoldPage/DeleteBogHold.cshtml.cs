using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;

namespace ProjektNYYYZealand.Pages.BogHoldPage
{
    public class DeleteBogHoldModel : PageModel
    {
        private IBogHoldService service;
        [BindProperty]
        public BogHold bogHold { get; set; }
        public DeleteBogHoldModel(IBogHoldService service)
        {
            this.service = service;
        }
        public IActionResult OnGet(int id)
        {
            bogHold = service.GetBogHoldById(id);
            return Page();

        }

        public IActionResult OnPost(int id)
        {
            this.service.DeleteBogHold(id);
            return RedirectToPage("BogHoldPage");
        }
    }
}