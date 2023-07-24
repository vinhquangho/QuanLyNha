namespace QuanLyNha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        DislayName = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contract",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        HomeId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Home", t => t.HomeId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.HomeId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BrithDay = c.DateTime(nullable: false),
                        CMND = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Home",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ResidentialArea = c.String(),
                        Direction = c.Int(nullable: false),
                        Storey = c.Int(nullable: false),
                        Address = c.String(),
                        Status = c.Int(nullable: false),
                        StatusHome = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Area", t => t.AreaId, cascadeDelete: true)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ContactId = c.Int(nullable: false),
                        Contract_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contract", t => t.Contract_Id)
                .Index(t => t.Contract_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payment", "Contract_Id", "dbo.Contract");
            DropForeignKey("dbo.Contract", "HomeId", "dbo.Home");
            DropForeignKey("dbo.Home", "AreaId", "dbo.Area");
            DropForeignKey("dbo.Contract", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Payment", new[] { "Contract_Id" });
            DropIndex("dbo.Home", new[] { "AreaId" });
            DropIndex("dbo.Contract", new[] { "HomeId" });
            DropIndex("dbo.Contract", new[] { "CustomerId" });
            DropTable("dbo.Payment");
            DropTable("dbo.Home");
            DropTable("dbo.Customer");
            DropTable("dbo.Contract");
            DropTable("dbo.Area");
            DropTable("dbo.Account");
        }
    }
}
