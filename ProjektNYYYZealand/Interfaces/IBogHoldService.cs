using ProjektNYYYZealand.Models;
using System.Collections;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Interfaces
{
    public interface IBogHoldService
    {
        public IEnumerable<BogHold> GetBogHold();

        void AddBogHold(BogHold bogHold);
        BogHold GetBogHoldById(int id);

        void DeleteBogHold(BogHold bogHold);

        void DeleteBogHold(int id);

        void UpdateBogHold(BogHold bogHold);

    }
}
