using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModels
{
    public class BorrowingDetails
    {
        required public string BorrowingDetailID { get; set; }
        required public string SupplyID { get; set; }
        public string? ReturnDetailID { get; set; }
        required public int Quantity { get; set; }
        required public int ReturnedStatus { get; set; }

    }
}
