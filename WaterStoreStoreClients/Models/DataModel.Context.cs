﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaterStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WaterStoreEntities : DbContext
    {
        public WaterStoreEntities()
            : base("name=WaterStoreEntities")
        {
        }

        public static WaterStoreEntities context;

        public static WaterStoreEntities GetContext()
        {
            if (context == null)
                context = new WaterStoreEntities();
            return context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Categoris> Categoris { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientService> ClientService { get; set; }
        public virtual DbSet<FurnitureOrders> FurnitureOrders { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Status> Status { get; set; }
    }
}