namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "BranchId", c => c.Int(nullable: true));
            CreateIndex("dbo.Teachers", "BranchId");
            AddForeignKey("dbo.Teachers", "BranchId", "dbo.Branches", "BranchId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "BranchId", "dbo.Branches");
            DropIndex("dbo.Teachers", new[] { "BranchId" });
            DropColumn("dbo.Teachers", "BranchId");
        }
    }
}
