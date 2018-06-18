﻿using MvcGround.Models;
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
        //[HttpGet]
        public ActionResult ViewPeople(string searchTerm = null)
        {

            var model = new PeopleViewModel();
            model.People = new List<ViewModels>();

            //model.People.Add(new ViewModels { Name = "Isaac", PhoneNumber = "0723955431", City = "Skara" });
            //model.People.Add(new ViewModels { Name = "Thomas", PhoneNumber = "0721234567", City = "Skara" });
            //model.People.Add(new ViewModels { Name = "Elliot", PhoneNumber = "0729876543", City = "Skara" });
            //model.People.Add(new ViewModels { Name = "Linda", PhoneNumber = "0721239876", City = "Alingsås" });

            model.People
                .OrderBy(r => r.Name)
                .Where(r => searchTerm == null || (r.Name.Contains(searchTerm) || r.City.Contains(searchTerm)))
                .Take(10)
                .Select(r => r);
            //where r => searchTerm == null || r.Name.StartsWithsearchTerm
            //select r;

            

            Start++;
            if (Start == 1)
            {
                model.People.Add(new ViewModels { Name = "Isaac", PhoneNumber = "0723955431", City = "Skara" });
                model.People.Add(new ViewModels { Name = "Thomas", PhoneNumber = "0721234567", City = "Skara" });
                model.People.Add(new ViewModels { Name = "Elliot", PhoneNumber = "0729876543", City = "Skara" });
                model.People.Add(new ViewModels { Name = "Linda", PhoneNumber = "0721239876", City = "Alingsås" });
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
            var model = new PeopleViewModel();
            model.People = new List<ViewModels>();

            ViewModels match = model.People.Find(r => r.Name == id);
            if (match != null && model.People.Contains(match))
            {
                model.People.Remove(match);
            }
            return PartialView("_PartialPerson", model.People);
            //return View();
        }
        //public ActionResult Edit(string id)
        //{
        //    var model = 
        //}
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    return RedirectToAction("ViewPeople", PeopleViewModel.People);
        //}
        [HttpPost] 
        public ActionResult Create(ViewModels person)
        {
            var model = new PeopleViewModel();
            model.People = new List<ViewModels>();

            try
            {
                if (Request.IsAjaxRequest())
                {
                    if (ModelState.IsValid)
                    {
                        model.People.Add(new ViewModels { Name = person.Name, PhoneNumber = person.PhoneNumber, City = person.City });
                    }
                }
                return PartialView("_PartialPerson");
            }
            catch
            {
                return View();
            }
           
            
        }
    }
}