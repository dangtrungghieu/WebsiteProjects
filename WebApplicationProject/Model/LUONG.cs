//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LUONG
    {
        public int MaLuong { get; set; }
        public int SoNgayCong { get; set; }
        public int TienBaoHiem { get; set; }
        public int TienThuong { get; set; }
        public System.DateTime NgayLap { get; set; }
        public int MaNhanVien_Luong { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
