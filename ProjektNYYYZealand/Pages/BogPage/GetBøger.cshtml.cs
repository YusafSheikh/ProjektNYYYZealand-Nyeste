using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.BogPage
{
    public class GetBøgerModel : PageModel
    {
        public IEnumerable<Bog> Bøger { get; set; }
        IBogservice bogservice;
        public GetBøgerModel(IBogservice service)
        {
            bogservice = service;
        }

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }

        [BindProperty(SupportsGet = true)]
        public int ISBN { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Forfatter { get; set; }



        public void OnGet()
        {
            Bøger = bogservice.GetBogs(Title, Forfatter, ISBN);
        }
    }
}
