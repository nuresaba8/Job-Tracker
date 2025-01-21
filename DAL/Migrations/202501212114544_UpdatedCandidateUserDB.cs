namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCandidateUserDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "UseCanId", "dbo.Candidates");
            DropIndex("dbo.Users", new[] { "UseCanId" });
            AddColumn("dbo.Candidates", "UseCanId", c => c.Int(nullable: false));
            CreateIndex("dbo.Candidates", "UseCanId");
            AddForeignKey("dbo.Candidates", "UseCanId", "dbo.Users", "UserId", cascadeDelete: true);
            DropColumn("dbo.Users", "UseCanId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UseCanId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Candidates", "UseCanId", "dbo.Users");
            DropIndex("dbo.Candidates", new[] { "UseCanId" });
            DropColumn("dbo.Candidates", "UseCanId");
            CreateIndex("dbo.Users", "UseCanId");
            AddForeignKey("dbo.Users", "UseCanId", "dbo.Candidates", "CandidateId", cascadeDelete: true);
        }
    }
}
