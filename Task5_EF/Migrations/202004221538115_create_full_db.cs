namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_full_db : DbMigration
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
            DropForeignKey("SupplyFlowerSchema.FlowerPlantation", "PlantationId", "SupplyFlowerSchema.Place");
            DropForeignKey("SupplyFlowerSchema.FlowerPlantation", "FlowerId", "SupplyFlowerSchema.Flower");
            DropForeignKey("SupplyFlowerSchema.FlowerSupply", "SupplyId", "SupplyFlowerSchema.Supply");
            DropForeignKey("SupplyFlowerSchema.FlowerSupply", "FlowerId", "SupplyFlowerSchema.Flower");
            DropIndex("SupplyFlowerSchema.FlowerSupply", new[] { "SupplyId" });
            DropIndex("SupplyFlowerSchema.FlowerSupply", new[] { "FlowerId" });
            DropIndex("SupplyFlowerSchema.FlowerPlantation", new[] { "PlantationId" });
            DropIndex("SupplyFlowerSchema.FlowerPlantation", new[] { "FlowerId" });
            DropTable("SupplyFlowerSchema.Status");
            DropTable("SupplyFlowerSchema.Supply");
            DropTable("SupplyFlowerSchema.FlowerSupply");
            DropTable("SupplyFlowerSchema.FlowerPlantation");
        }
    }
}
