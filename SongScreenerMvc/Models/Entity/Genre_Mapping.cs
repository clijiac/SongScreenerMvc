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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class Genre_Mapping : EntityTypeConfiguration<Genre>
    {
        public Genre_Mapping()
        {                        
              this.HasKey(t => t.GenreID);        
              this.ToTable("Genre");
              this.Property(t => t.GenreID).HasColumnName("GenreID");
              this.Property(t => t.GenreName).HasColumnName("GenreName").IsRequired().HasMaxLength(255);
         }
    }
}