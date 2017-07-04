namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Roleshookeduptopages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DayOfWeek", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DayOfWeek");
        }
    }
}
