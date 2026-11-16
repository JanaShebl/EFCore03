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
    public class EnrollmentConfig: IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(k => new { k.StudentId, k.CourseId });
            builder.Property(e => e.EnrollmentDate)
                .IsRequired();
            builder.Property(e => e.FinalGrade)
                .IsRequired(false);
            builder.Property(e => e.status)
                .IsRequired();
            builder.Property(e => e.Progress)
                .IsRequired()
                .HasPrecision(5, 2);
            builder.HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    
    }
}
