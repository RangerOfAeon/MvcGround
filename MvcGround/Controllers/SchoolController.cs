using MvcGround.Models.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGround.Controllers
{
    public class SchoolController : Controller
    {
        SchoolContext db = new SchoolContext();

        // GET: School
        public ActionResult School()
        {
            return View(db.Students.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if(db != null) 
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}