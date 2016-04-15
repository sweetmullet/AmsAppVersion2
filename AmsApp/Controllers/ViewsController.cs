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
    public class ViewsController : Controller
    {
        private AmsAppDBContext db = new AmsAppDBContext();

        //
        // GET: /Views/

        public ViewResult Index()
        {
            return View(db.Views.ToList());
        }

        //
        // GET: /Views/Details/5

        public ViewResult Details(int id)
        {
            Views views = db.Views.Find(id);
            return View(views);
        }

        //
        // GET: /Views/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Views/Create

        [HttpPost]
        public ActionResult Create(Views views)
        {
            if (ModelState.IsValid)
            {
                db.Views.Add(views);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(views);
        }
        
        //
        // GET: /Views/Edit/5
 
        public ActionResult Edit(int id)
        {
            Views views = db.Views.Find(id);
            return View(views);
        }

        //
        // POST: /Views/Edit/5

        [HttpPost]
        public ActionResult Edit(Views views)
        {
            if (ModelState.IsValid)
            {
                db.Entry(views).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(views);
        }

        //
        // GET: /Views/Delete/5
 
        public ActionResult Delete(int id)
        {
            Views views = db.Views.Find(id);
            return View(views);
        }

        //
        // POST: /Views/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Views views = db.Views.Find(id);
            db.Views.Remove(views);
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