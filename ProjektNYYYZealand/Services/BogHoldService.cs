using Microsoft.EntityFrameworkCore;
using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;
using ProjektNYYYZealand.Interfaces;

namespace ProjektNYYYZealand.Services
{
    public class BogHoldService : IBogHoldService
    {
        ZealandProjektContext context;

        public BogHoldService (ZealandProjektContext service)
        {
            context = service;
        }

        public IEnumerable<BogHold> GetBogHold()
        {
            var boghold = context.BogHolds
                .Include(bh => bh.Bog)
                .Include(bh => bh.Hold)
                .AsNoTracking();
            return boghold;

        }

        public void AddBogHold(BogHold bogHold)
        {
            context.BogHolds.Add(bogHold);
            context.SaveChanges();
        }

        public void DeleteBogHold(BogHold bogHold)
        {
            context.BogHolds.Remove(bogHold);
            context.SaveChanges(true);
        }

        public void DeleteBogHold(int id)
        {
            BogHold bogHold = GetBogHoldById(id);
            context.BogHolds.Remove(bogHold);
            context.SaveChanges(true);
        }

        public BogHold GetBogHoldById(int id)
        {
            return context.BogHolds.Find(id);
        }

        public void UpdateBogHold(BogHold bogHold)
        {
            context.BogHolds.Update(bogHold);
            context.SaveChanges();
        }
    }
}
