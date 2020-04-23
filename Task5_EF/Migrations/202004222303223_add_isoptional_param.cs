namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_isoptional_param : DbMigration
    {
        public override void Up()
        {
            AlterColumn("SupplyFlowerSchema.Supply", "ScheduledDate", c => c.DateTime());
            AlterColumn("SupplyFlowerSchema.Supply", "ClosedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("SupplyFlowerSchema.Supply", "ClosedDate", c => c.DateTime(nullable: false));
            AlterColumn("SupplyFlowerSchema.Supply", "ScheduledDate", c => c.DateTime(nullable: false));
        }
    }
}
