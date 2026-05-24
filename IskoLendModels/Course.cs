using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendModels
{
    public class Course
    {
        required public string CourseID { get; set; }
        required public string CourseName { get; set; }
        required public int Year { get; set; }
        required public int Section { get; set; }
    }
}
