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

        // GET: Person
        [HttpGet]
        public ActionResult ViewPeople(string searchTerm = null)
        {
            var model =
                 PeopleViewModel.People

                .OrderBy(r => r.Name)
                .Where(r => searchTerm == null || (r.Name.Contains(searchTerm) || r.City.Contains(searchTerm)))
                .Take(10)
                .Select(r => r);
                //where r => searchTerm == null || r.Name.StartsWithsearchTerm
                //select r;



            Start++;
            if (Start == 1)
            {
                PeopleViewModel.People.Add(new ViewModels { Name = "Isaac", PhoneNumber = "0723955431", City = "Skara" });
                PeopleViewModel.People.Add(new ViewModels { Name = "Thomas", PhoneNumber = "0721234567", City = "Skara" });
                PeopleViewModel.People.Add(new ViewModels { Name = "Elliot", PhoneNumber = "0729876543", City = "Skara" });
                PeopleViewModel.People.Add(new ViewModels { Name = "Linda", PhoneNumber = "0721239876", City = "Alingsås" });

            }
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost] 
        public ActionResult Create(string name, string phoneNumber, string city)
        {
            PeopleViewModel.People.Add(new ViewModels { Name = name, PhoneNumber = phoneNumber, City = city });
            return RedirectToAction("ViewPeople");
        }
       
    }
}