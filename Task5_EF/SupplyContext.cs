using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Task5_EF.Managers;
using Task5_EF.Models;

namespace Task5_EF
{
    public class SupplyContext : DbContext
    {
        public DbSet<FlowerModel> Flowers { get; set; }
 
        public DbSet<WarehouseModel> Warehouses { get; set; }

        public DbSet<StatusModel> Statuses { get; set; }


        StatusTableManager statusTable = new StatusTableManager();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("FlowerSupply");

            statusTable.statusConstraint(modelBuilder);

            modelBuilder.Entity<FlowerModel>()
                .ToTable("Flower")
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<WarehouseModel>()
                .ToTable("Warehouse")
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<WarehouseModel>()
                .Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(60);

            modelBuilder.Entity<FlowerModel>()
                .HasMany(f => f.Warehouses)
                .WithMany(w => w.Flowers);

        }
    }
}