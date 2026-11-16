using EFCore03.Data;
using EFCore03.Enums;
using EFCore03.Models;
using EFCore03.Operations;
namespace EFCore03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var connection = new AppDBContext();
            if (!connection.Students.Any())// هل فاضي؟
            {
                var students = new List<Students>
                {
                    new Students { FullName = "John Doe", Email = "john.doe@example.com", DateOfBirth = new DateTime(2000, 1, 1) },
                    new Students { FullName = "Jane Smith", Email = "jane.smith@example.com", DateOfBirth = new DateTime(2001, 2, 2) },
                    new Students { FullName = "Alice Johnson", Email = "alice.johnson@example.com", DateOfBirth = new DateTime(2002, 3, 3) },
                    new Students { FullName = "Bob Brown", Email = "bob.brown@example.com", DateOfBirth = new DateTime(2003, 4, 4) },
                    new Students { FullName = "Charlie Davis", Email = "charlie.davis@example.com", DateOfBirth = new DateTime(2004, 5, 5) }
                };
                connection.Students.AddRange(students);
                connection.SaveChanges();
            }

            if (!connection.Enrollments.Any())
            {
                var enrollments = new List<Enrollment>
    {
                    new Enrollment { StudentId = 1, CourseId = 1, EnrollmentDate = DateTime.Now, Progress = 35, status = Status.Active },
                    new Enrollment { StudentId = 2, CourseId = 2, EnrollmentDate = DateTime.Now, Progress = 100, status = Status.Completed, FinalGrade = 95 },
                    new Enrollment { StudentId = 3, CourseId = 3, EnrollmentDate = DateTime.Now, Progress = 20, status = Status.Dropped },
                    new Enrollment { StudentId = 4, CourseId = 4, EnrollmentDate = DateTime.Now, Progress = 100, status = Status.Completed, FinalGrade = 90 },
                    new Enrollment { StudentId = 5, CourseId = 5, EnrollmentDate = DateTime.Now, Progress = 60, status = Status.Active },
                    new Enrollment { StudentId = 1, CourseId = 2, EnrollmentDate = DateTime.Now, Progress = 100, status = Status.Completed, FinalGrade = 88 },
                    new Enrollment { StudentId = 2, CourseId = 4, EnrollmentDate = DateTime.Now, Progress = 45, status = Status.Active },
                    new Enrollment { StudentId = 3, CourseId = 5, EnrollmentDate = DateTime.Now, Progress = 10, status = Status.Dropped }
                };
                connection.Enrollments.AddRange(enrollments);
                connection.SaveChanges();
            }

            InstructorOperations.AddInstructor(new Instructors
            {
                Name = "Ali Ahmed",
                Email = "ali.ahmed@example.com",
                bio = "Senior instructor",
                JoinDate=DateTime.Now
            });
        }
    }
}