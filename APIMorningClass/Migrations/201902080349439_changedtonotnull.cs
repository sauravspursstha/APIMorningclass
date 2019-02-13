namespace APIMorningClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedtonotnull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserInfoes", "Firstname", c => c.String(nullable: false));
            AlterColumn("dbo.UserInfoes", "Lastname", c => c.String(nullable: false));
            AlterColumn("dbo.UserInfoes", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserInfoes", "Address", c => c.String());
            AlterColumn("dbo.UserInfoes", "Lastname", c => c.String());
            AlterColumn("dbo.UserInfoes", "Firstname", c => c.String());
        }
    }
}
