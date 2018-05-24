using MvcGround.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGround.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult FeverCheck()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GuessingGame()
        {
            return View();
        }
        [HttpPost]

        public ActionResult FeverCheck(double input)
        {     
           if(input == 0)
            {
                return View();
            }
           else
            {
                ViewBag.Result = CheckNumber.NumberCheck(input);
                return View();
            }
               
            
                
        }
        [HttpPost]
        public ActionResult GuessingGame(int guess)
        {
                ViewBag.GuessResult = CheckNumber.CheckRndNumber(guess);
                return View();
        }
      
    }
}