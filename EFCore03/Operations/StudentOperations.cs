using EFCore03.Data;
using EFCore03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Operations
{
    public class StudentOperations
    {
        public static void AddStudent()
        {
            using var context = new AppDBContext();
            var newIsertedStudent = new List<Students> {
            new Students{FullName="JanaSheblX",Email="janaSheblX@gmail.com",DateOfBirth=new DateTime(2006,5,19)},
            new Students{FullName="fares amin",Email="faroos@gmail.com",DateOfBirth=new DateTime(2001,5,19)},
            new Students{FullName="habiba hossam",Email="kokowawa@gmail.com",DateOfBirth=new DateTime(2006,5,10)}
            };
            context.Students.AddRange(newIsertedStudent);
            context.SaveChanges();
            foreach(var s in newIsertedStudent)
            {
                Console.WriteLine($"Student added, ID: {s.Id}");
            }
        }
    }
}
