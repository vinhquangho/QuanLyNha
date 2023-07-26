namespace QuanLyNha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contract", "AccountId", c => c.Int(nullable: false));
            AddColumn("dbo.Payment", "AccountId", c => c.Int(nullable: false));
            CreateIndex("dbo.Contract", "AccountId");
            CreateIndex("dbo.Payment", "AccountId");
            AddForeignKey("dbo.Contract", "AccountId", "dbo.Account", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Payment", "AccountId", "dbo.Account", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payment", "AccountId", "dbo.Account");
            DropForeignKey("dbo.Contract", "AccountId", "dbo.Account");
            DropIndex("dbo.Payment", new[] { "AccountId" });
            DropIndex("dbo.Contract", new[] { "AccountId" });
            DropColumn("dbo.Payment", "AccountId");
            DropColumn("dbo.Contract", "AccountId");
        }
    }
}
