namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_InstructorColumnToUsersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "InstructorId", c => c.Int());
            CreateIndex("dbo.Users", "InstructorId");
            AddForeignKey("dbo.Users", "InstructorId", "dbo.Instructors", "InstructorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.Users", new[] { "InstructorId" });
            DropColumn("dbo.Users", "InstructorId");
        }
    }
}
