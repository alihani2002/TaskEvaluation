using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TaskEvaluation.Web.Models;

namespace TaskEvaluations.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<EvaluationGrade> EvaluationGrades { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Solution> Solutions { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
