using ProjektNYYYZealand.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Interfaces
{
    public interface IBogservice
    {
        public IEnumerable<Bog> GetBogs(string Filter);
        public IEnumerable<Bog> GetBogs(string Filter, string FilterForfatter, double ISBNFilter);

        void AddBog(Bog bog);
        Bog GetBogById(int id);

        void DeleteBog(Bog bog);

        void DeleteBog(int id);

        void UpdateBog(Bog bog);    

    }
}
