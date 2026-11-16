using EFCore03.Data;
using EFCore03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Operations
{
    public class InstructorOperations
    {
        public static void AddInstructor(Instructors instructor)
        {
            using var context = new AppDBContext();
            context.Instructors.Add(instructor);
            context.SaveChanges();
            Console.WriteLine($"Instructor added , ID:{instructor.Id}");
        }

    }
}
