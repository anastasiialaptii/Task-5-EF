using System.Data.Entity;
using Task5_EF.DbManager;
using Task5_EF.Models;

namespace Task5_EF
{
    public class SupplyContext : DbContext
    {
        public DbSet<FlowerModel> Flowers { get; set; }

        public DbSet<PlaceModel> Places { get; set; }

        //public DbSet<PlantationModel> Plantations { get; set; }

        //public DbSet<StatusModel> Statuses { get; set; }


        FlowerTableConstraint flowerTableConstraint = new FlowerTableConstraint();
        PlaceTableConstraint placeTableConstraint = new PlaceTableConstraint();
        SchemaConstraint schemaTableConstraint = new SchemaConstraint();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            schemaTableConstraint.SetSchemaConstraint(modelBuilder);

            flowerTableConstraint.FlowerTable(modelBuilder);
            placeTableConstraint.PlaceTable(modelBuilder);
        }
    }
}