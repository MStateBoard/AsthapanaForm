﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AastapanaForm_Application.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Db_AsthapanaEntities : DbContext
    {
        public Db_AsthapanaEntities()
            : base("name=Db_AsthapanaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Section1> Tbl_Section1 { get; set; }
        public virtual DbSet<Tbl_Section2> Tbl_Section2 { get; set; }
        public virtual DbSet<Tbl_Section3> Tbl_Section3 { get; set; }
        public virtual DbSet<Tbl_Section4> Tbl_Section4 { get; set; }
        public virtual DbSet<Tbl_Login> Tbl_Login { get; set; }
        public virtual DbSet<Tbl_Section> Tbl_Section { get; set; }
    }
}
