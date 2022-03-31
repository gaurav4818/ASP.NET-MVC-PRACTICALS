using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindowAuthEx.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Users = @"SF-CPU-507\gaurav")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Users = @"SF-CPU-507\simformsolutions")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
 
         [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}