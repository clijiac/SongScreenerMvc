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
    public class LanguageController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Language/

        public ViewResult Index()
        {
            return View(db.Language.ToList());
        }

        //
        // GET: /Language/Details/5

        public ViewResult Details(string id)
        {
            Language language = db.Language.Find(id);
            return View(language);
        }

        //
        // GET: /Language/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Language/Create

        [HttpPost]
        public ActionResult Create(Language language)
        {
            if (ModelState.IsValid)
            {
                db.Language.Add(language);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(language);
        }
        
        //
        // GET: /Language/Edit/5
 
        public ActionResult Edit(string id)
        {
            Language language = db.Language.Find(id);
            return View(language);
        }

        //
        // POST: /Language/Edit/5

        [HttpPost]
        public ActionResult Edit(Language language)
        {
            if (ModelState.IsValid)
            {
                db.Entry(language).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(language);
        }

        //
        // GET: /Language/Delete/5
 
        public ActionResult Delete(string id)
        {
            Language language = db.Language.Find(id);
            return View(language);
        }

        //
        // POST: /Language/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Language language = db.Language.Find(id);
            db.Language.Remove(language);
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