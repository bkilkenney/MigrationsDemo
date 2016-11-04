namespace MigrationsDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateTime1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "DateCreated");
        }
    }
}
