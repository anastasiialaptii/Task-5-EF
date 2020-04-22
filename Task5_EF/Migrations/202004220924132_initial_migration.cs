namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "SupplyFlowerSchema.Flower",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "SupplyFlowerSchema.FlowerWarehouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlowerId = c.Int(nullable: false),
                        WarehouseId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("SupplyFlowerSchema.Flower", t => t.FlowerId, cascadeDelete: true)
                .ForeignKey("SupplyFlowerSchema.Place", t => t.WarehouseId, cascadeDelete: true)
                .Index(t => t.FlowerId)
                .Index(t => t.WarehouseId);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("SupplyFlowerSchema.FlowerWarehouse", "WarehouseId", "SupplyFlowerSchema.Place");
            DropForeignKey("SupplyFlowerSchema.FlowerWarehouse", "FlowerId", "SupplyFlowerSchema.Flower");
            DropIndex("SupplyFlowerSchema.FlowerWarehouse", new[] { "WarehouseId" });
            DropIndex("SupplyFlowerSchema.FlowerWarehouse", new[] { "FlowerId" });
            DropTable("SupplyFlowerSchema.Place");
            DropTable("SupplyFlowerSchema.FlowerWarehouse");
            DropTable("SupplyFlowerSchema.Flower");
        }
    }
}
