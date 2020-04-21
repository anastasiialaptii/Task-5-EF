using System.Data.Entity;
using Task5_EF.DbManager;
using Task5_EF.Models;

namespace Task5_EF
{
    public class SupplyContext : DbContext
    {
        public DbSet<FlowerModel> Flowers { get; set; }

        public DbSet<PlaceModel> Places { get; set; }

        public DbSet<FlowerWarehouseModel> FlowerWarehouses { get; set; }

        FlowerTableConstraint flowerTableConstraint = new FlowerTableConstraint();
        PlaceTableConstraint placeTableConstraint = new PlaceTableConstraint();
        SchemaConstraint schemaTableConstraint = new SchemaConstraint();
        FlowerWarehouseTableConstraint flowerWarehouseTableConstraint = new FlowerWarehouseTableConstraint();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SupplyContext>(null);
            schemaTableConstraint.SetSchemaConstraint(modelBuilder);

            flowerTableConstraint.FlowerTable(modelBuilder);
            placeTableConstraint.PlaceTable(modelBuilder);
            flowerWarehouseTableConstraint.FlowerWarehouseTable(modelBuilder);
        }

        public System.Data.Entity.DbSet<Task5_EF.Models.PlantationModel> PlaceModels { get; set; }
    }
}