﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodManagement.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NgoEntities : DbContext
    {
        public NgoEntities()
            : base("name=NgoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Post> Posts { get; set; }
        public DbSet<Restaurent> Restaurents { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Collector> Collectors { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}