using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjektNYYYZealand.Services
{
    public class HoldService : IHoldService
    {
        ZealandProjektContext context;

        public HoldService(ZealandProjektContext context)
        {
            this.context = context;
        }

        public void AddHold(Hold Hold)
        {
            context.Holds.Add(Hold);
            context.SaveChanges();
        }

        public void DeleteHold(Hold Hold)
        {
            context.Holds.Remove(Hold);
            context.SaveChanges();
        }

        public void DeleteHold(int Id)
        {
            {
                Hold Hold = GetHoldById(Id);
                context.Holds.Remove(Hold);
                context.SaveChanges(true);
            }
        }

        public IEnumerable<Hold> GetHold(string Filter)
        {
            if (Filter != null)
            {
                return context.Holds;
            }
            return context.Set<Hold>().Where(h=>h.Holdnavn.StartsWith(Filter));
        }

        public IEnumerable<Hold> GetHold()
        {
            return context.Holds;
        }

        public IEnumerable<Hold> GetHold(string holdnavn, string semester, string uddannelse)
        {
            IEnumerable<Hold> result = context.Holds;
            if (holdnavn != null)
            {
                result = result.Where(r => r.Holdnavn.ToLower().StartsWith(holdnavn));
            }
            if (semester != null)
            {
                result = result.Where(r => r.Semester.ToLower().StartsWith(semester));
            }
            if (uddannelse != null)
            {
                result = result.Where(r => r.Uddannelse == uddannelse);
            }
            return result;
        }


        public Hold GetHoldById(int Id)
        {
            return context.Holds.Find(Id);
        }

        public void UpdateHold(Hold Hold)
        {
            context.Holds.Update(Hold);
            context.SaveChanges();
        }
    }
}
