using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;

namespace ProjektNYYYZealand.Pages.HoldPage
{
    public class DeleteHoldModel : PageModel
    {
        public DeleteHoldModel(IHoldService service)
        {
            this.holdservice = service;
        }

        IHoldService holdservice;
        [BindProperty]
        public Hold hold { get; set; }
        public void OnGet(int id)
        {
            hold = holdservice.GetHoldById(id);
        }

        public IActionResult OnPost(int id)
        {
            holdservice.DeleteHold(id);
            return RedirectToPage("GetHold");
        }
    }
}