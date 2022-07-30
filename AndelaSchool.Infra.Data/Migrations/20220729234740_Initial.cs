using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndelaSchool.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COURSES",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COURSES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STUDENTS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENTS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ENROLLMENTS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    StudentId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CourseId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENROLLMENTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ENROLLMENTS_COURSES_CourseId",
                        column: x => x.CourseId,
                        principalTable: "COURSES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ENROLLMENTS_STUDENTS_StudentId",
                        column: x => x.StudentId,
                        principalTable: "STUDENTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "COURSES",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("50fa9720-3c13-44d4-80f7-896b0bb494e0"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(472), "Maintaining, Monitoring and Troubleshooting Kubernetes" });

            migrationBuilder.InsertData(
                table: "COURSES",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("5aca2707-1ce8-46cf-a660-0686c864dc56"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(478), "Big Data on AWS: The Big Picture" });

            migrationBuilder.InsertData(
                table: "COURSES",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("5b8433c6-9cce-4d26-ad95-4bea60d20d44"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(446), "Agile in the Real World" });

            migrationBuilder.InsertData(
                table: "COURSES",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("b6ca990a-b0a6-42b8-b5c6-6bb94c91d6af"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(476), "Introduction to Emotional Intelligence" });

            migrationBuilder.InsertData(
                table: "STUDENTS",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("9a73266e-aa47-4163-98b4-61dee6841ab5"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3739), "Tom Cruise" });

            migrationBuilder.InsertData(
                table: "STUDENTS",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("b9dc994d-96ed-4d4d-98d8-003342140f24"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3746), "Natalie Portman" });

            migrationBuilder.InsertData(
                table: "STUDENTS",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("c14fb673-1152-4451-b6f3-f1ab3f4ad2d9"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3744), "John Travolta" });

            migrationBuilder.InsertData(
                table: "STUDENTS",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[] { new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3750), "Scarlett Johansson" });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("08022b91-0f31-4d64-b8c0-c0e98756332e"), new Guid("50fa9720-3c13-44d4-80f7-896b0bb494e0"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3192), new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("37f44033-bc1b-4c22-99ff-dbd46a46333e"), new Guid("50fa9720-3c13-44d4-80f7-896b0bb494e0"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3166), new Guid("9a73266e-aa47-4163-98b4-61dee6841ab5") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("57c4a929-eb97-414f-b152-f2e0a170c05e"), new Guid("5b8433c6-9cce-4d26-ad95-4bea60d20d44"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3175), new Guid("b9dc994d-96ed-4d4d-98d8-003342140f24") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("82dabbcc-66a4-4058-8dfc-8b57bb9890d3"), new Guid("b6ca990a-b0a6-42b8-b5c6-6bb94c91d6af"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3195), new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("9baf2c20-cc73-4d88-96fa-462df327ff1b"), new Guid("b6ca990a-b0a6-42b8-b5c6-6bb94c91d6af"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3184), new Guid("c14fb673-1152-4451-b6f3-f1ab3f4ad2d9") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("b8a2a341-9ce7-4f76-b8d0-58c20e1330fc"), new Guid("5b8433c6-9cce-4d26-ad95-4bea60d20d44"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3158), new Guid("9a73266e-aa47-4163-98b4-61dee6841ab5") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("bff7525f-4909-4795-a5ee-d1b39e4eb3c4"), new Guid("5aca2707-1ce8-46cf-a660-0686c864dc56"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3198), new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("c332d92e-0149-43df-8b06-48f2102bd8ca"), new Guid("5aca2707-1ce8-46cf-a660-0686c864dc56"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3172), new Guid("b9dc994d-96ed-4d4d-98d8-003342140f24") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("c7d15d57-3a94-44c8-9563-2395ea717404"), new Guid("b6ca990a-b0a6-42b8-b5c6-6bb94c91d6af"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3169), new Guid("9a73266e-aa47-4163-98b4-61dee6841ab5") });

            migrationBuilder.InsertData(
                table: "ENROLLMENTS",
                columns: new[] { "Id", "CourseId", "CreatedAt", "StudentId" },
                values: new object[] { new Guid("d5e211be-a486-4a40-b6e2-92bb922db3ef"), new Guid("5b8433c6-9cce-4d26-ad95-4bea60d20d44"), new DateTime(2022, 7, 29, 20, 47, 40, 286, DateTimeKind.Local).AddTicks(3187), new Guid("ca38d03a-6301-4c6b-b2aa-e28ca8dcb307") });

            migrationBuilder.CreateIndex(
                name: "IX_ENROLLMENTS_CourseId",
                table: "ENROLLMENTS",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ENROLLMENTS_StudentId",
                table: "ENROLLMENTS",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ENROLLMENTS");

            migrationBuilder.DropTable(
                name: "COURSES");

            migrationBuilder.DropTable(
                name: "STUDENTS");
        }
    }
}
