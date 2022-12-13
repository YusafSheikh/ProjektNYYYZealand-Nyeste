using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;

namespace ProjektNYYYZealand.Pages.BogPage
{
    public class DeleteBogModel : PageModel
    {
        public DeleteBogModel(IBogservice service)
        {
            this.bogservice = service;
        }

        IBogservice bogservice;
        [BindProperty]
        public Bog bog { get; set; }
        public void OnGet(int id)
        {
            bog = bogservice.GetBogById(id);
        }

        public IActionResult OnPost(int id)
        {
            bogservice.DeleteBog(id);
            return RedirectToPage("GetBøger");
        }
    }
}