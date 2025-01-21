namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitJobDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AvailableJobs",
                c => new
                    {
                        AvaibleJobId = c.Int(nullable: false, identity: true),
                        Deadline = c.DateTime(nullable: false),
                        Company = c.String(),
                        Position = c.String(),
                        Description = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.AvaibleJobId);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateId = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        CandidatePassword = c.String(),
                        CandidateEmail = c.String(),
                    })
                .PrimaryKey(t => t.CandidateId);
            
            CreateTable(
                "dbo.JobApplications",
                c => new
                    {
                        JobId = c.Int(nullable: false, identity: true),
                        AppliedDate = c.DateTime(nullable: false),
                        Deadling = c.DateTime(nullable: false),
                        Company = c.String(),
                        Position = c.String(),
                        Description = c.String(),
                        Status = c.String(),
                        Notes = c.String(),
                        JobCanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobId)
                .ForeignKey("dbo.Candidates", t => t.JobCanId, cascadeDelete: true)
                .Index(t => t.JobCanId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserEmail = c.String(),
                        UserPassword = c.String(),
                        UserRole = c.Int(nullable: false),
                        UseCanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Candidates", t => t.UseCanId, cascadeDelete: true)
                .Index(t => t.UseCanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UseCanId", "dbo.Candidates");
            DropForeignKey("dbo.JobApplications", "JobCanId", "dbo.Candidates");
            DropIndex("dbo.Users", new[] { "UseCanId" });
            DropIndex("dbo.JobApplications", new[] { "JobCanId" });
            DropTable("dbo.Users");
            DropTable("dbo.JobApplications");
            DropTable("dbo.Candidates");
            DropTable("dbo.AvailableJobs");
        }
    }
}
