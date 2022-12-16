using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.UnderviserPage
{
    public class UpdateUnderviserModel : PageModel
    {
        public IEnumerable<Underviser> Undervisers { get; set; }

        IUnderviserService underviserService;

        [BindProperty]
        public Underviser underviser { get; set; }

        public UpdateUnderviserModel(IUnderviserService service)
        {
            underviserService = service;

        }

        public void OnGet(int id)
        {
            underviser = underviserService.GetUnderviserById(id);
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            underviserService.UpdateUnderviser(underviser);
            return RedirectToPage("GetUnderviser");

        }
    }
}