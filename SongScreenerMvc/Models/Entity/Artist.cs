//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SongScreenerMvc.Models.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Artist
    {
        public Artist()
        {
            this.Song = new HashSet<Song>();
        }
    
        public System.Guid ArtistID { get; set; }
        public string ArtistName { get; set; }
        public System.Guid ArtistGender { get; set; }
        public System.Guid ArtistHometown { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Hometown Hometown { get; set; }
        public virtual ICollection<Song> Song { get; set; }
    }
}
