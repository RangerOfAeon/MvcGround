using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public List<Students> CourseStudents { get; set; }
        public List<Teachers> CourseTeachers { get; set; }
        public List<Assignments> CourseAssignments { get; set; }
    }
}
