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
    public class ArtistController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Artist/

        public ViewResult Index()
        {
            return View(db.Artist.ToList());
        }

        //
        // GET: /Artist/Details/5

        public ViewResult Details(string id)
        {
            Artist artist = db.Artist.Find(id);
            return View(artist);
        }

        //
        // GET: /Artist/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Artist/Create

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Artist.Add(artist);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(artist);
        }
        
        //
        // GET: /Artist/Edit/5
 
        public ActionResult Edit(string id)
        {
            Artist artist = db.Artist.Find(id);
            return View(artist);
        }

        //
        // POST: /Artist/Edit/5

        [HttpPost]
        public ActionResult Edit(Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artist);
        }

        //
        // GET: /Artist/Delete/5
 
        public ActionResult Delete(string id)
        {
            Artist artist = db.Artist.Find(id);
            return View(artist);
        }

        //
        // POST: /Artist/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Artist artist = db.Artist.Find(id);
            db.Artist.Remove(artist);
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