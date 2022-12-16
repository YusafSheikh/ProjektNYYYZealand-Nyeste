using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.UndervisereHoldPage
{
    public class UnderviserHoldPageModel : PageModel
    {
        public IEnumerable<UndervisereHold> UnderviserHold { get; set; }
        IUndervisereHoldService UndervisereHoldService;
        public UnderviserHoldPageModel(IUndervisereHoldService service)
        {
            UndervisereHoldService = service;
        }

        [BindProperty(SupportsGet = true)]
        public int UndervisereHold { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Underviser { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Hold { get; set; }



        public void OnGet()
        {
            UnderviserHold = UndervisereHoldService.GetUndervisereHold();
        }
    }
}
