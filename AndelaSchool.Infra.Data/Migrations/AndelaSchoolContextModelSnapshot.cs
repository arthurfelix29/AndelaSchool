// <auto-generated />
using System;
using AndelaSchool.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AndelaSchool.Infra.Data.Migrations
{
    [DbContext(typeof(AndelaSchoolContext))]
    partial class AndelaSchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("AndelaSchool.Domain.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("COURSES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b8433c6-9cce-4d26-ad95-4bea60d20d44"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(446),
                            Name = "Agile in the Real World"
                        },
                        new
                        {
                            Id = new Guid("50fa9720-3c13-44d4-80f7-896b0bb494e0"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(472),
                            Name = "Maintaining, Monitoring and Troubleshooting Kubernetes"
                        },
                        new
                        {
                            Id = new Guid("b6ca990a-b0a6-42b8-b5c6-6bb94c91d6af"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(476),
                            Name = "Introduction to Emotional Intelligence"
                        },
                        new
                        {
                            Id = new Guid("5aca2707-1ce8-46cf-a660-0686c864dc56"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(478),
                            Name = "Big Data on AWS: The Big Picture"
                        });
                });

            modelBuilder.Entity("AndelaSchool.Domain.Models.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("ENROLLMENTS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8a2a341-9ce7-4f76-b8d0-58c20e1330fc"),
                            CourseId = new Guid("5b8433c6-9cce-4d26-ad95-4bea60d20d44"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3158),
                            StudentId = new Guid("9a73266e-aa47-4163-98b4-61dee6841ab5")
                        },
                        new
                        {
                            Id = new Guid("37f44033-bc1b-4c22-99ff-dbd46a46333e"),
                            CourseId = new Guid("50fa9720-3c13-44d4-80f7-896b0bb494e0"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3166),
                            StudentId = new Guid("9a73266e-aa47-4163-98b4-61dee6841ab5")
                        },
                        new
                        {
                            Id = new Guid("c7d15d57-3a94-44c8-9563-2395ea717404"),
                            CourseId = new Guid("b6ca990a-b0a6-42b8-b5c6-6bb94c91d6af"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3169),
                            StudentId = new Guid("9a73266e-aa47-4163-98b4-61dee6841ab5")
                        },
                        new
                        {
                            Id = new Guid("c332d92e-0149-43df-8b06-48f2102bd8ca"),
                            CourseId = new Guid("5aca2707-1ce8-46cf-a660-0686c864dc56"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3172),
                            StudentId = new Guid("b9dc994d-96ed-4d4d-98d8-003342140f24")
                        },
                        new
                        {
                            Id = new Guid("57c4a929-eb97-414f-b152-f2e0a170c05e"),
                            CourseId = new Guid("5b8433c6-9cce-4d26-ad95-4bea60d20d44"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3175),
                            StudentId = new Guid("b9dc994d-96ed-4d4d-98d8-003342140f24")
                        },
                        new
                        {
                            Id = new Guid("9baf2c20-cc73-4d88-96fa-462df327ff1b"),
                            CourseId = new Guid("b6ca990a-b0a6-42b8-b5c6-6bb94c91d6af"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3184),
                            StudentId = new Guid("c14fb673-1152-4451-b6f3-f1ab3f4ad2d9")
                        },
                        new
                        {
                            Id = new Guid("d5e211be-a486-4a40-b6e2-92bb922db3ef"),
                            CourseId = new Guid("5b8433c6-9cce-4d26-ad95-4bea60d20d44"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3187),
                            StudentId = new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307")
                        },
                        new
                        {
                            Id = new Guid("08022b91-0f31-4d64-b8c0-c0e98756332e"),
                            CourseId = new Guid("50fa9720-3c13-44d4-80f7-896b0bb494e0"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3192),
                            StudentId = new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307")
                        },
                        new
                        {
                            Id = new Guid("82dabbcc-66a4-4058-8dfc-8b57bb9890d3"),
                            CourseId = new Guid("b6ca990a-b0a6-42b8-b5c6-6bb94c91d6af"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3195),
                            StudentId = new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307")
                        },
                        new
                        {
                            Id = new Guid("bff7525f-4909-4795-a5ee-d1b39e4eb3c4"),
                            CourseId = new Guid("5aca2707-1ce8-46cf-a660-0686c864dc56"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3198),
                            StudentId = new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307")
                        });
                });

            modelBuilder.Entity("AndelaSchool.Domain.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("STUDENTS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9a73266e-aa47-4163-98b4-61dee6841ab5"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3739),
                            Name = "Tom Cruise"
                        },
                        new
                        {
                            Id = new Guid("c14fb673-1152-4451-b6f3-f1ab3f4ad2d9"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3744),
                            Name = "John Travolta"
                        },
                        new
                        {
                            Id = new Guid("b9dc994d-96ed-4d4d-98d8-003342140f24"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3746),
                            Name = "Natalie Portman"
                        },
                        new
                        {
                            Id = new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307"),
                            CreatedAt = new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3750),
                            Name = "Scarlett Johansson"
                        });
                });

            modelBuilder.Entity("AndelaSchool.Domain.Models.Enrollment", b =>
                {
                    b.HasOne("AndelaSchool.Domain.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AndelaSchool.Domain.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("AndelaSchool.Domain.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("AndelaSchool.Domain.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
