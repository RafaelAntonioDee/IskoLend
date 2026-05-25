using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModel
{
    public class BorrowingDetails
    {
        required public string BorrowingDetailID { get; set; }
        required public string SupplyID { get; set; }
        required public int Quantity { get; set; }
        required public string ReturnedStatus { get; set; }

    }
}
