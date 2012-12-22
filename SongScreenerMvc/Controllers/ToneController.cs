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
    public class ToneController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Tone/

        public ViewResult Index()
        {
            return View(db.Tone.ToList());
        }

        //
        // GET: /Tone/Details/5

        public ViewResult Details(string id)
        {
            Tone tone = db.Tone.Find(id);
            return View(tone);
        }

        //
        // GET: /Tone/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Tone/Create

        [HttpPost]
        public ActionResult Create(Tone tone)
        {
            if (ModelState.IsValid)
            {
                db.Tone.Add(tone);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(tone);
        }
        
        //
        // GET: /Tone/Edit/5
 
        public ActionResult Edit(string id)
        {
            Tone tone = db.Tone.Find(id);
            return View(tone);
        }

        //
        // POST: /Tone/Edit/5

        [HttpPost]
        public ActionResult Edit(Tone tone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tone);
        }

        //
        // GET: /Tone/Delete/5
 
        public ActionResult Delete(string id)
        {
            Tone tone = db.Tone.Find(id);
            return View(tone);
        }

        //
        // POST: /Tone/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Tone tone = db.Tone.Find(id);
            db.Tone.Remove(tone);
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