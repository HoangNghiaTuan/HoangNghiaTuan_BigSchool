namespace HoangNghiaTuan_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        LecturerID = c.String(nullable: false),
                        Place = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                        Leecturer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Leecturer_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.Leecturer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Leecturer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Leecturer_Id" });
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
