using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EF6.Models;

namespace EF6
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolDB")
        {
            Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>());
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
