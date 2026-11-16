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
    public class InstructorConfig : IEntityTypeConfiguration<Instructors>
    {
        public void Configure(EntityTypeBuilder<Instructors> builder)
        {
            builder.Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(i => i.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(i => i.bio)
                .HasMaxLength(300);
            builder.Property(i => i.JoinDate)
                .IsRequired();
            builder.HasMany(i => i.Courses)
                .WithOne(c => c.Instructor)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
                new Instructors{Id = 1,Name = "Ahmed Mohamed",Email = "ahmed.mohamed@example.com",bio = "Mid-level instructor",JoinDate = new DateTime(2023,1,1) },
                new Instructors{Id = 2,Name = "Sara Ali",Email = "sara.ali@example.com",bio = "Senior instructor",JoinDate = new DateTime(2025,10,2)},
                new Instructors{Id = 3,Name = "Mohamed Hassan",Email = "mohamed.hassan@example.com",bio = "Junior instructor",JoinDate = new DateTime(2023,5,15)}
                );
        }
    }
}
