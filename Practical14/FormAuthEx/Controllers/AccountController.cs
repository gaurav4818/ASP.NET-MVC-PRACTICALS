using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormAuthEx.Models;
using System.Web.Security;

namespace FormAuthEx.Controllers
{
   
    public class AccountController : Controller
    {
        officeEntities db = new officeEntities();
        // GET: Account

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(MembershipEx model)
        {
            bool IsValidUser = db.UserInfo.Any(x=> x.UserName==model.UserName && x.Password==model.Password);
            if(IsValidUser)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("Index","Employees");
            }
            ModelState.AddModelError("", "Invalid UserName or Password");

            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserInfo user)
        {
           
            if (user.UserName != null && user.Password != null)
            {
                
                db.UserInfo.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                ModelState.AddModelError("", "Please Enter UserName or Password");
                return View();
            }
           
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}