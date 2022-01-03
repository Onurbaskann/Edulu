namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Rol");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Rol", c => c.String());
        }
    }
}
