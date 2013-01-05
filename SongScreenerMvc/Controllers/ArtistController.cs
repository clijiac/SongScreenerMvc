using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SongScreenerMvc.Models.Entity;

namespace SongScreenerMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ArtistController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Artist/

        public ViewResult Index()
        {
            var artist = db.Artist.Include(a => a.Gender).Include(a => a.Hometown);
            return View(artist.ToList());
        }

        //
        // GET: /Artist/Details/5

        public ViewResult Details(Guid id)
        {
            Artist artist = db.Artist.Find(id);
            return View(artist);
        }

        //
        // GET: /Artist/Create

        public ActionResult Create()
        {
            ViewBag.ArtistGender = new SelectList(db.Gender, "GenderID", "GenderName");
            ViewBag.ArtistHometown = new SelectList(db.Hometown, "HometownID", "HometownName");
            return View();
        } 

        //
        // POST: /Artist/Create

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (ModelState.IsValid)
            {
                artist.ArtistID = Guid.NewGuid();
                db.Artist.Add(artist);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.ArtistGender = new SelectList(db.Gender, "GenderID", "GenderName", artist.ArtistGender);
            ViewBag.ArtistHometown = new SelectList(db.Hometown, "HometownID", "HometownName", artist.ArtistHometown);
            return View(artist);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult AjaxCreate(Artist artist)
        {
            if (ModelState.IsValid)
            {
                artist.ArtistID = Guid.NewGuid();
                db.Artist.Add(artist);
                db.SaveChanges();
                return Json(new { Success = true, ArtistID = artist.ArtistID });
            }

            ViewBag.ArtistGender = new SelectList(db.Gender, "GenderID", "GenderName", artist.ArtistGender);
            ViewBag.ArtistHometown = new SelectList(db.Hometown, "HometownID", "HometownName", artist.ArtistHometown);
            return Json(new {Success = false, Message = "创建失败！"}, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Artist/Edit/5
 
        public ActionResult Edit(Guid id)
        {
            Artist artist = db.Artist.Find(id);
            ViewBag.ArtistGender = new SelectList(db.Gender, "GenderID", "GenderName", artist.ArtistGender);
            ViewBag.ArtistHometown = new SelectList(db.Hometown, "HometownID", "HometownName", artist.ArtistHometown);
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
            ViewBag.ArtistGender = new SelectList(db.Gender, "GenderID", "GenderName", artist.ArtistGender);
            ViewBag.ArtistHometown = new SelectList(db.Hometown, "HometownID", "HometownName", artist.ArtistHometown);
            return View(artist);
        }

        //
        // GET: /Artist/Delete/5
 
        public ActionResult Delete(Guid id)
        {
            Artist artist = db.Artist.Find(id);
            return View(artist);
        }

        //
        // POST: /Artist/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
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