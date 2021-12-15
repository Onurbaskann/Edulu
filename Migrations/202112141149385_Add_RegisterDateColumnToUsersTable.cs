namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_RegisterDateColumnToUsersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RegisterDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RegisterDate");
        }
    }
}
