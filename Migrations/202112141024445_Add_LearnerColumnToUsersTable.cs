namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_LearnerColumnToUsersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LearnerId", c => c.Int());
            CreateIndex("dbo.Users", "LearnerId");
            AddForeignKey("dbo.Users", "LearnerId", "dbo.Learners", "LearnerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Learner_LearnerId", "dbo.Learners");
            DropIndex("dbo.Users", new[] { "Learner_LearnerId" });
            DropColumn("dbo.Users", "Learner_LearnerId");
        }
    }
}
