//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    
    public partial class FN_SearchProduct1_Result
    {
        public int urunID { get; set; }
        public string ad { get; set; }
        public Nullable<int> markaID { get; set; }
        public string marka { get; set; }
        public Nullable<int> altKategoriID { get; set; }
        public string altKategori { get; set; }
        public Nullable<decimal> fiyat { get; set; }
        public Nullable<System.DateTime> eklenmeTarihi { get; set; }
        public Nullable<int> stokID { get; set; }
        public Nullable<int> adet { get; set; }
        public Nullable<bool> satinAlinmaDurumu { get; set; }
        public string imagePath { get; set; }
    }
}
