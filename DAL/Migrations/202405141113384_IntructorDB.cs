namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntructorDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        ShortDescription = c.String(maxLength: 500),
                        InstructorName = c.String(nullable: false, maxLength: 100),
                        Price = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        VideoPath = c.String(nullable: false, maxLength: 200),
                        UploadTime = c.DateTime(nullable: false),
                        ApproveOrNot = c.Boolean(nullable: false),
                        SellCount = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        DateOfBuying = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        Phone = c.String(maxLength: 15),
                        InstitutionName = c.String(maxLength: 100),
                        Address = c.String(maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false),
                        Active = c.Int(nullable: false),
                        DateOfAccount = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 100),
                        email = c.String(nullable: false),
                        gender = c.String(nullable: false),
                        profession = c.String(nullable: false, maxLength: 100),
                        universityName = c.String(nullable: false, maxLength: 100),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Orders", "CourseId", "dbo.Courses");
            DropIndex("dbo.Orders", new[] { "CourseId" });
            DropIndex("dbo.Orders", new[] { "StudentId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Orders");
            DropTable("dbo.Courses");
        }
    }
}
