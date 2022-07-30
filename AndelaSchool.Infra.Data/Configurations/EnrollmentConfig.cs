using AndelaSchool.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndelaSchool.Infra.Data.Configurations
{
    public class EnrollmentConfig : EntityConfiguration<Enrollment>, IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            DefaultConfigs(builder, tableName: "ENROLLMENTS");

            builder
                .HasOne(enrollment => enrollment.Student)
                .WithMany(student => student.Enrollments)
                .HasForeignKey(enrollment => enrollment.StudentId)
                .IsRequired();

            builder
                .HasOne(enrollment => enrollment.Course)
                .WithMany(course => course.Enrollments)
                .HasForeignKey(enrollment => enrollment.CourseId)
                .IsRequired();

            builder.HasData(SeedEnrollments());
        }

        private static IEnumerable<Enrollment> SeedEnrollments()
        {
            return new List<Enrollment>
            {
                Enrollment.Create(new Guid("B8A2A341-9CE7-4F76-B8D0-58C20E1330FC"), new Guid("9A73266E-AA47-4163-98B4-61DEE6841AB5"), new Guid("5B8433C6-9CCE-4D26-AD95-4BEA60D20D44")),
                Enrollment.Create(new Guid("37F44033-BC1B-4C22-99FF-DBD46A46333E"), new Guid("9A73266E-AA47-4163-98B4-61DEE6841AB5"), new Guid("50FA9720-3C13-44D4-80F7-896B0BB494E0")),
                Enrollment.Create(new Guid("C7D15D57-3A94-44C8-9563-2395EA717404"), new Guid("9A73266E-AA47-4163-98B4-61DEE6841AB5"), new Guid("B6CA990A-B0A6-42B8-B5C6-6BB94C91D6AF")),
                Enrollment.Create(new Guid("C332D92E-0149-43DF-8B06-48F2102BD8CA"), new Guid("B9DC994D-96ED-4D4D-98D8-003342140F24"), new Guid("5ACA2707-1CE8-46CF-A660-0686C864DC56")),
                Enrollment.Create(new Guid("57C4A929-EB97-414F-B152-F2E0A170C05E"), new Guid("B9DC994D-96ED-4D4D-98D8-003342140F24"), new Guid("5B8433C6-9CCE-4D26-AD95-4BEA60D20D44")),
                Enrollment.Create(new Guid("9BAF2C20-CC73-4D88-96FA-462DF327FF1B"), new Guid("C14FB673-1152-4451-B6F3-F1AB3F4AD2D9"), new Guid("B6CA990A-B0A6-42B8-B5C6-6BB94C91D6AF")),
                Enrollment.Create(new Guid("D5E211BE-A486-4A40-B6E2-92BB922DB3EF"), new Guid("CA38D03A-6301-4C6B-B2AA-E28CA8DCB307"), new Guid("5B8433C6-9CCE-4D26-AD95-4BEA60D20D44")),
                Enrollment.Create(new Guid("08022B91-0F31-4D64-B8C0-C0E98756332E"), new Guid("CA38D03A-6301-4C6B-B2AA-E28CA8DCB307"), new Guid("50FA9720-3C13-44D4-80F7-896B0BB494E0")),
                Enrollment.Create(new Guid("82DABBCC-66A4-4058-8DFC-8B57BB9890D3"), new Guid("CA38D03A-6301-4C6B-B2AA-E28CA8DCB307"), new Guid("B6CA990A-B0A6-42B8-B5C6-6BB94C91D6AF")),
                Enrollment.Create(new Guid("BFF7525F-4909-4795-A5EE-D1B39E4EB3C4"), new Guid("CA38D03A-6301-4C6B-B2AA-E28CA8DCB307"), new Guid("5ACA2707-1CE8-46CF-A660-0686C864DC56")),
            };
        }
    }
}