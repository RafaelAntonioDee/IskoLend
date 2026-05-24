using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModels
{
    public class BorrowingRecord
    {
        required public string BorrowID { get; set; }
        required public string StudentID { get; set; }
        required public string FacilitatorID { get; set; }
        required public DateTime BorrowedDate { get; set; }
        required public int StatusID { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
