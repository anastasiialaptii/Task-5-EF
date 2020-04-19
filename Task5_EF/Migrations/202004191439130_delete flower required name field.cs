namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteflowerrequirednamefield : DbMigration
    {
        public override void Up()
        {
            AlterColumn("SupplyFlowerSchema.Flower", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("SupplyFlowerSchema.Flower", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
