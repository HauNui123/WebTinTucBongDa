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
    
    public partial class LoaiTin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiTin()
        {
            this.Tins = new HashSet<Tin>();
        }
    
        public int MaLoaiTin { get; set; }
        public string TenLoaiTin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tin> Tins { get; set; }
    }
}
