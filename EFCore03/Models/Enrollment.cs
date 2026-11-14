using EFCore03.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Models
{
    public class Enrollment
    {
        //public int Id { get; set; } composite key
        public int StudentId { get; set; }
        public Students Student { get; set; }
        public int CourseId { get; set; }
        public Courses Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public decimal? FinalGrade { get; set; }
        public decimal Progress { get; set; } 
        // status
        public Status status { get; set; }
        public Students student { get; set; }
        public Courses course { get; set; }
    }
}
