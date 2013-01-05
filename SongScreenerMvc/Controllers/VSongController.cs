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
    
    public class VSongController : Controller
    {
        private SongScreenerDBEntities db = new SongScreenerDBEntities();

        //
        // GET: /VSong/

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName");
            ViewBag.SongExtensionID = new SelectList(db.Extension, "ExtensionID", "ExtensionName");
            ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName");
            ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName");
           
            return View();
        }

        //
        // GET: /VSong/Details/5
        [Authorize(Roles = "Admin")]
        public ActionResult Details(Guid id)
        {
            Song song = db.Song.Find(id);
           VSong vSong = new VSong(song);
           return View(vSong);
        }

        //
        // GET: /VSong/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName");
            ViewBag.SongExtensionID = new SelectList(db.Extension, "ExtensionID", "ExtensionName");
            ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName");
            ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName");
            return View();
        }

        //
        // POST: /VSong/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(VSong song)
        {
            try
            {
                var newsong = Newsong(song);
                db.Song.Add(newsong);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName");
                ViewBag.SongExtensionID = new SelectList(db.Extension, "ExtensionID", "ExtensionName");
                ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName");
                ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName");
                return View();
            }
        }

        [NonAction]
        private Song Newsong(VSong song)
        {
            Song newsong = new Song
                               {
                                   SongName = song.SongName,
                                   Artist = song.Artist,
                                   Extension = db.Extension.FirstOrDefault(p => p.ExtensionID == song.SongExtensionID),
                                   Genre = db.Genre.FirstOrDefault(p => p.GenreID == song.SongGenreID),
                                   Language = db.Language.FirstOrDefault(p => p.LanguageID == song.SongLanguageID),
                                   SongID = song.SongID,
                                   SongIntonation = song.Intonation,
                                   SongTone = song.Tone,
                                   SongRhythm = song.Rhythm,
                                   SongPath = song.FliePath,
                                   SongArtistID = song.SongArtistID,
                                   SongLanguageID = song.SongLanguageID,
                                   SongGenreID = song.SongGenreID,
                                   SongExtensionID = song.SongExtensionID
                               };
            return newsong;
        }

        //
        // GET: /VSong/Edit/5

        public ActionResult Edit(Guid id)
        {
            Song song = db.Song.Find(id);
            ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName", song.SongArtistID);
            ViewBag.SongExtensionID = new SelectList(db.Extension, "ExtensionID", "ExtensionName", song.SongExtensionID);
            ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName", song.SongGenreID);
            ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName", song.SongLanguageID);
            VSong vSong = new VSong(song);
            return View(vSong);
        }

        //
        // POST: /VSong/Edit/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(VSong vSong)
        {
            try
            {
                var newsong = Newsong(vSong);
                db.Entry(newsong).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {

                ViewBag.SongArtistID = new SelectList(db.Artist, "ArtistID", "ArtistName");
                ViewBag.SongExtensionID = new SelectList(db.Extension, "ExtensionID", "ExtensionName");
                ViewBag.SongGenreID = new SelectList(db.Genre, "GenreID", "GenreName");
                ViewBag.SongLanguageID = new SelectList(db.Language, "LanguageID", "LanguageName");
                
                return View(vSong);
            }
        }

        //
        // GET: /VSong/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            Song song = db.Song.Find(id);
            VSong vSong = new VSong(song);
            return View(vSong);
        }

        //
        // POST: /VSong/Delete/5

        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                Song song = db.Song.Find(id);
                string filePath = Server.MapPath(song.SongPath);
                FileInfo file = new FileInfo(filePath);
                if (file.Exists)
                {
                    file.Delete(); //删除单个文件
                }
                db.Song.Remove(song);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                Song song = db.Song.Find(id);
                VSong vSong = new VSong(song);
                return View(vSong);
            }
        }

        public ActionResult Upload()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Upload(HttpPostedFileBase fileData,Guid guid)
        {
            if (fileData != null)
            {
                try
                {
                    // 文件上传后的保存路径
                    string filePath = Server.MapPath("~/upload/");
                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }
                    string fileName = Path.GetFileName(fileData.FileName);// 原始文件名称
                    string fileExtension = Path.GetExtension(fileName); // 文件扩展名
                    Extension extension = db.Extension.FirstOrDefault(e =>
                                                                      string.Compare("." + e.ExtensionName, fileExtension,
                                                                                     StringComparison
                                                                                         .InvariantCultureIgnoreCase) ==
                                                                      0);
                    //Guid guid = Guid.NewGuid();
                    string saveName = guid + fileExtension; // 保存文件名称
                    string savePath = filePath + saveName;
                    FileInfo file = new FileInfo(savePath);
                    if (file.Exists)
                    {
                        file.Delete(); //删除单个文件
                    }
                    fileData.SaveAs(savePath);

                    if (extension != null)
                    {
                        return Json(new { Success = true, FileExtension = extension.ExtensionID, Path = "~/upload/" + saveName, Guid = guid });
                    }
                    else
                    {

                        throw new Exception("后缀名不一致");
                    }
                }
                catch (Exception ex)
                {
                    return Json(new { Success = false, Message = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {

                return Json(new { Success = false, Message = "请选择要上传的文件！" }, JsonRequestBehavior.AllowGet);
            }
        }

        [Authorize(Roles = "Admin")]
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
                        (string.IsNullOrEmpty(SongName) || item.SongName.Contains(SongName))).Skip((page - 1) * rows).Take(rows);
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
                                                            }));
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
                                                 })).Skip((page - 1)*rows).Take(rows);
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