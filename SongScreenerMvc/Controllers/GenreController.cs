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
    public class GenreController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Genre/

        public ViewResult Index()
        {
            return View(db.Genre.ToList());
        }

        //
        // GET: /Genre/Details/5

        public ViewResult Details(string id)
        {
            Genre genre = db.Genre.Find(id);
            return View(genre);
        }

        //
        // GET: /Genre/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Genre/Create

        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                db.Genre.Add(genre);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(genre);
        }
        
        //
        // GET: /Genre/Edit/5
 
        public ActionResult Edit(string id)
        {
            Genre genre = db.Genre.Find(id);
            return View(genre);
        }

        //
        // POST: /Genre/Edit/5

        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(genre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        //
        // GET: /Genre/Delete/5
 
        public ActionResult Delete(string id)
        {
            Genre genre = db.Genre.Find(id);
            return View(genre);
        }

        //
        // POST: /Genre/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Genre genre = db.Genre.Find(id);
            db.Genre.Remove(genre);
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