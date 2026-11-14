using EFCore03.Enums;
using EFCore03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Configurations
{
    public class CourseConfig : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Description)
                .HasMaxLength(300);
            builder.Property(c => c.Price)
                .IsRequired()
                .HasPrecision(18, 2);
            builder.Property(c => c.IsPublished)
                .IsRequired();
            builder.Property(c => c.PublishedDate)
                .IsRequired(false);
            builder.Property(c => c.Level)
                .IsRequired();
            builder.HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.Category)
                .WithMany(cat => cat.Courses)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            // data seeding
            builder.HasData(
                new Courses { Id = 1, Title = "C# Basics", Description = "Learn the basics of C# programming.", Price = 49.99m, IsPublished = true, PublishedDate = new DateTime(2023, 1, 15), Level = Level.Beginner, InstructorId = 1, CategoryId = 1 },
                new Courses { Id = 2, Title = "ASP.NET Core Web Development", Description = "Build web applications using ASP.NET Core.", Price = 99.99m, IsPublished = true, PublishedDate = new DateTime(2023, 2, 10), Level = Level.Intermediate, InstructorId = 2, CategoryId = 2 },
                new Courses { Id = 3, Title = "Entity Framework Core", Description = "Master data access with Entity Framework Core.", Price = 79.99m, IsPublished = false, PublishedDate = null, Level = Level.Advanced, InstructorId = 3, CategoryId = 4 },
                new Courses { Id = 4, Title = "JavaScript Essentials", Description = "Learn the fundamentals of JavaScript programming.", Price = 59.99m, IsPublished = true, PublishedDate = new DateTime(2023, 3, 5), Level = Level.Beginner, InstructorId = 1, CategoryId = 2 },
                new Courses { Id = 5, Title = "React for Beginners", Description = "Get started with React and build interactive UIs.", Price = 89.99m, IsPublished = true, PublishedDate = new DateTime(2023, 4, 20), Level = Level.Beginner, InstructorId = 2, CategoryId = 2 },
                new Courses { Id = 6, Title = "Advanced React Patterns", Description = "Explore advanced patterns and techniques in React development.", Price = 129.99m, IsPublished = false, PublishedDate = null, Level = Level.Advanced, InstructorId = 3, CategoryId = 3 }
            );

        }
    }
}
