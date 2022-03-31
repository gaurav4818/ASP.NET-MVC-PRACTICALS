using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical9.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Return View
        public ViewResult Index()
        {
            return View();
        }
        //Return Content
        public ContentResult contentex()
        {
            return Content("This is Content Result Example");

        }
        //Return Empty result
        public EmptyResult emptyex()
        {
            return new EmptyResult();
        }
        //Return JavaScript result
        public JavaScriptResult javascriptex()
        {
            return JavaScript("alert('This is JavaScript Result Example')");
        }
        //Return JSON result

        public JsonResult jsonex()
        {
            return Json(new { Name = "Gaurav", CompanyName = "Simform", Technology = "Asp.Net" }, JsonRequestBehavior.AllowGet);
        }
        //Return File
        public FileResult fileex()
        {
            return File("/Files/myfile.txt", "text/plain", "myfile.txt");
        }
        //Display file content on website
        public FileContentResult filecontentex()
        {
            byte[] files = System.IO.File.ReadAllBytes(Server.MapPath("~/Files/myfile.txt"));
            return new FileContentResult(files, "text/plain");
        }

        //Demo of OutputCache Filter
        [OutputCache(Duration = 300)]
        public ActionResult outputcacheex()
        {
            return View();
        }
        [HandleError]
        public ActionResult ErrorDemo()
        {
            int a = 10;
            int b = 5;

            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return Content($"Ans : {a/b}");
            }
              
        }
    }
}