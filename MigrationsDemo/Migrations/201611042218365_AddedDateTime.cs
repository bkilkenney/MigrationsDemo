namespace MigrationsDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Date");
        }
    }
}
