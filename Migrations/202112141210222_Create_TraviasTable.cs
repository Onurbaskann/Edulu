namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_TraviasTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Travias",
                c => new
                    {
                        TraviaId = c.Int(nullable: false, identity: true),
                        Context = c.String(),
                        Image = c.String(),
                        Message = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.TraviaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Travias");
        }
    }
}
