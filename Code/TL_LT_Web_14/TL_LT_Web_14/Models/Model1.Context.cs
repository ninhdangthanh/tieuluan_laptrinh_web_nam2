﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TL_LT_Web_14.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Dan_So_Mot_Quan_14Entities : DbContext
    {
        public Dan_So_Mot_Quan_14Entities()
            : base("name=Dan_So_Mot_Quan_14Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietPhieuDiChuyen> ChiTietPhieuDiChuyens { get; set; }
        public virtual DbSet<HoKhau> HoKhaus { get; set; }
        public virtual DbSet<NgoaiNgu> NgoaiNgus { get; set; }
        public virtual DbSet<NhanKhau> NhanKhaus { get; set; }
        public virtual DbSet<PhieuDiChuyen> PhieuDiChuyens { get; set; }
        public virtual DbSet<TrinhDo> TrinhDoes { get; set; }
    }
}