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
    
    internal partial class Extension_Mapping : EntityTypeConfiguration<Extension>
    {
        public Extension_Mapping()
        {                        
              this.HasKey(t => t.ExtensionID);        
              this.ToTable("Extension");
              this.Property(t => t.ExtensionID).HasColumnName("ExtensionID");
              this.Property(t => t.ExtensionName).HasColumnName("ExtensionName").IsRequired().IsUnicode(false).HasMaxLength(50);
         }
    }
}
