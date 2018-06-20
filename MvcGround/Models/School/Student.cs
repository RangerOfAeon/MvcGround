using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models.School
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
        public List<Assignment> Assignments { get; set; }

        public Student()
        {
            Assignments = new List<Assignment>();
            Courses = new List<Course>();
        }
    }

}