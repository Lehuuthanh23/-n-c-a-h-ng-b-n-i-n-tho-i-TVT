//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.CTHDBANHANG = new HashSet<CTHDBANHANG>();
        }
    
        public string MASP { get; set; }
        public string TEN { get; set; }
        public string MALOAISP { get; set; }
        public string MANSX { get; set; }
        public int SOLUONG { get; set; }
        public int DONGIA { get; set; }
        public string MOTA { get; set; }
        public bool XOA { get; set; }
        public string GHICHU { get; set; }
        public byte[] ANH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDBANHANG> CTHDBANHANG { get; set; }
        public virtual LOAISANPHAM LOAISANPHAM { get; set; }
        public virtual NHASANXUAT NHASANXUAT { get; set; }
    }
}