using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IskoLendModels;

namespace IskoLendDataManagement
{
    public class FacilitatorDataService
    {
        List<Facilitator> facilitators = new List<Facilitator>();
        public FacilitatorDataService()
        {
            Facilitator facilitator1 = new Facilitator { FacilitatorID = "F001", FirstName = "Ryza Faye", LastName = "Reyes", DesignationID = "D001" , IsActive = true };
            Facilitator facilitator2 = new Facilitator { FacilitatorID = "F002", FirstName = "Maui", LastName = "Wowie", DesignationID = "D002", IsActive = true };
            Facilitator facilitator3 = new Facilitator { FacilitatorID = "F003", FirstName = "Mambo", LastName = "Bambo", DesignationID = "D003",IsActive = true };

            Add(facilitator1);
            Add(facilitator2);
            Add(facilitator3);
        }
        public void Add(Facilitator facilitator)
        {
            facilitators.Add(facilitator);
        }
        public List<Facilitator> GetFacilitators()
        {
            return facilitators;
        }
        public List<Facilitator> GetActiveFacilitators()
        {
            return facilitators.Where(f => f.IsActive).ToList();
        }
        public List<Facilitator> GetFacilitatorsbyFacilitatorID(string facilitatorID)
        {
            return facilitators.Where(f => f.FacilitatorID == facilitatorID).ToList();
        }
    }
}
