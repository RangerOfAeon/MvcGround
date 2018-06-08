using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb
{
    public class Assignments
    {
        public int Id { get; set; }
        public string AssignmentName { get; set; }
        public Courses Courses { get; set; }
        public Students Students { get; set; }

    }
}
