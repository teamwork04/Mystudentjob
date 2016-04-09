namespace Mystudentjob.ie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inheritance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
            AddColumn("dbo.AspNetUsers", "IndustryType", c => c.String());
            AddColumn("dbo.AspNetUsers", "CompanyName", c => c.String());
            AddColumn("dbo.AspNetUsers", "ContactPerson", c => c.String());
            AddColumn("dbo.AspNetUsers", "location", c => c.String());
            AddColumn("dbo.AspNetUsers", "Qualification", c => c.String());
            AddColumn("dbo.AspNetUsers", "ProfessionalQualification", c => c.String());
            AddColumn("dbo.AspNetUsers", "Experience", c => c.String());
            AddColumn("dbo.AspNetUsers", "Skills", c => c.String());
            AddColumn("dbo.AspNetUsers", "Language", c => c.String());
            AddColumn("dbo.AspNetUsers", "ProfilePicPath", c => c.String());
            AddColumn("dbo.AspNetUsers", "CVPath", c => c.String());
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Discriminator");
            DropColumn("dbo.AspNetUsers", "CVPath");
            DropColumn("dbo.AspNetUsers", "ProfilePicPath");
            DropColumn("dbo.AspNetUsers", "Language");
            DropColumn("dbo.AspNetUsers", "Skills");
            DropColumn("dbo.AspNetUsers", "Experience");
            DropColumn("dbo.AspNetUsers", "ProfessionalQualification");
            DropColumn("dbo.AspNetUsers", "Qualification");
            DropColumn("dbo.AspNetUsers", "location");
            DropColumn("dbo.AspNetUsers", "ContactPerson");
            DropColumn("dbo.AspNetUsers", "CompanyName");
            DropColumn("dbo.AspNetUsers", "IndustryType");
            DropColumn("dbo.AspNetUsers", "Address");
        }
    }
}
