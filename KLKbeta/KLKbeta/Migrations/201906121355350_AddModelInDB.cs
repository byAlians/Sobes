namespace KLKbeta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModelInDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hour = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonnelNo = c.Int(nullable: false),
                        TypeOfEmployeeId = c.Int(nullable: false),
                        SubdivisionId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        Name = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .ForeignKey("dbo.Subdivisions", t => t.SubdivisionId, cascadeDelete: true)
                .ForeignKey("dbo.TypeOfEmployees", t => t.TypeOfEmployeeId, cascadeDelete: true)
                .Index(t => t.TypeOfEmployeeId)
                .Index(t => t.SubdivisionId)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PositionStaff = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        WorkTimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorkTimes", t => t.WorkTimeId, cascadeDelete: true)
                .Index(t => t.WorkTimeId);
            
            CreateTable(
                "dbo.WorkTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeBegin = c.DateTime(nullable: false),
                        TimeEnd = c.DateTime(nullable: false),
                        TimeWorking = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subdivisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubdivisionNumber = c.Int(nullable: false),
                        NameSubdivision = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TypeOfEmployees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StaffFacts",
                c => new
                    {
                        Staff_Id = c.Int(nullable: false),
                        Fact_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Staff_Id, t.Fact_Id })
                .ForeignKey("dbo.Staffs", t => t.Staff_Id, cascadeDelete: true)
                .ForeignKey("dbo.Facts", t => t.Fact_Id, cascadeDelete: true)
                .Index(t => t.Staff_Id)
                .Index(t => t.Fact_Id);
            
            CreateTable(
                "dbo.ScheduleStaffs",
                c => new
                    {
                        Schedule_Id = c.Int(nullable: false),
                        Staff_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Schedule_Id, t.Staff_Id })
                .ForeignKey("dbo.Schedules", t => t.Schedule_Id, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.Staff_Id, cascadeDelete: true)
                .Index(t => t.Schedule_Id)
                .Index(t => t.Staff_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "TypeOfEmployeeId", "dbo.TypeOfEmployees");
            DropForeignKey("dbo.Staffs", "SubdivisionId", "dbo.Subdivisions");
            DropForeignKey("dbo.Schedules", "WorkTimeId", "dbo.WorkTimes");
            DropForeignKey("dbo.ScheduleStaffs", "Staff_Id", "dbo.Staffs");
            DropForeignKey("dbo.ScheduleStaffs", "Schedule_Id", "dbo.Schedules");
            DropForeignKey("dbo.Staffs", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.StaffFacts", "Fact_Id", "dbo.Facts");
            DropForeignKey("dbo.StaffFacts", "Staff_Id", "dbo.Staffs");
            DropIndex("dbo.ScheduleStaffs", new[] { "Staff_Id" });
            DropIndex("dbo.ScheduleStaffs", new[] { "Schedule_Id" });
            DropIndex("dbo.StaffFacts", new[] { "Fact_Id" });
            DropIndex("dbo.StaffFacts", new[] { "Staff_Id" });
            DropIndex("dbo.Schedules", new[] { "WorkTimeId" });
            DropIndex("dbo.Staffs", new[] { "PositionId" });
            DropIndex("dbo.Staffs", new[] { "SubdivisionId" });
            DropIndex("dbo.Staffs", new[] { "TypeOfEmployeeId" });
            DropTable("dbo.ScheduleStaffs");
            DropTable("dbo.StaffFacts");
            DropTable("dbo.TypeOfEmployees");
            DropTable("dbo.Subdivisions");
            DropTable("dbo.WorkTimes");
            DropTable("dbo.Schedules");
            DropTable("dbo.Positions");
            DropTable("dbo.Staffs");
            DropTable("dbo.Facts");
        }
    }
}
