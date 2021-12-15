namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_LearnersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Learners",
                c => new
                    {
                        LearnerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.LearnerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Learners");
        }
    }
}
