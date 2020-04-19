namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
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
                        FlowerId = c.Int(nullable: false),
                        WhId = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FlowerId, t.WhId })
                .ForeignKey("SupplyFlowerSchema.Flower", t => t.FlowerId, cascadeDelete: true)
                .ForeignKey("SupplyFlowerSchema.Place", t => t.WhId, cascadeDelete: true)
                .Index(t => t.FlowerId)
                .Index(t => t.WhId);
            
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
            DropForeignKey("SupplyFlowerSchema.FlowerWarehouse", "WhId", "SupplyFlowerSchema.Place");
            DropForeignKey("SupplyFlowerSchema.FlowerWarehouse", "FlowerId", "SupplyFlowerSchema.Flower");
            DropIndex("SupplyFlowerSchema.FlowerWarehouse", new[] { "WhId" });
            DropIndex("SupplyFlowerSchema.FlowerWarehouse", new[] { "FlowerId" });
            DropTable("SupplyFlowerSchema.Place");
            DropTable("SupplyFlowerSchema.FlowerWarehouse");
            DropTable("SupplyFlowerSchema.Flower");
        }
    }
}
