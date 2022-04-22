using WebApplication.Models;
namespace WebApplication.Data
{
    public class DbContext
    {
        private DbContextOptions<SchoolContext> options;

        public DbContext(DbContextOptions<SchoolContext> options)
        {
            this.options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}