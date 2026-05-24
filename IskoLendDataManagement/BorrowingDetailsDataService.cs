using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IskoLendModels;

namespace IskoLendDataManagement
{
    public class BorrowingDetailsDataService
    {
        List<BorrowingDetails> borrowingDetails = new List<BorrowingDetails>();
        public BorrowingDetailsDataService()
        {
            //BorrowingDetailID = FK from BorrowingRecord, SupplyID = FK from Supply, ReturnDetailID = FK from ReturnDetails
            BorrowingDetails borrowingDetail1 = new BorrowingDetails { BorrowingDetailID = "B0001", SupplyID = "S001", ReturnDetailID = null, Quantity = 5, ReturnedStatus = 1 };
            Add(borrowingDetail1);


        }
        public void Add(BorrowingDetails borrowingDetail)
        {
            borrowingDetails.Add(borrowingDetail);
        }
        public List<BorrowingDetails> GetBorrowingDetails()
        {
            return borrowingDetails;
        }
        public BorrowingDetails? GetBorrowingDetailsByID(string borrowingDetailID)
        {
            return borrowingDetails.FirstOrDefault(bd => bd.BorrowingDetailID == borrowingDetailID);
        }
        public List<BorrowingDetails> GetBorrowingDetailsBySupplyID(string supplyID)
        {
            return borrowingDetails.Where(bd => bd.SupplyID == supplyID).ToList();
        }
        public List<BorrowingDetails> GetBorrowingDetailsByReturnDetailID(string returnDetailID)
        {
            return borrowingDetails.Where(bd => bd.ReturnDetailID == returnDetailID).ToList();
        }
        public List<BorrowingDetails> GetBorrowingDetailsByReturnedStatus(int returnedStatus)
        {
            return borrowingDetails.Where(bd => bd.ReturnedStatus == returnedStatus).ToList();
        }
    }
}
