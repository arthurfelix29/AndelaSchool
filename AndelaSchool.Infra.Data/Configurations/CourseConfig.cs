using AndelaSchool.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndelaSchool.Infra.Data.Configurations
{
    public class CourseConfig : EntityConfiguration<Course>, IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            DefaultConfigs(builder, tableName: "COURSES");

            builder.Property(course => course.Name)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasData(SeedCourses());
        }

        private static IEnumerable<Course> SeedCourses()
        {
            return new List<Course>
            {
                Course.Create(new Guid("5B8433C6-9CCE-4D26-AD95-4BEA60D20D44"), "Agile in the Real World"),
                Course.Create(new Guid("50FA9720-3C13-44D4-80F7-896B0BB494E0"), "Maintaining, Monitoring and Troubleshooting Kubernetes"),
                Course.Create(new Guid("B6CA990A-B0A6-42B8-B5C6-6BB94C91D6AF"), "Introduction to Emotional Intelligence"),
                Course.Create(new Guid("5ACA2707-1CE8-46CF-A660-0686C864DC56"), "Big Data on AWS: The Big Picture")
            };
        }
    }
}