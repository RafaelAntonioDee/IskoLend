using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IskoLendModels;

namespace IskoLendDataManagement
{
    public class StatusDataService
    {
            List<Status> statuses = new List<Status>();
        public StatusDataService()
        {
            Status status1 = new Status { StatusID = 0, StatusName = "None" };
            Status status2 = new Status { StatusID = 1, StatusName = "Incomplete" };
            Status status3 = new Status { StatusID = 2, StatusName = "Completed" };
            Status status4 = new Status { StatusID = 3, StatusName = "Lost" };
            Add(status1);
            Add(status2);
            Add(status3);
            Add(status4);
        }
        public void Add(Status status)
        {
            statuses.Add(status);
        }

    }
}
