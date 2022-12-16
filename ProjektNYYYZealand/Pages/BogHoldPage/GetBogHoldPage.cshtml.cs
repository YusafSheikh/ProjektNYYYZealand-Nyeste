using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Services;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.BogHoldPage
{
    public class GetBogHoldPageModel : PageModel
    {
        public IEnumerable<BogHold> BogHolds { get; set; }
        IBogHoldService bogHoldService;
        public GetBogHoldPageModel(IBogHoldService service)
        {
            bogHoldService = service;
        }

        [BindProperty(SupportsGet = true)]
        public int BogHoldId { get; set; }

        [BindProperty(SupportsGet = true)]
        public int BogId { get; set; }

        [BindProperty(SupportsGet = true)]
        public int HoldId { get; set; }



        public void OnGet()
        {
            //IEnumerable <BogHold> bogHolds = bogHoldService.GetBogHold();
            BogHolds = bogHoldService.GetBogHold();
        }
    }
}
