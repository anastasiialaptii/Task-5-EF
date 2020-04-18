namespace Task5_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mynew : DbMigration
    {
        public override void Up()
        {
            AddColumn("FlowerSupply.Flower", "Name1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("FlowerSupply.Flower", "Name1");
        }
    }
}
