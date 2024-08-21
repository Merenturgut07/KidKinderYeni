namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifications", "Description");
        }
    }
}
