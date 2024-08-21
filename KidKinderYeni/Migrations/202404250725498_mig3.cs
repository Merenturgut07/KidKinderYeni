namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookASeatLists",
                c => new
                    {
                        BookASeatListId = c.Int(nullable: false, identity: true),
                        List = c.String(),
                    })
                .PrimaryKey(t => t.BookASeatListId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BookASeatLists");
        }
    }
}
