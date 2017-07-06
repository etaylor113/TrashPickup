namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAmountDaysOwed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AmountDaysOwed", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AmountDaysOwed");
        }
    }
}
