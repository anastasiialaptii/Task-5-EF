namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rebuild_full_db : DbMigration
    {
        public override void Up()
        {
            AddColumn("SupplyFlowerSchema.Supply", "WarehouseModel_Id", c => c.Int());
            AddColumn("SupplyFlowerSchema.Supply", "PlantationModel_Id", c => c.Int());
            AddColumn("SupplyFlowerSchema.Supply", "StatusModel_Id", c => c.Int());
            CreateIndex("SupplyFlowerSchema.Supply", "WarehouseModel_Id");
            CreateIndex("SupplyFlowerSchema.Supply", "PlantationModel_Id");
            CreateIndex("SupplyFlowerSchema.Supply", "StatusModel_Id");
            AddForeignKey("SupplyFlowerSchema.Supply", "WarehouseModel_Id", "SupplyFlowerSchema.Place", "Id");
            AddForeignKey("SupplyFlowerSchema.Supply", "PlantationModel_Id", "SupplyFlowerSchema.Place", "Id");
            AddForeignKey("SupplyFlowerSchema.Supply", "StatusModel_Id", "SupplyFlowerSchema.Status", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("SupplyFlowerSchema.Supply", "StatusModel_Id", "SupplyFlowerSchema.Status");
            DropForeignKey("SupplyFlowerSchema.Supply", "PlantationModel_Id", "SupplyFlowerSchema.Place");
            DropForeignKey("SupplyFlowerSchema.Supply", "WarehouseModel_Id", "SupplyFlowerSchema.Place");
            DropIndex("SupplyFlowerSchema.Supply", new[] { "StatusModel_Id" });
            DropIndex("SupplyFlowerSchema.Supply", new[] { "PlantationModel_Id" });
            DropIndex("SupplyFlowerSchema.Supply", new[] { "WarehouseModel_Id" });
            DropColumn("SupplyFlowerSchema.Supply", "StatusModel_Id");
            DropColumn("SupplyFlowerSchema.Supply", "PlantationModel_Id");
            DropColumn("SupplyFlowerSchema.Supply", "WarehouseModel_Id");
        }
    }
}
