#region Header
// -----------------------------------------------------------------------
// SongScreenerMvc-SongScreenerMvc-VArtist.cs 
// clijiac  2012-12-28
// -----------------------------------------------------------------------
#endregion

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SongScreenerMvc.Models.Entity;

namespace SongScreenerMvc.Models
{
    public class VArtist :Artist
    {
       
    
        public System.Guid ArtistId { get; set; }
        public new string ArtistName { get; set; }
        [Required(ErrorMessage = "必须输入")]
        [DisplayName("语言")]
        public new Gender Gender { get; set; }
        public new Hometown Hometown { get; set; }
        public new ICollection<Song> Song { get; set; }

        public VArtist(Artist artist)
        {
            ArtistId = artist.ArtistID;
            ArtistName = artist.ArtistName;
            Gender = artist.Gender;
            Hometown = artist.Hometown;
            Song = artist.Song;
        }
    }
}