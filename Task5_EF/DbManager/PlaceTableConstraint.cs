using System.Data.Entity;
using Task5_EF.Models;

namespace Task5_EF.DbManager
{
    public class PlaceTableConstraint
    {
        public void PlaceTable(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaceModel>()
                .ToTable("Place")
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<PlaceModel>()
                .Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}