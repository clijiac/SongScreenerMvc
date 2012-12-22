using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SongScreenerMvc.Models;

namespace SongScreenerMvc.Controllers
{ 
    public class RhythmController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Rhythm/

        public ViewResult Index()
        {
            return View(db.Rhythm.ToList());
        }

        //
        // GET: /Rhythm/Details/5

        public ViewResult Details(string id)
        {
            Rhythm rhythm = db.Rhythm.Find(id);
            return View(rhythm);
        }

        //
        // GET: /Rhythm/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Rhythm/Create

        [HttpPost]
        public ActionResult Create(Rhythm rhythm)
        {
            if (ModelState.IsValid)
            {
                db.Rhythm.Add(rhythm);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(rhythm);
        }
        
        //
        // GET: /Rhythm/Edit/5
 
        public ActionResult Edit(string id)
        {
            Rhythm rhythm = db.Rhythm.Find(id);
            return View(rhythm);
        }

        //
        // POST: /Rhythm/Edit/5

        [HttpPost]
        public ActionResult Edit(Rhythm rhythm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rhythm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rhythm);
        }

        //
        // GET: /Rhythm/Delete/5
 
        public ActionResult Delete(string id)
        {
            Rhythm rhythm = db.Rhythm.Find(id);
            return View(rhythm);
        }

        //
        // POST: /Rhythm/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Rhythm rhythm = db.Rhythm.Find(id);
            db.Rhythm.Remove(rhythm);
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