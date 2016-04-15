using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmsApp.Models;

namespace AmsApp.Controllers
{ 
    public class UserViewsController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /UserViews/

        public ViewResult Index()
        {
            return View(db.UserViews.ToList());
        }

        //
        // GET: /UserViews/Details/5

        public ViewResult Details(int id)
        {
            UserViews userviews = db.UserViews.Find(id);
            return View(userviews);
        }

        //
        // GET: /UserViews/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /UserViews/Create

        [HttpPost]
        public ActionResult Create(UserViews userviews)
        {
            if (ModelState.IsValid)
            {
                db.UserViews.Add(userviews);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(userviews);
        }
        
        //
        // GET: /UserViews/Edit/5
 
        public ActionResult Edit(int id)
        {
            UserViews userviews = db.UserViews.Find(id);
            return View(userviews);
        }

        //
        // POST: /UserViews/Edit/5

        [HttpPost]
        public ActionResult Edit(UserViews userviews)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userviews).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userviews);
        }

        //
        // GET: /UserViews/Delete/5
 
        public ActionResult Delete(int id)
        {
            UserViews userviews = db.UserViews.Find(id);
            return View(userviews);
        }

        //
        // POST: /UserViews/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            UserViews userviews = db.UserViews.Find(id);
            db.UserViews.Remove(userviews);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}