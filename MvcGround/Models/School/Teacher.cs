using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models.School
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Course> Courses { get; set; }
        //public Course Course { get; set; }

        public Teacher()
        {
            Courses = new List<Course>();
        }
    }
}