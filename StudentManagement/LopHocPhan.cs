//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class LopHocPhan
    {
        public string MaLHP { get; set; }
        public string MaMH { get; set; }
        public string MaKhoaHoc { get; set; }
        public Nullable<int> NamHoc { get; set; }
        public Nullable<int> MaGV { get; set; }
        public Nullable<int> SiSoSV { get; set; }
    
        public virtual GiangVien GiangVien { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
        public virtual MonHoc MonHoc { get; set; }
    }
}