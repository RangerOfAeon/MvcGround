using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;


namespace MvcGround.Controllers
{
    public class IdentityController : Controller
    {
        // GET: Identity
        public ActionResult Identity()
        {
            return View();
        }
    }
}