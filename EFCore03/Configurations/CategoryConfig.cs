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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(c => c.Description)
                .HasMaxLength(300);
            builder.HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId)
                .OnDelete(DeleteBehavior.Restrict); 
            builder.HasMany(c => c.Courses)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
                new Category { Id = 1, Name = "Programming", Description = "Courses related to programming languages and software development." },
                new Category { Id = 2, Name = "Web Development", Description = "Courses related to web development technologies.", ParentCategoryId = 1 },
                new Category { Id = 3, Name = "Mobile Development", Description = "Courses related to mobile app development.", ParentCategoryId = 1 },
                new Category { Id = 4, Name = "Data Science", Description = "Courses related to data analysis, machine learning, and AI.", ParentCategoryId = 1 },
                new Category { Id = 5, Name = "Database Management", Description = "Courses related to database design and management." }
            );
        }
    }
}
