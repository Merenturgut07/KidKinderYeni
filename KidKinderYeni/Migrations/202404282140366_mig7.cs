namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Testimonials", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Testimonials", "Description");
        }
    }
}
