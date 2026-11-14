using EFCore03.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedDate { get; set; }
        public Level Level { get; set; }
        public int InstructorId { get; set; }
        public Instructors Instructor { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        // public ICollection<Enrollments> Enrollments { get; set; } = new List<Enrollments>();

    }
}
