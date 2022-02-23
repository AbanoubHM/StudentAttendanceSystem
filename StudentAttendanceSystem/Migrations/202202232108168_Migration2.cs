namespace StudentAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attends",
                c => new
                    {
                        AttendID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        DailyAttendID = c.Int(nullable: false),
                        Presence = c.Boolean(nullable: false),
                        Excuse = c.String(),
                    })
                .PrimaryKey(t => t.AttendID)
                .ForeignKey("dbo.DailyAttends", t => t.DailyAttendID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.DailyAttendID);
            
            CreateTable(
                "dbo.DailyAttends",
                c => new
                    {
                        DailyAttendID = c.Int(nullable: false, identity: true),
                        ADate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.DailyAttendID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NameAR = c.String(),
                        EnrollmentID = c.Int(nullable: false),
                        Gender = c.String(),
                        NID = c.String(),
                        City = c.String(),
                        Address = c.String(),
                        Moblie = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        University = c.String(),
                        Faculty = c.String(),
                        Specialization = c.String(),
                        GradYear = c.Int(nullable: false),
                        Grade = c.String(),
                        MilitaryState = c.String(),
                        MaterialState = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Enrollments", t => t.EnrollmentID, cascadeDelete: true)
                .Index(t => t.EnrollmentID);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        Branch = c.String(),
                        Quarter = c.String(),
                        Track = c.String(),
                    })
                .PrimaryKey(t => t.EnrollmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attends", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "EnrollmentID", "dbo.Enrollments");
            DropForeignKey("dbo.Attends", "DailyAttendID", "dbo.DailyAttends");
            DropIndex("dbo.Students", new[] { "EnrollmentID" });
            DropIndex("dbo.Attends", new[] { "DailyAttendID" });
            DropIndex("dbo.Attends", new[] { "StudentID" });
            DropTable("dbo.Enrollments");
            DropTable("dbo.Students");
            DropTable("dbo.DailyAttends");
            DropTable("dbo.Attends");
        }
    }
}
