using Microsoft.EntityFrameworkCore;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Pages.UndervisereHoldPage;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Services
{
    public class UndervisereHoldService : IUndervisereHoldService
    {
        ZealandProjektContext context;

        public UndervisereHoldService(ZealandProjektContext service)
        {
            context = service;
        }

        public IEnumerable<UndervisereHold> GetUndervisereHold()
        {
            var underviserhold = context.UndervisereHolds
                .Include(uh => uh.Underviser)
                .Include(uh => uh.Hold)
                .AsNoTracking();
                return underviserhold;

        }


        public void AddUnderviserHold(UndervisereHold undervisereHold)
        {
            context.UndervisereHolds.Add(undervisereHold);
            context.SaveChanges();
        }

        public void DeleteUndervisereHold(UndervisereHold undervisereHold)
        {
            context.UndervisereHolds.Remove(undervisereHold);
            context.SaveChanges(true);
        }

        public void DeleteUndervisereHold(int id)
        {
            UndervisereHold undervisereHold1 = GetUnderviserHoldById(id);
            context.UndervisereHolds.Remove(undervisereHold1);
            context.SaveChanges(true);
        }

        


        public UndervisereHold GetUnderviserHoldById(int id)
        {
            return context.UndervisereHolds.Find(id);
        }

        public void UpdateUndervisereHold(UndervisereHold undervisereHold)
        {
             
            context.UndervisereHolds.Update(undervisereHold);
            context.SaveChanges();
        }
    }
}
