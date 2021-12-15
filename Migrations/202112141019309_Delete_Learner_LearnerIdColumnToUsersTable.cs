namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Learner_LearnerIdColumnToUsersTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Learner_LearnerId", "dbo.Learners");
            DropIndex("dbo.Users", new[] { "Learner_LearnerId" });
            DropColumn("dbo.Users", "Learner_LearnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Learner_LearnerId", c => c.Int());
            CreateIndex("dbo.Users", "Learner_LearnerId");
            AddForeignKey("dbo.Users", "Learner_LearnerId", "dbo.Learners", "LearnerId");
        }
    }
}
