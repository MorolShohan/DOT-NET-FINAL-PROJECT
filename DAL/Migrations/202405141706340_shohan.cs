namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shohan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comment = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CommentedBy = c.String(nullable: false),
                        PostId = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .ForeignKey("dbo.StudentPosts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.StudentPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
                        Approve = c.Int(nullable: false),
                        PostedBy = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.PostedBy, cascadeDelete: true)
                .Index(t => t.PostedBy);
            
            CreateTable(
                "dbo.StudentMgs",
                c => new
                    {
                        MgsId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        Message = c.String(nullable: false),
                        Reply = c.String(),
                        DateOfMgsReply = c.DateTime(),
                    })
                .PrimaryKey(t => t.MgsId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentMgs", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentMgs", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentComments", "PostId", "dbo.StudentPosts");
            DropForeignKey("dbo.StudentPosts", "PostedBy", "dbo.Students");
            DropForeignKey("dbo.StudentComments", "Student_Id", "dbo.Students");
            DropIndex("dbo.StudentMgs", new[] { "TeacherId" });
            DropIndex("dbo.StudentMgs", new[] { "StudentId" });
            DropIndex("dbo.StudentPosts", new[] { "PostedBy" });
            DropIndex("dbo.StudentComments", new[] { "Student_Id" });
            DropIndex("dbo.StudentComments", new[] { "PostId" });
            DropTable("dbo.StudentMgs");
            DropTable("dbo.StudentPosts");
            DropTable("dbo.StudentComments");
        }
    }
}
