namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class daycounterweekcountercurrentday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DayCounter", c => c.String());
            AddColumn("dbo.AspNetUsers", "WeekCounter", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "CurrentDay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CurrentDay");
            DropColumn("dbo.AspNetUsers", "WeekCounter");
            DropColumn("dbo.AspNetUsers", "DayCounter");
        }
    }
}
