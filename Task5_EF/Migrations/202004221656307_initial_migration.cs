namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "SupplyFlowerSchema.FlowerPlantation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlowerId = c.Int(nullable: false),
                        PlantationId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("SupplyFlowerSchema.Flower", t => t.FlowerId, cascadeDelete: true)
                .ForeignKey("SupplyFlowerSchema.Place", t => t.PlantationId, cascadeDelete: true)
                .Index(t => t.FlowerId)
                .Index(t => t.PlantationId);
            
            CreateTable(
                "SupplyFlowerSchema.Flower",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "SupplyFlowerSchema.FlowerSupply",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlowerId = c.Int(nullable: false),
                        SupplyId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("SupplyFlowerSchema.Flower", t => t.FlowerId, cascadeDelete: true)
                .ForeignKey("SupplyFlowerSchema.Supply", t => t.SupplyId, cascadeDelete: true)
                .Index(t => t.FlowerId)
                .Index(t => t.SupplyId);
            
            CreateTable(
                "SupplyFlowerSchema.Supply",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WarehouseId = c.Int(),
                        PlantationId = c.Int(),
                        ScheduledDate = c.DateTime(nullable: false),
                        ClosedDate = c.DateTime(nullable: false),
                        StatusId = c.Int(),
                        WarehouseModel_Id = c.Int(),
                        PlantationModel_Id = c.Int(),
                        StatusModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("SupplyFlowerSchema.Place", t => t.WarehouseModel_Id)
                .ForeignKey("SupplyFlowerSchema.Place", t => t.PlantationModel_Id)
                .ForeignKey("SupplyFlowerSchema.Status", t => t.StatusModel_Id)
                .Index(t => t.WarehouseModel_Id)
                .Index(t => t.PlantationModel_Id)
                .Index(t => t.StatusModel_Id);
            
            CreateTable(
                "SupplyFlowerSchema.FlowerWarehouseModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlowerId = c.Int(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        FlowerModel_Id = c.Int(),
                        WarehouseModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("SupplyFlowerSchema.Flower", t => t.FlowerModel_Id)
                .ForeignKey("SupplyFlowerSchema.Place", t => t.WarehouseModel_Id)
                .Index(t => t.FlowerModel_Id)
                .Index(t => t.WarehouseModel_Id);
            
            CreateTable(
                "SupplyFlowerSchema.Place",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 60),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "SupplyFlowerSchema.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("SupplyFlowerSchema.Supply", "StatusModel_Id", "SupplyFlowerSchema.Status");
            DropForeignKey("SupplyFlowerSchema.FlowerPlantation", "PlantationId", "SupplyFlowerSchema.Place");
            DropForeignKey("SupplyFlowerSchema.Supply", "PlantationModel_Id", "SupplyFlowerSchema.Place");
            DropForeignKey("SupplyFlowerSchema.FlowerPlantation", "FlowerId", "SupplyFlowerSchema.Flower");
            DropForeignKey("SupplyFlowerSchema.Supply", "WarehouseModel_Id", "SupplyFlowerSchema.Place");
            DropForeignKey("SupplyFlowerSchema.FlowerWarehouseModels", "WarehouseModel_Id", "SupplyFlowerSchema.Place");
            DropForeignKey("SupplyFlowerSchema.FlowerWarehouseModels", "FlowerModel_Id", "SupplyFlowerSchema.Flower");
            DropForeignKey("SupplyFlowerSchema.FlowerSupply", "SupplyId", "SupplyFlowerSchema.Supply");
            DropForeignKey("SupplyFlowerSchema.FlowerSupply", "FlowerId", "SupplyFlowerSchema.Flower");
            DropIndex("SupplyFlowerSchema.FlowerWarehouseModels", new[] { "WarehouseModel_Id" });
            DropIndex("SupplyFlowerSchema.FlowerWarehouseModels", new[] { "FlowerModel_Id" });
            DropIndex("SupplyFlowerSchema.Supply", new[] { "StatusModel_Id" });
            DropIndex("SupplyFlowerSchema.Supply", new[] { "PlantationModel_Id" });
            DropIndex("SupplyFlowerSchema.Supply", new[] { "WarehouseModel_Id" });
            DropIndex("SupplyFlowerSchema.FlowerSupply", new[] { "SupplyId" });
            DropIndex("SupplyFlowerSchema.FlowerSupply", new[] { "FlowerId" });
            DropIndex("SupplyFlowerSchema.FlowerPlantation", new[] { "PlantationId" });
            DropIndex("SupplyFlowerSchema.FlowerPlantation", new[] { "FlowerId" });
            DropTable("SupplyFlowerSchema.Status");
            DropTable("SupplyFlowerSchema.Place");
            DropTable("SupplyFlowerSchema.FlowerWarehouseModels");
            DropTable("SupplyFlowerSchema.Supply");
            DropTable("SupplyFlowerSchema.FlowerSupply");
            DropTable("SupplyFlowerSchema.Flower");
            DropTable("SupplyFlowerSchema.FlowerPlantation");
        }
    }
}
