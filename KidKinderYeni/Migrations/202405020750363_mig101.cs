﻿namespace KidKinderYeni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig101 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teachers", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Title", c => c.String());
        }
    }
}
