namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Title", c => c.String());
            DropTable("dbo.Branches");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BranchId);
            
            DropColumn("dbo.Teachers", "Title");
        }
    }
}
