using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModel
{
    public class ReturnDetail
    {
        required public string ReturnDetailID { get; set; }
        required public string R_BorrowID { get; set; }
        required public string R_SupplyID { get; set; }
        required public string R_FaciID { get; set; }
        required public int ReturnedQty { get; set; }
        required public DateTime ReturnDate { get; set; }
    }
}
