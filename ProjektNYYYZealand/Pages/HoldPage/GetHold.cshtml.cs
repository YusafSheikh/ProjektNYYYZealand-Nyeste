using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Services;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.HoldPage
{
    public class GetHoldsModel : PageModel
    {
        public IEnumerable<Hold> Holds { get; set; }
        IHoldService holdService;

        public GetHoldsModel(IHoldService service)
        {
            holdService = service;
        }

        [BindProperty(SupportsGet = true)]
        public string Holdnavn { get; set; }


        [BindProperty(SupportsGet = true)]
        public string Semester { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Uddannelse { get; set; }

        public void OnGet()

        {

            Holds = holdService.GetHold(Holdnavn, Semester, Uddannelse);

        }

    }
}
