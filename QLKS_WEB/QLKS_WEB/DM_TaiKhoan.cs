//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS_WEB
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_TaiKhoan
    {
        public DM_TaiKhoan()
        {
            this.TT_TaiKhoan = new HashSet<TT_TaiKhoan>();
        }
    
        public string ID { get; set; }
        public string PW { get; set; }
        public Nullable<int> Quyen { get; set; }
    
        public virtual ICollection<TT_TaiKhoan> TT_TaiKhoan { get; set; }
    }
}
