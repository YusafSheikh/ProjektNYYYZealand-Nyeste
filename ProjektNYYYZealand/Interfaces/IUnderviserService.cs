using ProjektNYYYZealand.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Interfaces
{
    public interface IUnderviserService
    {
        public IEnumerable<Underviser> GetUndervisers(string Filter);

        public IEnumerable<Underviser> GetUnderviser();

        void AddUnderviser(Underviser Underviser);

        void DeleteUnderviser(Underviser Underviser);

        void DeleteUnderviser(int id);

        void UpdateUnderviser(Underviser Underviser);

        public Underviser GetUnderviserById(int id);
    }
}
