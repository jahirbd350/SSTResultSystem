﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSTResultSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SSTResultSystemEntities : DbContext
    {
        public SSTResultSystemEntities()
            : base("name=SSTResultSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<result11> result11 { get; set; }
        public virtual DbSet<result12> result12 { get; set; }
        public virtual DbSet<result21> result21 { get; set; }
        public virtual DbSet<result22> result22 { get; set; }
        public virtual DbSet<result31> result31 { get; set; }
        public virtual DbSet<result32> result32 { get; set; }
        public virtual DbSet<result41> result41 { get; set; }
        public virtual DbSet<result42> result42 { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<cours> courses { get; set; }
    }
}
