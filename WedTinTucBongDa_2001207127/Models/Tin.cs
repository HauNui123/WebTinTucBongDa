//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WedTinTucBongDa_2001207127.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tin
    {
        public int MaTin { get; set; }
        public string TieuDe { get; set; }
        public string TomTat { get; set; }
        public string NoiDung { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<int> MaLoaiTin { get; set; }
        public Nullable<int> MaGiaiDau { get; set; }
        public string LoGo1 { get; set; }
        public string LoGo2 { get; set; }
    
        public virtual GiaiDau GiaiDau { get; set; }
        public virtual LoaiTin LoaiTin { get; set; }
    }
}
