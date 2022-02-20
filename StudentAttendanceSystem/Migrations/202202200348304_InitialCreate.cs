namespace StudentAttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attends",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DailyAttend_ID = c.Int(),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DailyAttends", t => t.DailyAttend_ID)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .Index(t => t.DailyAttend_ID)
                .Index(t => t.Student_ID);
            
            CreateTable(
                "dbo.DailyAttends",
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
                        ID = c.Int(nullable: false, identity: true),
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
                        Enrollment_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Enrollments", t => t.Enrollment_ID)
                .Index(t => t.Enrollment_ID);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Track = c.String(),
                        Quarter = c.String(),
                        Branch = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Enrollment_ID", "dbo.Enrollments");
            DropForeignKey("dbo.Attends", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Attends", "DailyAttend_ID", "dbo.DailyAttends");
            DropIndex("dbo.Students", new[] { "Enrollment_ID" });
            DropIndex("dbo.Attends", new[] { "Student_ID" });
            DropIndex("dbo.Attends", new[] { "DailyAttend_ID" });
            DropTable("dbo.Enrollments");
            DropTable("dbo.Students");
            DropTable("dbo.DailyAttends");
            DropTable("dbo.Attends");
        }
    }
}
