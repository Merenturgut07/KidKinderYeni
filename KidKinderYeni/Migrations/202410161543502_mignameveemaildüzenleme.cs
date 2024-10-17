namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mignameveemaildüzenleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MailSubscribes", "Name_Surname", c => c.String());
            AddColumn("dbo.MailSubscribes", "E_mail", c => c.String());
            DropColumn("dbo.MailSubscribes", "NameSurname");
            DropColumn("dbo.MailSubscribes", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MailSubscribes", "Email", c => c.String());
            AddColumn("dbo.MailSubscribes", "NameSurname", c => c.String());
            DropColumn("dbo.MailSubscribes", "E_mail");
            DropColumn("dbo.MailSubscribes", "Name_Surname");
        }
    }
}
