using System.Data.Entity;
using Task5_EF.Models;

namespace Task5_EF.DbManager
{
    public class FlowerTableConstraint
    {
        public void FlowerTable(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlowerModel>()
                .ToTable("Flower")
                .Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<FlowerModel>()
                .HasMany(w => w.Warehouses)
                .WithMany(f => f.Flowers);
        }
    }
}