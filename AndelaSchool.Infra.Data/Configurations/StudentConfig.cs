using AndelaSchool.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AndelaSchool.Infra.Data.Configurations
{
    public class StudentConfig : EntityConfiguration<Student>, IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            DefaultConfigs(builder, tableName: "STUDENTS");

            builder.Property(student => student.Name)
                   .HasMaxLength(60)
                   .IsRequired();

            builder.HasData(SeedStudents());
        }

        private static IEnumerable<Student> SeedStudents()
        {
            return new List<Student>
            {
                Student.Create(new Guid("9A73266E-AA47-4163-98B4-61DEE6841AB5"), "Tom Cruise"),
                Student.Create(new Guid("C14FB673-1152-4451-B6F3-F1AB3F4AD2D9"), "John Travolta"),
                Student.Create(new Guid("B9DC994D-96ED-4D4D-98D8-003342140F24"), "Natalie Portman"),
                Student.Create(new Guid("CA38D03A-6301-4C6B-B2AA-E28CA8DCB307"), "Scarlett Johansson")
            };
        }
    }
}