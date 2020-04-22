using System.Data.Entity;
using Task5_EF.Models;

namespace Task5_EF.DbConfiguration
{
    public class FlowerSupplyTableConstraint
    {
        public void FlowerSupplyTable(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlowerSupplyModel>()
                .ToTable("FlowerSupply")
                .HasRequired(x => x.FlowerModel)
                .WithMany(x => x.FlowerSupplyModels)
                .HasForeignKey(x => x.FlowerId);

            modelBuilder.Entity<FlowerSupplyModel>()
               .ToTable("FlowerSupply")
               .HasRequired(x => x.SupplyModel)
               .WithMany(x => x.FlowerSupplyModels)
               .HasForeignKey(x => x.SupplyId);
        }
    }
}