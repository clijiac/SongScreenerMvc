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
    
    public partial class Language
    {
        public Language()
        {
            this.Song = new HashSet<Song>();
        }
    
        public System.Guid LanguageID { get; set; }
        public string LanguageName { get; set; }
    
        public virtual ICollection<Song> Song { get; set; }
    }
}