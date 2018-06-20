namespace MvcGround.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fourth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Assignments", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Teachers", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Assignments", new[] { "Course_Id" });
            DropIndex("dbo.Teachers", new[] { "Course_Id" });
            CreateTable(
                "dbo.CourseAssignments",
                c => new
                    {
                        Course_Id = c.Int(nullable: false),
                        Assignment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_Id, t.Assignment_Id })
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .ForeignKey("dbo.Assignments", t => t.Assignment_Id, cascadeDelete: true)
                .Index(t => t.Course_Id)
                .Index(t => t.Assignment_Id);
            
            CreateTable(
                "dbo.TeacherCourses",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.Course_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.Course_Id);
            
            DropColumn("dbo.Assignments", "Course_Id");
            DropColumn("dbo.Teachers", "Course_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Course_Id", c => c.Int());
            AddColumn("dbo.Assignments", "Course_Id", c => c.Int());
            DropForeignKey("dbo.TeacherCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.TeacherCourses", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.CourseAssignments", "Assignment_Id", "dbo.Assignments");
            DropForeignKey("dbo.CourseAssignments", "Course_Id", "dbo.Courses");
            DropIndex("dbo.TeacherCourses", new[] { "Course_Id" });
            DropIndex("dbo.TeacherCourses", new[] { "Teacher_Id" });
            DropIndex("dbo.CourseAssignments", new[] { "Assignment_Id" });
            DropIndex("dbo.CourseAssignments", new[] { "Course_Id" });
            DropTable("dbo.TeacherCourses");
            DropTable("dbo.CourseAssignments");
            CreateIndex("dbo.Teachers", "Course_Id");
            CreateIndex("dbo.Assignments", "Course_Id");
            AddForeignKey("dbo.Teachers", "Course_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.Assignments", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
