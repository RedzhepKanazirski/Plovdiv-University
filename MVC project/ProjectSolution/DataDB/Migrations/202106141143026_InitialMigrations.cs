namespace DataDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Champions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Name = c.String(),
                        DOB = c.DateTime(),
                        Gender = c.String(),
                        AbilityID = c.Int(nullable: false),
                        WeaponID = c.Int(nullable: false),
                        ClanID = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Abilities", t => t.AbilityID, cascadeDelete: true)
                .ForeignKey("dbo.Clans", t => t.ClanID, cascadeDelete: true)
                .ForeignKey("dbo.Weapons", t => t.WeaponID, cascadeDelete: true)
                .Index(t => t.AbilityID)
                .Index(t => t.WeaponID)
                .Index(t => t.ClanID);
            
            CreateTable(
                "dbo.Clans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Dating = c.String(),
                        Symbol = c.String(),
                        Specificity = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Range = c.Int(nullable: false),
                        Description = c.String(),
                        Type = c.String(),
                        Rarity = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Champions", "WeaponID", "dbo.Weapons");
            DropForeignKey("dbo.Champions", "ClanID", "dbo.Clans");
            DropForeignKey("dbo.Champions", "AbilityID", "dbo.Abilities");
            DropIndex("dbo.Champions", new[] { "ClanID" });
            DropIndex("dbo.Champions", new[] { "WeaponID" });
            DropIndex("dbo.Champions", new[] { "AbilityID" });
            DropTable("dbo.Weapons");
            DropTable("dbo.Clans");
            DropTable("dbo.Champions");
            DropTable("dbo.Abilities");
        }
    }
}
