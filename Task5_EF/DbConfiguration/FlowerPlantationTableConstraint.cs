using System.Data.Entity;
using Task5_EF.Models;

namespace Task5_EF.DbConfiguration
{
    public class FlowerPlantationTableConstraint
    {
        public void FlowerPlantationTable(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlowerPlantationModel>()
                .ToTable("FlowerPlantation")
                .HasRequired(x => x.FlowerModel)
                .WithMany(x => x.FlowerPlantationModels)
                .HasForeignKey(x => x.FlowerId);

            modelBuilder.Entity<FlowerPlantationModel>()
               .ToTable("FlowerPlantation")
               .HasRequired(x => x.PlantationModel)
               .WithMany(x => x.FlowerPlantationModels)
               .HasForeignKey(x => x.PlantationId);
        }
    }
}