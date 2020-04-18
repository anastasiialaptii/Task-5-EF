namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwerty : DbMigration
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
                "FlowerSupply.Warehouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "FlowerSupply.StatusModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
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
                .ForeignKey("FlowerSupply.Warehouse", t => t.WarehouseModel_Id, cascadeDelete: true)
                .Index(t => t.FlowerModel_Id)
                .Index(t => t.WarehouseModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("FlowerSupply.FlowerModelWarehouseModels", "WarehouseModel_Id", "FlowerSupply.Warehouse");
            DropForeignKey("FlowerSupply.FlowerModelWarehouseModels", "FlowerModel_Id", "FlowerSupply.Flower");
            DropIndex("FlowerSupply.FlowerModelWarehouseModels", new[] { "WarehouseModel_Id" });
            DropIndex("FlowerSupply.FlowerModelWarehouseModels", new[] { "FlowerModel_Id" });
            DropTable("FlowerSupply.FlowerModelWarehouseModels");
            DropTable("FlowerSupply.StatusModels");
            DropTable("FlowerSupply.Warehouse");
            DropTable("FlowerSupply.Flower");
        }
    }
}
