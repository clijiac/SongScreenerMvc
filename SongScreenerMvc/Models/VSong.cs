#region Header

// -----------------------------------------------------------------------
// SongScreenerMvc-SongScreenerMvc-VSong.cs
// clijiac  201212-28
// -----------------------------------------------------------------------

#endregion

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SongScreenerMvc.Models.Entity;

namespace SongScreenerMvc.Models
{
    public class VSong 
    {
        public System.Guid SongID { get; set; }
        //[Required(ErrorMessage = "必须输入")]
        [DisplayName("歌曲名")]
        public string SongName { get; set; }
        [Required(ErrorMessage = "必须输入")]
        [DisplayName("音色")]
        [Range(0, 10, ErrorMessage = "节奏必须在0到10之间")]
        public int Intonation { get; set; }
        [Required(ErrorMessage = "必须输入")]
        [DisplayName("声调")]
        [Range(0, 10, ErrorMessage = "节奏必须在0到10之间")]
        public int Tone { get; set; }
        [Required(ErrorMessage = "必须输入")]
        [DisplayName("节奏")]
        [Range(0, 10, ErrorMessage = "节奏必须在0到10之间")]
        public int Rhythm { get; set; }
        //[Required(ErrorMessage = "必须输入")]
        [DisplayName("歌曲路径")]
        public string FliePath { get; set; }
        [Required(ErrorMessage = "必须输入")]
        [DisplayName("歌手")]
        public Artist Artist { get; set; }
        //[Required(ErrorMessage = "必须输入")]
        [DisplayName("后缀名")]
        public Extension Extension { get; set; }
        [Required(ErrorMessage = "必须输入")]
        [DisplayName("流派")]
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "必须输入")]
        [DisplayName("语言")]
        public Language Language { get; set; }

        public System.Guid SongArtistID { get; set; }
        public System.Guid SongLanguageID { get; set; }
        public System.Guid SongGenreID { get; set; }
        public System.Guid SongExtensionID { get; set; }
        public VSong(Song song)
        {
            Artist = song.Artist;
            Extension = song.Extension;
            Genre = song.Genre;
            Language = song.Language;
            SongID = song.SongID;
            SongName = song.SongName;
            Intonation = song.SongIntonation;
            Tone = song.SongTone;
            Rhythm = song.SongRhythm;
            FliePath = song.SongPath;
            SongArtistID = song.SongArtistID;
            SongLanguageID = song.SongLanguageID;
            SongGenreID = song.SongGenreID;
            SongExtensionID = song.SongExtensionID;
        }
        public VSong(){}
    }
}