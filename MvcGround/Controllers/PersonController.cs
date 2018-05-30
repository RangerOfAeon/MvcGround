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
        private static List<ViewModels> people = new List<ViewModels>()
        {
            new ViewModels
            {
                Name = "Isaac",
                PhoneNumber = "0723955431",
                City = "Skara"
            },
            new ViewModels
            {
                Name = "Thomas",
                PhoneNumber = "0721234567",
                City = "Skara"
            },
             new ViewModels
            {
                Name = "Elliot",
                PhoneNumber = "0729876543",
                City = "Skara"
            },
              new ViewModels
            {
                Name = "Linda",
                PhoneNumber = "0721239876",
                City = "Alingsås"
            },
        };

        // GET: Person
        [HttpGet]
        public ActionResult ViewPeople()
        {
            
            return View();
        }
      
    }
}