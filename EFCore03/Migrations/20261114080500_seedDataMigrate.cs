using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore03.Migrations
{
    /// <inheritdoc />
    public partial class seedDataMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Courses related to programming languages and software development.", "Programming", null },
                    { 5, "Courses related to database design and management.", "Database Management", null }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Email", "JoinDate", "Name", "bio" },
                values: new object[,]
                {
                    { 1, "ahmed.mohamed@example.com", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed Mohamed", "Mid-level instructor" },
                    { 2, "sara.ali@example.com", new DateTime(2025, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara Ali", "Senior instructor" },
                    { 3, "mohamed.hassan@example.com", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohamed Hassan", "Junior instructor" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 2, "Courses related to web development technologies.", "Web Development", 1 },
                    { 3, "Courses related to mobile app development.", "Mobile Development", 1 },
                    { 4, "Courses related to data analysis, machine learning, and AI.", "Data Science", 1 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Description", "InstructorId", "IsPublished", "Level", "Price", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Learn the basics of C# programming.", 1, true, 0, 49.99m, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# Basics" },
                    { 2, 2, "Build web applications using ASP.NET Core.", 2, true, 1, 99.99m, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.NET Core Web Development" },
                    { 3, 4, "Master data access with Entity Framework Core.", 3, false, 2, 79.99m, null, "Entity Framework Core" },
                    { 4, 2, "Learn the fundamentals of JavaScript programming.", 1, true, 0, 59.99m, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "JavaScript Essentials" },
                    { 5, 2, "Get started with React and build interactive UIs.", 2, true, 0, 89.99m, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "React for Beginners" },
                    { 6, 3, "Explore advanced patterns and techniques in React development.", 3, false, 2, 129.99m, null, "Advanced React Patterns" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
