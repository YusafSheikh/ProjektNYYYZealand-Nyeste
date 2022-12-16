using ProjektNYYYZealand.Models;
using ProjektNYYYZealand.Pages.UndervisereHoldPage;
using System.Collections.Generic;

namespace ProjektNYYYZealand.Interfaces
{
    public interface IUndervisereHoldService
    {
        public IEnumerable<UndervisereHold> GetUndervisereHold();

        void AddUnderviserHold(UndervisereHold undervisereHold);
        UndervisereHold GetUnderviserHoldById(int id);

        void DeleteUndervisereHold(UndervisereHold undervisereHold);

        void DeleteUndervisereHold(int id);

        void UpdateUndervisereHold(UndervisereHold undervisereHold);
        
    }
}
