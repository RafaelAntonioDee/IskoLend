using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModel
{
    public class Supply
    {
        required public string SupplyID { get; set; }
        required public string SupplyName { get; set; }
        required public string CategoryID { get; set; }
        required public int Quantity { get; set; }
    }
}
