using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IskoLendModels;

namespace IskoLendDataManagement
{
    public class DesignationDataService
    {
        List<Designation> designations = new List<Designation>();
        public DesignationDataService() { 
            Designation designation1 = new Designation { DesignationID = "D001", DesignationName = "President" };
            Designation designation2 = new Designation { DesignationID = "D002", DesignationName = "Vice President" };
            Designation designation3 = new Designation { DesignationID = "D003", DesignationName = "Staff Manager" };
            Designation designation4 = new Designation { DesignationID = "D004", DesignationName = "Staff" };
        }
    }
}
