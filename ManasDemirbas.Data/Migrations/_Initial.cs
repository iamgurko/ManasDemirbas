namespace ManasDemirbas.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FixtureCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fixtures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Serial = c.String(),
                        VendorId = c.Int(nullable: false),
                        EmployeeId = c.Int(),
                        DateAssigned = c.DateTime(),
                        AssetCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FixtureCategories", t => t.AssetCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.Vendors", t => t.VendorId, cascadeDelete: true)
                .Index(t => t.VendorId)
                .Index(t => t.EmployeeId)
                .Index(t => t.AssetCategoryId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        DeskNumber = c.String(),
                        PhoneNumber = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fixtures", "VendorId", "dbo.Vendors");
            DropForeignKey("dbo.Fixtures", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Fixtures", "FixtureCategoryId", "dbo.FixtureCategories");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Fixtures", new[] { "FixtureCategoryId" });
            DropIndex("dbo.Fixtures", new[] { "EmployeeId" });
            DropIndex("dbo.Fixtures", new[] { "VendorId" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
            DropTable("dbo.Fixtures");
            DropTable("dbo.FixtureCategories");
        }
    }
}
