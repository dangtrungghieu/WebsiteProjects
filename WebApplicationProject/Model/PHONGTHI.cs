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
    
    public partial class PHONGTHI
    {
        public int MaPhongThi { get; set; }
        public int SoLuong { get; set; }
        public System.DateTime NgayThi { get; set; }
        public Nullable<int> MaNhanVien_PhongThi { get; set; }
        public Nullable<int> MaPhongHoc_PhongThi { get; set; }
        public Nullable<int> MaCaThi_PhongThi { get; set; }
        public Nullable<int> MaKhoaHoc_PhongThi { get; set; }
    
        public virtual CATHI CATHI { get; set; }
        public virtual KHOAHOC KHOAHOC { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHONGHOC PHONGHOC { get; set; }
    }
}