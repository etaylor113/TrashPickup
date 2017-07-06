namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedAmountOwed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AmountOwed", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AmountOwed");
        }
    }
}
