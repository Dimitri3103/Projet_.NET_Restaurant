namespace Restaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            DropColumn("dbo.AspNetUsers", "UniversityName");
            DropColumn("dbo.AspNetUsers", "AdminName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "AdminName", c => c.String());
            AddColumn("dbo.AspNetUsers", "UniversityName", c => c.String());
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
