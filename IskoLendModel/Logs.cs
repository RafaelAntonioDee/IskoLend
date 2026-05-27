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
        required public string ActionType { get; set; }
        required public string ActionID { get; set; }
        required public int  InitialQty { get; set; }
        required public int  FinalQty{ get; set; }
        required public DateTime LogDate { get; set; }
    }
}
