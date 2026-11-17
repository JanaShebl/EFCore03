using EFCore03.Models;
using EFCore03.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Operations
{
    public class CourseOperations
    {
        public static void AddCourse(Courses course)
        {
            using var context = new AppDBContext();
            if(!context.Instructors.Any(i=>i.Id == course.InstructorId))
            {
                Console.WriteLine($"Instructor with ID {course.InstructorId} does not exist. Cannot add course.");
                return;
            }
            if(!context.Categories.Any(c => c.Id == course.CategoryId))
            {
                Console.WriteLine($"Category with ID {course.CategoryId} does not exist. Cannot add course.");
                return;
            }
            context.Courses.Add(course);
            context.SaveChanges();
            Console.WriteLine($"Course added , ID:{course.Id}");
        }
    }
}
