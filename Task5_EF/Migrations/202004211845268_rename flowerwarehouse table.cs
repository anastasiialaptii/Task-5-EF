namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameflowerwarehousetable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "SupplyFlowerSchema.FlowerWarehouse", name: "WhId", newName: "WarehouseId");
            RenameIndex(table: "SupplyFlowerSchema.FlowerWarehouse", name: "IX_WhId", newName: "IX_WarehouseId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "SupplyFlowerSchema.FlowerWarehouse", name: "IX_WarehouseId", newName: "IX_WhId");
            RenameColumn(table: "SupplyFlowerSchema.FlowerWarehouse", name: "WarehouseId", newName: "WhId");
        }
    }
}
