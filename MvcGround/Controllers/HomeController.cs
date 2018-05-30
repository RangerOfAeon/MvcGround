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

        public ActionResult FeverCheck(double input)                            //När använderan skickar sin temp, så startar denna ActionResult.
        {     
           if(input == 0)                                                       //Om tempen är 0, så skriver sidan inte ut resultatet.
            {
                return View();
            }
           else
            {
                ViewBag.Result = CheckNumber.NumberCheck(input);                //Sätter värdet från input och sätter det i ViewBag.Result.
                return View();
            }
               
            
                
        }
        [HttpPost]                                                              //När spelaren skickar sin gissning på Guessing Game, så startar denna ActionResult. 
        public ActionResult GuessingGame(int guess)
        {
            Session["GuessResult"] = CheckNumber.CheckRndNumber(guess);         //Den tar värderna guess och failCounter, och sätter i dom i sessions.
            Session["FailCounter"] = CheckNumber.failCounter;
                return View();
        }
      
    }
}