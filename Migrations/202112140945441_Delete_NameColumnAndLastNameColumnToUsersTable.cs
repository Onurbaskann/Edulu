namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_NameColumnAndLastNameColumnToUsersTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "LastName", c => c.String());
            AddColumn("dbo.Users", "Name", c => c.String());
        }
    }
}
