using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IskoLendModels;

namespace IskoLendDataManagement
{
    public class CourseDataService
    {
        List<Course> courses = new List<Course>();
        public CourseDataService()
        {
            Course course1 = new Course { CourseID = "BSIT1-1", CourseName = "Information Technology", Year = 1, Section = 1 };
            Course course2 = new Course { CourseID = "BSIT1-2", CourseName = "Information Technology", Year = 1, Section = 2 };
            Course course3 = new Course { CourseID = "BSIT2-1", CourseName = "Information Technology", Year = 2, Section = 1 };
            Course course4 = new Course { CourseID = "BSIT2-2", CourseName = "Information Technology", Year = 2, Section = 2 };
            Course course5 = new Course { CourseID = "BSIT3-1", CourseName = "Information Technology", Year = 3, Section = 1 };
            Course course6 = new Course { CourseID = "BSIT3-2", CourseName = "Information Technology", Year = 3, Section = 2 };
            Course course7 = new Course { CourseID = "BSIT4-1", CourseName = "Information Technology", Year = 4, Section = 1 };
            Course course8 = new Course { CourseID = "BSIT4-2", CourseName = "Information Technology", Year = 4, Section = 2 };
            Course course9 = new Course { CourseID = "BSCPE1-1", CourseName = "Computer Engineering", Year = 1, Section = 1 };
            Course course10 = new Course { CourseID = "BSCPE2-1", CourseName = "Computer Engineering", Year = 2, Section = 1 };
            Course course11 = new Course { CourseID = "BSCPE3-1", CourseName = "Computer Engineering", Year = 3, Section = 1 };
            Course course12 = new Course { CourseID = "BSCPE4-1", CourseName = "Computer Engineering", Year = 4, Section = 1 };
            Add(course1);
            Add(course2);
            Add(course3);
            Add(course4);
            Add(course5);
            Add(course6);
            Add(course7);
            Add(course8);
            Add(course9);
            Add(course10);
            Add(course11);
            Add(course12);

        }
        public void Add(Course course)
        {
            courses.Add(course);
        }
        public List<Course> GetCourses()
        {
            return courses;
        }
        public Course? GetCourseByID(string courseID)
        {
            return courses.FirstOrDefault(c => c.CourseID == courseID);
        }
        public List<Course> GetCoursesByYear(int year)
        {
            return courses.Where(c => c.Year == year).ToList();
        }
        public List<Course> GetCoursesBySection(int section)
        {
            return courses.Where(c => c.Section == section).ToList();
        }
    }
}
