namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookHeaders",
                c => new
                    {
                        BookHeaderId = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.BookHeaderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookHeaders");
        }
    }
}
