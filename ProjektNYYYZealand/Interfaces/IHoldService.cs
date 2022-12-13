using ProjektNYYYZealand.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Interfaces
{
    public interface IHoldService
    {
        public IEnumerable<Hold> GetHold(string Filter);

        public IEnumerable<Hold> GetHold();

        void AddHold(Hold Hold);

        void DeleteHold (Hold Hold);

        void DeleteHold(int Id);

        void UpdateHold(Hold Hold);

        public Hold GetHoldById (int Id);
        IEnumerable<Hold> GetHold(string holdnavn, string semester, string uddannelse);
    }
}
