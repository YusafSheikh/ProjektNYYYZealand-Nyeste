using ProjektNYYYZealand.Interfaces;
using ProjektNYYYZealand.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjektNYYYZealand.Services
{
    public class Bogservice : IBogservice
    {
        ZealandProjektContext context;

        public Bogservice(ZealandProjektContext service)
        {
            context = service;
        }

        public IEnumerable<Bog> GetBogs(string Filter)
        {
            if (Filter == null)
            {
                return context.Bøger;
            }
            return context.Set<Bog>().Where(b => b.Title.ToLower().StartsWith(Filter));
        }

        public IEnumerable<Bog> GetBogs()
        {
            return context.Bøger;
        }

        public void AddBog(Bog bog)
        {
            context.Bøger.Add(bog);
            context.SaveChanges();
        }

        public Bog GetBogById (int id)
        {
            return context.Bøger.Find(id);
        }
        public void DeleteBog (int id)        
            {
            Bog Bog = GetBogById(id);
            context.Bøger.Remove(Bog);
            context.SaveChanges(true);
            } 
        public void DeleteBog(Bog bog)
        {
            context.Bøger.Remove(bog);
            context.SaveChanges(true);
        }
        public IEnumerable<Bog> GetBogs(string Filter, string FilterForfatter, double ISBNFilter)
        {
            IEnumerable<Bog> result = context.Bøger;
            if (Filter != null)
            {
                result = result.Where(r => r.Title.ToLower().StartsWith(Filter));
            }
            if (FilterForfatter != null)
            {
                result = result.Where(r => r.Forfatter.ToLower().StartsWith(FilterForfatter));
            }
            if (ISBNFilter != 0)
            {
                result = result.Where(r => r.Isbn == ISBNFilter);
            }
            return result;
        }


        public void UpdateBog(Bog bog)
        {
            context.Bøger.Update(bog);
            context.SaveChanges();
        }

     
    }
    }