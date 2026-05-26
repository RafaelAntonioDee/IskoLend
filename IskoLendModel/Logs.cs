using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModel       
{
    public class Logs
    {
        required public string LogID { get; set; }
        required public string SupplyID { get; set; }
        required public string FacilitatorID { get; set; }
        required public string Action { get; set; }
        required public int QuantityStatus { get; set; }
        required public DateTime ActionDate { get; set; }
    }
}
