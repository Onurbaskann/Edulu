using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Edulu3.Models.Entity
{
    public class EduluContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Travia> Travias { get; set; }
        public EduluContext() : base("EduluThesisDbConStr")
        {

        }
    }
}