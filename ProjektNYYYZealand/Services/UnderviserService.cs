using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjektNYYYZealand.Services
{
    public class UnderviserService : IUnderviserService
    {
        ZealandProjektContext context;

        public Underviser Underviser { get; set; }
        public UnderviserService(ZealandProjektContext services)
        {
            this.context = services;
        }
        public void AddUnderviser(Underviser Underviser)
        {
            context.Undervisers.Add(Underviser);
            context.SaveChanges();
        }
        public Underviser GetUnderviserById(int id)
        {
            return context.Undervisers.Find(id);
        }

        public void DeleteUnderviser(Underviser Underviser)
        {
            context.Undervisers.Remove(Underviser);
            context.SaveChanges();
        }

        public void DeleteUnderviser(int id)
        {
            Underviser underviser = GetUnderviserById(id);
            context.Undervisers.Remove(underviser);
            context.SaveChanges(true);
        }

        public IEnumerable<Underviser> GetUndervisers(string Filter)
        {
            {
                if (Filter == null)
                {
                    return context.Undervisers;
                }

                return context.Set<Underviser>().Where(s => s.Name.StartsWith(Filter));
            }

        }
       

        

        public void UpdateUnderviser(Underviser Underviser)
        {
            context.Undervisers.Update(Underviser);
            context.SaveChanges();
        }

        public IEnumerable<Underviser> GetUnderviser()
        {
            return context.Undervisers;
        }
    }
}
