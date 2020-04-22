using System.Data.Entity;
using Task5_EF.DbConfiguration;
using Task5_EF.DbManager;
using Task5_EF.Models;

namespace Task5_EF
{
    public class SupplyContext : DbContext
    {
        public DbSet<FlowerModel> Flowers { get; set; }

        public DbSet<PlaceModel> Places { get; set; }

        public DbSet<FlowerWarehouseModel> FlowerWarehouses { get; set; }

        public DbSet<FlowerPlantationModel> FlowerPlantations { get; set; }

        public DbSet<FlowerSupplyModel> FlowerSupplies { get; set; }

        public DbSet<SupplyModel> Supplies { get; set; }
        
        public DbSet<StatusModel> Statuses { get; set; }

        SchemaConstraint schemaTableConstraint = new SchemaConstraint();

        FlowerTableConstraint flowerTableConstraint = new FlowerTableConstraint();
        PlaceTableConstraint placeTableConstraint = new PlaceTableConstraint();
        SupplyTableConstraint supplyTableConstraint = new SupplyTableConstraint();
        StatusTableConstraint statusTableConstraint = new StatusTableConstraint();

        FlowerPlantationTableConstraint flowerPlantationTableConstraint = new FlowerPlantationTableConstraint();
        FlowerWarehouseTableConstraint flowerWarehouseTableConstraint = new FlowerWarehouseTableConstraint();
        FlowerSupplyTableConstraint flowerSupplyTableConstraint = new FlowerSupplyTableConstraint();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SupplyContext>(null);
            schemaTableConstraint.SetSchemaConstraint(modelBuilder);

            flowerTableConstraint.FlowerTable(modelBuilder);
            placeTableConstraint.PlaceTable(modelBuilder);
            supplyTableConstraint.SupplyTable(modelBuilder);
            statusTableConstraint.StatusTable(modelBuilder);

            flowerPlantationTableConstraint.FlowerPlantationTable(modelBuilder);
            flowerWarehouseTableConstraint.FlowerWarehouseTable(modelBuilder);
            flowerSupplyTableConstraint.FlowerSupplyTable(modelBuilder);
        }
    }
}