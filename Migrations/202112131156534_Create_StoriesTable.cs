namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_StoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stories",
                c => new
                    {
                        StoryId = c.Int(nullable: false, identity: true),
                        StoryName = c.String(),
                        Context = c.String(),
                        Theme = c.String(),
                        Author = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.StoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stories");
        }
    }
}
