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
    
    public partial class TBLMISAFIR
    {
        public int MisafirID { get; set; }
        public string AdSoyad { get; set; }
        public string TC { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public string KimlikFoto1 { get; set; }
        public string KimlikFoto2 { get; set; }
        public Nullable<int> Ulke { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TBLDURUM TBLDURUM { get; set; }
    }
}
