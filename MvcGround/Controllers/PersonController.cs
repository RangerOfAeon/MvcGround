using MvcGround.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGround.Controllers
{
    public class PersonController : Controller
    {
        public static int Start;
        //public model = new PeopleViewModel();
        //public model.People = new List<ViewModels>();

        // GET: Person
        //[HttpGet]
        public ActionResult ViewPeople(string searchTerm = null)
        {

            //var model = new PeopleViewModel();
            //model.People = new List<ViewModels>();

            //model.People.Add(new ViewModels { Name = "Isaac", PhoneNumber = "0723955431", City = "Skara" });
            //model.People.Add(new ViewModels { Name = "Thomas", PhoneNumber = "0721234567", City = "Skara" });
            //model.People.Add(new ViewModels { Name = "Elliot", PhoneNumber = "0729876543", City = "Skara" });
            //model.People.Add(new ViewModels { Name = "Linda", PhoneNumber = "0721239876", City = "Alingsås" });


            //where r => searchTerm == null || r.Name.StartsWithsearchTerm
            //select r;

            model.People
              .OrderBy(r => r.Name)
              .Where(r => searchTerm == null || (r.Name.Contains(searchTerm) || r.City.Contains(searchTerm)))
              .Select(r => r);

            Start++;
            if (Start == 1)
            {
                CurrentPeople.Add(new ViewModels { Name = "Isaac", PhoneNumber = "0723955431", City = "Skara" });
                CurrentPeople.Add(new ViewModels { Name = "Thomas", PhoneNumber = "0721234567", City = "Skara" });
                CurrentPeople.Add(new ViewModels { Name = "Elliot", PhoneNumber = "0729876543", City = "Skara" });
                CurrentPeople.Add(new ViewModels { Name = "Linda", PhoneNumber = "0721239876", City = "Alingsås" });
            }

            //}
            if (Request.IsAjaxRequest())
            {
                return PartialView("_PartialPerson", model);
            }

            return View(model);
        }
        public ActionResult Create()
        {

            return View();
        }
        public ActionResult Delete(string id)
        {
            //var model = new PeopleViewModel();
            //model.People = new List<ViewModels>();

            ViewModels match = CurrentPeople.Find(r => r.Name == id);
            if (match != null && CurrentPeople.Contains(match))
            {
                CurrentPeople.Remove(match);
            }
            return PartialView("_PartalPerson", CurrentPeople);
            //return View();
        }
        //public ActionResult Edit(string id)
        //{
        //    var model = 
        //}
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            //var model = new PeopleViewModel();
            //model.People = new List<ViewModels>();
            try
            {
                return PartialView("_PartialPerson");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost] 
        public ActionResult Create(ViewModels person)
        {
            //var model = new PeopleViewModel();
            //model.People = new List<ViewModels>();

            try
            {
                if (Request.IsAjaxRequest())
                {
                    if (ModelState.IsValid)
                    {
                        CurrentPeople.Add(new ViewModels { Name = person.Name, PhoneNumber = person.PhoneNumber, City = person.City });
                    }
                }
                return RedirectToAction("ViewPeople", CurrentPeople);
            }
            catch
            {
                return View();
            }
           
            
        }
        public PeopleViewModel model = new PeopleViewModel();
        public static List<ViewModels> CurrentPeople = new List<ViewModels>
        {
            new ViewModels { Name = "Isaac", PhoneNumber = "0723955431", City = "Skara" },
            new ViewModels { Name = "Thomas", PhoneNumber = "0721234567", City = "Skara" },
            new ViewModels { Name = "Elliot", PhoneNumber = "0729876543", City = "Skara" },
            new ViewModels { Name = "Linda", PhoneNumber = "0721239876", City = "Alingsås" },
        };
    }
}