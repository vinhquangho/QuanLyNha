namespace QuanLyNha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payment", "CreationTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payment", "CreationTime");
        }
    }
}
