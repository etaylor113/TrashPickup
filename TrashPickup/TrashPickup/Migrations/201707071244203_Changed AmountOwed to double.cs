namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAmountOwedtodouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "AmountOwed", c => c.Double(nullable: false));
            AlterColumn("dbo.AspNetUsers", "AmountDaysOwed", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "AmountDaysOwed", c => c.String());
            AlterColumn("dbo.AspNetUsers", "AmountOwed", c => c.String());
        }
    }
}
