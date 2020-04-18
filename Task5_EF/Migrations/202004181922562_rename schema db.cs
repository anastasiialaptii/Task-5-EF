namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameschemadb : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "FlowerSupply.Flower", newSchema: "SupplyFlowerSchema");
            MoveTable(name: "FlowerSupply.Place", newSchema: "SupplyFlowerSchema");
            MoveTable(name: "FlowerSupply.FlowerModelWarehouseModels", newSchema: "SupplyFlowerSchema");
        }
        
        public override void Down()
        {
            MoveTable(name: "SupplyFlowerSchema.FlowerModelWarehouseModels", newSchema: "FlowerSupply");
            MoveTable(name: "SupplyFlowerSchema.Place", newSchema: "FlowerSupply");
            MoveTable(name: "SupplyFlowerSchema.Flower", newSchema: "FlowerSupply");
        }
    }
}
