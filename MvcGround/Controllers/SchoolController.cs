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
            
            var model = db.Courses.Include("Students")
                                    .Include("Teachers")
                                    .Include("Assignments").ToList();

            ModelState.Clear();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Course NewCourse)
        {
            if(ModelState.IsValid)
            {
                db.Courses.Add(NewCourse);
                db.SaveChanges();
                return RedirectToAction("School", new { Id = NewCourse.Id });
            }
            return View(NewCourse);
        }

        public ActionResult CreateAssignment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAssignment(Assignment NewAssignment)
        {
            List<Course> WhichCourse = new List<Course>();
            if (ModelState.IsValid)
            {
                db.Assignments.Add(NewAssignment);

                //Course match = WhichCourse(r => r.Name == id);
                //if (match != null && CurrentPeople.Contains(match))
                    db.SaveChanges();
                return RedirectToAction("School", new { Id = NewAssignment.Id });
            }
            return View(NewAssignment);
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