using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Services;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Pages.UnderviserPage
{
    public class GetUnderviserModel : PageModel
    {
       public IEnumerable<Underviser> Undervisers { get; set; }
        
        IUnderviserService service;
        public GetUnderviserModel(IUnderviserService services)
        {
            this.service = services;
        }

        [BindProperty(SupportsGet = true)]
        public int UnderviserId { get; set; }


        [BindProperty(SupportsGet = true)]
        public int MedarbejderNumber { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Email { get; set; }

        public void OnGet()
        {
            Undervisers = service.GetUndervisers(Name);
            //Undervisers = service.GetUnderviser();
            //Undervisers = service.GetUnderviser(UnderviserId, MedarbejderNumber, Name, Email);

        }
    }
}
