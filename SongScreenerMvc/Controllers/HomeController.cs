using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SongScreenerMvc.Models;
using SongScreenerMvc.Models.Entity;
using SongScreenerMvc.Utility;

namespace SongScreenerMvc.Controllers
{
    public class HomeController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName");
            ViewBag.SongExtensionID = new SelectList(db.Extension, "ExtensionID", "ExtensionName");
            ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName");
            ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName");
            return View();
        }

        public ActionResult About()
        {
            return View();
        }


        public JsonResult LoadSongList(FormCollection collection)
        {
            Guid SongArtistID;
            Guid SongGenreID;
            Guid SongLanguageID;
            string SongName;
            int Intonation;
            int Rhythm;
            int Tone;
            int page = 1;
            int rows = 10;
            page = page <= 0 ? 1 : page;
            rows = rows <= 0 ? 10 : rows;
            int.TryParse(collection["page"], out page);
            int.TryParse(collection["rows"], out rows);
            int isSearch = 0;
            int.TryParse(collection["isSearch"], out isSearch);
            if (isSearch == 1)
            {
                int.TryParse(collection["Tone"], out Tone);
                int.TryParse(collection["Intonation"], out Intonation);
                int.TryParse(collection["Rhythm"], out Rhythm);
                SongName = string.IsNullOrEmpty(collection["SongName"]) ? string.Empty : collection["SongName"];
                SongLanguageID = string.IsNullOrEmpty(collection["SongLanguageID"]) ? Guid.Empty : new Guid(collection["SongLanguageID"]); ;
                SongGenreID = string.IsNullOrEmpty(collection["SongGenreID"]) ? Guid.Empty : new Guid(collection["SongGenreID"]); ;
                if (string.IsNullOrEmpty(collection["SongArtistID"])) SongArtistID = Guid.Empty;
                else SongArtistID = new Guid(collection["SongArtistID"]);

                var sresult =
                    db.Song.Where(
                        item =>
                        (SongArtistID == Guid.Empty || item.SongArtistID == SongArtistID)
                        && (SongGenreID == Guid.Empty || item.SongGenreID == SongGenreID) &&
                        (SongLanguageID == Guid.Empty || item.SongLanguageID == SongLanguageID) &&
                        (Tone == 0 || item.SongTone == Tone) &&
                        (Intonation == 0 || item.SongIntonation == Intonation) &&
                        (Rhythm == 0 || item.SongRhythm == Rhythm) &&
                        (string.IsNullOrEmpty(SongName) || item.SongName.Contains(SongName)));
                var songs = sresult.ToList();
                var vSongs = songs.Select(song => new VSong(song));
                var songResult = (vSongs.Select(item => new
                {
                    item.SongID,
                    item.SongName,
                    item.Artist.ArtistName,
                    item.Intonation,
                    item.Tone,
                    item.Rhythm,
                    item.Genre.GenreName,
                    item.Language.LanguageName,
                    item.FliePath
                })).Skip((page - 1) * rows).Take(rows);
                var result = new
                {
                    total = songs.Count,
                    rows = songResult
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var songs = db.Song.ToList();

                var vSongs = songs.Select(song => new VSong(song));
                var songResult
                    = (vSongs.Select(item => new
                    {
                        item.SongID,
                        item.SongName,
                        item.Artist.ArtistName,
                        item.Intonation,
                        item.Tone,
                        item.Rhythm,
                        item.Genre.GenreName,
                        item.Language.LanguageName,
                        item.FliePath
                    })).Skip((page - 1) * rows).Take(rows);
                var result = new
                {
                    total = songs.Count,
                    rows = songResult
                };
                return Json(result, JsonRequestBehavior.AllowGet);
            }


        }

    }
}
