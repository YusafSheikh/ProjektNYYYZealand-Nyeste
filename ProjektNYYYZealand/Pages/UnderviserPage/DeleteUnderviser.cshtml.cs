using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;

namespace ProjektNYYYZealand.Pages.UnderviserPage
{
    public class DeleteUnderviserModel : PageModel
    {
        public DeleteUnderviserModel(IUnderviserService service)
        {
            underviserService = service;
        }

        IUnderviserService underviserService;
        [BindProperty]
        public Underviser underviser { get; set; }
        public void OnGet(int id)
        {
            underviser = underviserService.GetUnderviserById(id);
        }

        public IActionResult OnPost(int id)
        {
            underviserService.DeleteUnderviser(id);
            return RedirectToPage("GetUnderviser");
        }
    }
}