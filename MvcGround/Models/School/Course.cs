using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models.School
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; } 
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Assignment> Assignments { get; set; }

        public Course()
        {
            Students = new List<Student>();
            Assignments = new List<Assignment>();
            Teachers = new List<Teacher>();
        }
    }
}