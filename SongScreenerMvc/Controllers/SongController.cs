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
    public class SongController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Song/

        public ViewResult Index()
        {
            var song = db.Song.Include(s => s.Artist).Include(s => s.Genre).Include(s => s.Intonation).Include(s => s.Language).Include(s => s.Rhythm).Include(s => s.Tone);
            return View(song.ToList());
        }

        //
        // GET: /Song/Details/5

        public ViewResult Details(string id)
        {
            Song song = db.Song.Find(id);
            return View(song);
        }

        //
        // GET: /Song/Create

        public ActionResult Create()
        {
            ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName");
            ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName");
            ViewBag.SongIntonationID = new SelectList(db.Intonation, "IntonationID", "IntonationName");
            ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName");
            ViewBag.SongRhythmID = new SelectList(db.Rhythm, "RhythmID", "RhythmName");
            ViewBag.SongToneID = new SelectList(db.Tone, "ToneID", "ToneName");
            return View();
        } 

        //
        // POST: /Song/Create

        [HttpPost]
        public ActionResult Create(Song song)
        {
            if (ModelState.IsValid)
            {
                db.Song.Add(song);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName", song.SongArtistID);
            ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName", song.SongGenreID);
            ViewBag.SongIntonationID = new SelectList(db.Intonation, "IntonationID", "IntonationName", song.SongIntonationID);
            ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName", song.SongLanguageID);
            ViewBag.SongRhythmID = new SelectList(db.Rhythm, "RhythmID", "RhythmName", song.SongRhythmID);
            ViewBag.SongToneID = new SelectList(db.Tone, "ToneID", "ToneName", song.SongToneID);
            return View(song);
        }
        
        //
        // GET: /Song/Edit/5
 
        public ActionResult Edit(string id)
        {
            Song song = db.Song.Find(id);
            ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName", song.SongArtistID);
            ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName", song.SongGenreID);
            ViewBag.SongIntonationID = new SelectList(db.Intonation, "IntonationID", "IntonationName", song.SongIntonationID);
            ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName", song.SongLanguageID);
            ViewBag.SongRhythmID = new SelectList(db.Rhythm, "RhythmID", "RhythmName", song.SongRhythmID);
            ViewBag.SongToneID = new SelectList(db.Tone, "ToneID", "ToneName", song.SongToneID);
            return View(song);
        }

        //
        // POST: /Song/Edit/5

        [HttpPost]
        public ActionResult Edit(Song song)
        {
            if (ModelState.IsValid)
            {
                db.Entry(song).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName", song.SongArtistID);
            ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName", song.SongGenreID);
            ViewBag.SongIntonationID = new SelectList(db.Intonation, "IntonationID", "IntonationName", song.SongIntonationID);
            ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName", song.SongLanguageID);
            ViewBag.SongRhythmID = new SelectList(db.Rhythm, "RhythmID", "RhythmName", song.SongRhythmID);
            ViewBag.SongToneID = new SelectList(db.Tone, "ToneID", "ToneName", song.SongToneID);
            return View(song);
        }

        //
        // GET: /Song/Delete/5
 
        public ActionResult Delete(string id)
        {
            Song song = db.Song.Find(id);
            return View(song);
        }

        //
        // POST: /Song/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {            
            Song song = db.Song.Find(id);
            db.Song.Remove(song);
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