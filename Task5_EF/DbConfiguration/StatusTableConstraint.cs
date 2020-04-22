using System.Data.Entity;
using Task5_EF.Models;

namespace Task5_EF.DbConfiguration
{
    public class StatusTableConstraint
    {
        public void StatusTable(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusModel>()
                .ToTable("Status")
                .Property(x => x.Name)
                .HasMaxLength(40);
        }
    }
}