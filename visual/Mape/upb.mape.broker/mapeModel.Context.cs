﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upb.mape.broker
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mapeEntities : DbContext
    {
        public mapeEntities()
            : base("name=mapeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<comments_mapers> comments_mapers { get; set; }
        public virtual DbSet<comments_users> comments_users { get; set; }
        public virtual DbSet<date> dates { get; set; }
        public virtual DbSet<maper> mapers { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}