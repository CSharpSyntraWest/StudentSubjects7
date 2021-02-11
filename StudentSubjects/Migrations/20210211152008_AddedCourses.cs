using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSubjects.Migrations
{
    public partial class AddedCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("51838396-742c-46f8-a21f-1fdf215caae7"));

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumerOfLessons = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "CourseSubject",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSubject", x => new { x.CourseId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_CourseSubject_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "Description", "Name", "NumerOfLessons", "StartDate" },
                values: new object[] { new Guid("00a18bcf-607e-4084-a49d-cd524769dbc9"), "front-end Javascript and css", "Front-end Developer", 850L, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "Description", "Name", "NumerOfLessons", "StartDate" },
                values: new object[] { new Guid("3cc1e5c0-838d-4912-bc3d-f770eb669e1a"), "Backend .Net Developer in C#", "DotNet Developer", 985L, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "BirthDate", "FirstName", "LastName" },
                values: new object[] { new Guid("a821b747-5a72-47f7-be34-c61f123eb44d"), new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Jansens" });

            migrationBuilder.InsertData(
                table: "CourseSubject",
                columns: new[] { "CourseId", "SubjectId" },
                values: new object[,]
                {
                    { new Guid("00a18bcf-607e-4084-a49d-cd524769dbc9"), new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a") },
                    { new Guid("00a18bcf-607e-4084-a49d-cd524769dbc9"), new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811") },
                    { new Guid("3cc1e5c0-838d-4912-bc3d-f770eb669e1a"), new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a") },
                    { new Guid("3cc1e5c0-838d-4912-bc3d-f770eb669e1a"), new Guid("80abbca8-664d-4b20-b5de-024705497d4a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseSubject_SubjectId",
                table: "CourseSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseSubject");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a821b747-5a72-47f7-be34-c61f123eb44d"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "BirthDate", "FirstName", "LastName" },
                values: new object[] { new Guid("51838396-742c-46f8-a21f-1fdf215caae7"), new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jan", "Jansens" });
        }
    }
}
