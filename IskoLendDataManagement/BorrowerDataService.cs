using System;
using IskoLendModels;
using System.Linq;

namespace IskoLendDataManagement
{
    public class BorrowerDataService
    {
        List<Borrower> borrowers = new List<Borrower>();
       
        

        // Constructor to initialize sample data
        public BorrowerDataService()
        {
            Borrower borrower1 = new Borrower { BorrowerID = "2023-02199-BN-0", FirstName = "John", LastName = "Doe", CourseID = "BSIT3-1" };
            Borrower borrower2 = new Borrower { BorrowerID = "2025-02399-BN-0", FirstName = "Bom", LastName = "Boom", CourseID = "BSCPE1-1" };
            Borrower borrower3 = new Borrower { BorrowerID = "2024-00059-BN-0", FirstName = "John Ruell", LastName = "San Lorenzo", CourseID = "BSIT2-2" };

            Add(borrower1);
            Add(borrower2);
            Add(borrower3);
        }
        public void Add(Borrower borrower)
        {
            borrowers.Add(borrower);
        }

        public List<Borrower> GetBorrowers()
        {
            return borrowers;
        }
        
        public List<Borrower> GetBorrowersByCourse(string courseID)
        {
            return borrowers.Where(b => b.CourseID == courseID).ToList();
        }
        public Borrower? GetBorrowerByID(string borrowerID)
        {
                       return borrowers.FirstOrDefault(b => b.BorrowerID == borrowerID);
        }
        public List<Borrower> GetBorrowersByLastName(string lastName)
        {
            return borrowers.Where(b => b.LastName == lastName).ToList();
        }
        public List<Borrower> GetBorrowersByFirstName(string firstName)
        {
            return borrowers.Where(b => b.FirstName == firstName).ToList();
        }
    }
}
