//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otel.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLURUNGRUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLURUNGRUP()
        {
            this.TBLURUN = new HashSet<TBLURUN>();
        }
    
        public int UrunGrupID { get; set; }
        public string UrunGrupAd { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TBLDURUM TBLDURUM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUN> TBLURUN { get; set; }
    }
}
