﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace database_logic.model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kid_storeEntities : DbContext
    {
        public kid_storeEntities()
            : base("name=kid_storeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categoria_productos> categoria_productos { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<producto> productos { get; set; }
        public virtual DbSet<vw_productos> vw_productos { get; set; }
    }
}