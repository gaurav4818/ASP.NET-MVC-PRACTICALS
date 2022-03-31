using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical10.Models;

namespace Practical10.Controllers
{
    public class HomeController : Controller
    {
        static IList<User> userlist = new List<User>{
        new User() {Id=1,Name="gaurav",Date=DateTime.ParseExact(20010121.ToString(),"yyyyMMdd",null),Address="Ahmedabad"}
        };

        

       
        
        // GET: Home
        //View Action
        public ActionResult Index()
        {
            
            return View(userlist.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(User obj)
        {
          
            obj.Id = userlist.Max(x => x.Id) + 1;
            userlist.Add(obj);
            return RedirectToAction("Index");
            
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
