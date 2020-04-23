using System.Data.Entity;
using Task5_EF.Models;

namespace Task5_EF.DbConfiguration
{
    public class SupplyTableConstraint
    {
        public void SupplyTable(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SupplyModel>()
                .ToTable("Supply")
                .Property(x => x.PlantationId)
                .IsOptional();

            modelBuilder.Entity<SupplyModel>()
                 .Property(x => x.WarehouseId)
                 .IsOptional();

            modelBuilder.Entity<SupplyModel>()
                 .Property(x => x.StatusId)
                 .IsOptional();

            modelBuilder.Entity<SupplyModel>()
                 .Property(x =>x.ScheduledDate)
                 .IsOptional();

            modelBuilder.Entity<SupplyModel>()
                 .Property(x => x.ClosedDate)
                 .IsOptional();
        }
    }
}