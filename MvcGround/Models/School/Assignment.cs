using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models.School
{
    public class Assignment
    {
        public int Id { get; set; }
        public string AssignmentName { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        //public Course Course { get; set; }

        public Assignment()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
    }
}