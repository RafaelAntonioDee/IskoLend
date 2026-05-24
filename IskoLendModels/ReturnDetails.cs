using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModels
{
    public class ReturnDetails
    {
        required public string ReturnDetailID { get; set; }
        required public string FacilitatorID { get; set; }
        required public int ReturnQuantity { get; set; }
        required public DateTime ReturnedDate { get; set; }
    }
}
