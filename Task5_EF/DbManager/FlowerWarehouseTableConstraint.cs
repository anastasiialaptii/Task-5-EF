using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Task5_EF.Models;

namespace Task5_EF.DbManager
{
    public class FlowerWarehouseTableConstraint
    {

        public void FlowerWarehouseTable(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlowerWarehouseModel>()
                .ToTable("FlowerWarehouse")
                .HasKey(k => new { k.FlowerId, k.WhId });


            modelBuilder.Entity<FlowerWarehouseModel>()
                .ToTable("FlowerWarehouse")
                .HasRequired(x => x.FlowerModel)
                .WithMany(x => x.FlowerWarehouseModels)
                .HasForeignKey(x => x.FlowerId);

            modelBuilder.Entity<FlowerWarehouseModel>()
               .ToTable("FlowerWarehouse")
               .HasRequired(x => x.WarehouseModel)
               .WithMany(x => x.FlowerWarehouseModels)
               .HasForeignKey(x => x.WhId);

        }
    }
}