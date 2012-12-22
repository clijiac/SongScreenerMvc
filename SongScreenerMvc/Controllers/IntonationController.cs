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
    public class IntonationController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Intonation/

        public ViewResult Index()
        {
            return View(db.Intonation.ToList());
        }

        //
        // GET: /Intonation/Details/5

        public ViewResult Details(string id)
        {
            Intonation intonation = db.Intonation.Find(id);
            return View(intonation);
        }

        //
        // GET: /Intonation/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Intonation/Create

        [HttpPost]
        public ActionResult Create(Intonation intonation)
        {
            if (ModelState.IsValid)
            {
                db.Intonation.Add(intonation);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(intonation);
        }
        
        //
        // GET: /Intonation/Edit/5
 
        public ActionResult Edit(string id)
        {
            Intonation intonation = db.Intonation.Find(id);
            return View(intonation);
        }

        //
        // POST: /Intonation/Edit/5

        [HttpPost]
        public ActionResult Edit(Intonation intonation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(intonation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(intonation);
        }

        //
        // GET: /Intonation/Delete/5
 
        public ActionResult Delete(string id)
        {
            Intonation intonation = db.Intonation.Find(id);
            return View(intonation);
        }

        //
        // POST: /Intonation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Intonation intonation = db.Intonation.Find(id);
            db.Intonation.Remove(intonation);
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