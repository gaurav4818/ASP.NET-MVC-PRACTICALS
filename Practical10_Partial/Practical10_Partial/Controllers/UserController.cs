using Practical10_Partial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical10_Partial.Controllers
{
    public class UserController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.model = User;
            return View(model.AllUser);
        }
       
        public ActionResult Create()
        {

            return View();
        }
       
        [HttpPost]
        public ActionResult Create(User user)
        {
            model res = new model();
            res.add(user);

            return RedirectToAction("Index");

        }
       
        public ActionResult Details(int id)
        {
            model res = new model();
            var r = res.Get(id);
            return View(r);
        }
       
        [HttpGet]
        public ActionResult Delete(int id)
        {
            model res = new model();
            var r = res.Get(id);
            return View(r);
        }
     
        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            model res = new model();
            res.Delete(id);
            return RedirectToAction("Index");
        }
     
        public ActionResult Edit(int id)
        {
            model res = new model();
            var m = res.Get(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            model res = new model();
            if (ModelState.IsValid)
            {
                res.Edit(user);
                return RedirectToAction("Details", new { ID = user.ID });
            }
            return View(user);
        }

    }
}