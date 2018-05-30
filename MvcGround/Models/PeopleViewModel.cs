using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcGround.Models
{
    public class PeopleViewModel
    {
        public IEnumerable<ViewModels> People { get; set; }
        public ViewModels Person { get; set; }
    }
}