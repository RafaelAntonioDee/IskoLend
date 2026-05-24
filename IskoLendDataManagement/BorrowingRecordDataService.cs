using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IskoLendModels;

namespace IskoLendDataManagement
{
    public class BorrowingRecordDataService
    {
        List<BorrowingRecord> borrowingRecords = new List<BorrowingRecord>();
        public BorrowingRecordDataService()
        {
            BorrowingRecord borrowingRecord1 = new BorrowingRecord { BorrowID = "B0001", StudentID = "2023-02199-BN-0", FacilitatorID = "S001", BorrowedDate = DateTime.Now, StatusID = 1, DateCompleted = null };

            Add(borrowingRecord1);
        }
        public void Add(BorrowingRecord borrowingRecord)
        {
            borrowingRecords.Add(borrowingRecord);
        }
        public List<BorrowingRecord> GetBorrowingRecords()
        {
            return borrowingRecords;
        }
        public BorrowingRecord? GetBorrowingRecordByID(string borrowID)
        {
            return borrowingRecords.FirstOrDefault(br => br.BorrowID == borrowID);
        }
        public List<BorrowingRecord> GetBorrowingRecordsByStudentID(string studentID)
        {
            return borrowingRecords.Where(br => br.StudentID == studentID).ToList();
        }
         public List<BorrowingRecord> GetBorrowingRecordsByFacilitatorID(string facilitatorID)
        {
            return borrowingRecords.Where(br => br.FacilitatorID == facilitatorID).ToList();
        }
        public List<BorrowingRecord> GetBorrowingRecordsByStatusID(int statusID)
        {
            return borrowingRecords.Where(br => br.StatusID == statusID).ToList();
        }
    }
}
