using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModels
{
    public class Facilitator
    {
        required public string FacilitatorID { get; set; }
        required public string FirstName { get; set; }
        required public string LastName { get; set; }
        required public string DesignationID { get; set; }
        public bool IsActive { get; set; }
    }
}
