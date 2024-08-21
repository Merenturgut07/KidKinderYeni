namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Title", c => c.String());
            DropColumn("dbo.Teachers", "BranchId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "BranchId", c => c.Int(nullable: false));
            DropColumn("dbo.Teachers", "Title");
        }
    }
}
