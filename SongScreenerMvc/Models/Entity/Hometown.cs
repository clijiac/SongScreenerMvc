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
    
    public partial class Hometown
    {
        public Hometown()
        {
            this.Artist = new HashSet<Artist>();
        }
    
        public System.Guid HometownID { get; set; }
        public string HometownName { get; set; }
    
        public virtual ICollection<Artist> Artist { get; set; }
    }
}
