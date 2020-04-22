using System.Data.Entity;
using Task5_EF.Models;

namespace Task5_EF.DbManager
{
    public class FlowerWarehouseTableConstraint
    {
        public void FlowerWarehouseTable(DbModelBuilder modelBuilder)
        {
           /* modelBuilder.Entity<FlowerWarehouseModel>()
                .ToTable("FlowerWarehouse")
                .HasOptional(x => x.FlowerModel)
                .WithMany(x => x.FlowerWarehouseModels)
                .HasForeignKey(x => x.FlowerId);

            modelBuilder.Entity<FlowerWarehouseModel>()
               .ToTable("FlowerWarehouse")
               .HasOptional(x => x.WarehouseModel)
               .WithMany(x => x.FlowerWarehouseModels)
               .HasForeignKey(x => x.WarehouseId);*/
        }
    }
}