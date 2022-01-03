namespace Edulu3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Instructor_InstructorId", "dbo.Instructors");
            DropForeignKey("dbo.Users", "Learner_LearnerId", "dbo.Learners");
            DropIndex("dbo.Users", new[] { "Instructor_InstructorId" });
            DropIndex("dbo.Users", new[] { "Learner_LearnerId" });
            DropColumn("dbo.Users", "Instructor_InstructorId");
            DropColumn("dbo.Users", "Learner_LearnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Learner_LearnerId", c => c.Int());
            AddColumn("dbo.Users", "Instructor_InstructorId", c => c.Int());
            CreateIndex("dbo.Users", "Learner_LearnerId");
            CreateIndex("dbo.Users", "Instructor_InstructorId");
            AddForeignKey("dbo.Users", "Learner_LearnerId", "dbo.Learners", "LearnerId");
            AddForeignKey("dbo.Users", "Instructor_InstructorId", "dbo.Instructors", "InstructorId");
        }
    }
}
