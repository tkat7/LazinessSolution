using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lazybones.Models;
using System.Web.Security;
using Microsoft.AspNet.Identity;

namespace Lazybones.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult Dashboard()
        {
            ViewBag.Message = "Dashboard";

            return RedirectToAction("UserProfile", "Manage");
        }
    }
}