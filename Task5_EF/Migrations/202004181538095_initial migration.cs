namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "FlowerSupply.Flower",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "FlowerSupply.Place",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 60),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "FlowerSupply.FlowerModelWarehouseModels",
                c => new
                    {
                        FlowerModel_Id = c.Int(nullable: false),
                        WarehouseModel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FlowerModel_Id, t.WarehouseModel_Id })
                .ForeignKey("FlowerSupply.Flower", t => t.FlowerModel_Id, cascadeDelete: true)
                .ForeignKey("FlowerSupply.Place", t => t.WarehouseModel_Id, cascadeDelete: true)
                .Index(t => t.FlowerModel_Id)
                .Index(t => t.WarehouseModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("FlowerSupply.FlowerModelWarehouseModels", "WarehouseModel_Id", "FlowerSupply.Place");
            DropForeignKey("FlowerSupply.FlowerModelWarehouseModels", "FlowerModel_Id", "FlowerSupply.Flower");
            DropIndex("FlowerSupply.FlowerModelWarehouseModels", new[] { "WarehouseModel_Id" });
            DropIndex("FlowerSupply.FlowerModelWarehouseModels", new[] { "FlowerModel_Id" });
            DropTable("FlowerSupply.FlowerModelWarehouseModels");
            DropTable("FlowerSupply.Place");
            DropTable("FlowerSupply.Flower");
        }
    }
}
