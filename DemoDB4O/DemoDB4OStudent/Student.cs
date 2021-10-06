using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDB4OStudent
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RegisterYear { get; set; }
        public DateTime DOB { get; set; }
        public int YearOld => DateTime.Now.Year - DOB.Year;

        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
    }

}
