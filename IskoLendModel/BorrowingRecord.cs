using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModel
{
    public class BorrowingRecord
    {
         public string BorrowID { get; set; }
         public string StudentID { get; set; }
         public string FacilitatorID { get; set; }
         public DateTime BorrowedDate { get; set; }
         public string StatusID { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
