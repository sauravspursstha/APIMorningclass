namespace APIMorningClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phonenumberdatatypechange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserInfoes", "Phonenumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserInfoes", "Phonenumber", c => c.String());
        }
    }
}
