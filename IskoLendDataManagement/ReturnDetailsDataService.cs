using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IskoLendModels;

namespace IskoLendDataManagement
{
    public class ReturnDetailsDataService
    {
        List<ReturnDetails> returnDetails = new List<ReturnDetails>();
        public ReturnDetailsDataService()
        {
            ReturnDetails returnDetail1 = new ReturnDetails { ReturnDetailID = "R0001", FacilitatorID = "F001", ReturnQuantity = 20, ReturnedDate = DateTime.Now };
        }
        public void Add(ReturnDetails returnDetail)
        {
            returnDetails.Add(returnDetail);
        }
    }
}
