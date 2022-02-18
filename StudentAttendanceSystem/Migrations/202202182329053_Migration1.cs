namespace StudentAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ADate = c.DateTime(nullable: false),
                        Presence = c.Boolean(nullable: false),
                        Excuse = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NameAR = c.String(),
                        NID = c.Int(nullable: false),
                        City = c.String(),
                        Address = c.String(),
                        Moblie = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        University = c.String(),
                        Faculty = c.String(),
                        Specialization = c.String(),
                        GradYear = c.DateTime(nullable: false),
                        Grade = c.String(),
                        MilitaryState = c.String(),
                        MaterialState = c.String(),
                        Notes = c.String(),
                        TrackInfo_ID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.TrackInfoes", t => t.TrackInfo_ID)
                .Index(t => t.TrackInfo_ID);
            
            CreateTable(
                "dbo.TrackInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Track = c.String(),
                        Quarter = c.String(),
                        Branch = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StudentAttendances",
                c => new
                    {
                        Student_StudentID = c.Int(nullable: false),
                        Attendance_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_StudentID, t.Attendance_ID })
                .ForeignKey("dbo.Students", t => t.Student_StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Attendances", t => t.Attendance_ID, cascadeDelete: true)
                .Index(t => t.Student_StudentID)
                .Index(t => t.Attendance_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "TrackInfo_ID", "dbo.TrackInfoes");
            DropForeignKey("dbo.StudentAttendances", "Attendance_ID", "dbo.Attendances");
            DropForeignKey("dbo.StudentAttendances", "Student_StudentID", "dbo.Students");
            DropIndex("dbo.StudentAttendances", new[] { "Attendance_ID" });
            DropIndex("dbo.StudentAttendances", new[] { "Student_StudentID" });
            DropIndex("dbo.Students", new[] { "TrackInfo_ID" });
            DropTable("dbo.StudentAttendances");
            DropTable("dbo.TrackInfoes");
            DropTable("dbo.Students");
            DropTable("dbo.Attendances");
        }
    }
}
