using AndelaSchool.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AndelaSchool.Infra.Data.Contexts
{
    public sealed class AndelaSchoolContext : DbContext
    {
        public AndelaSchoolContext(DbContextOptions<AndelaSchoolContext> options) : base(options)
        { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}