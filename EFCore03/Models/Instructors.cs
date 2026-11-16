using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Models
{
    public class Instructors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? bio { get; set; }
        public DateTime JoinDate { get; set; }
         public ICollection<Courses> Courses { get; set;} =new List<Courses>();
    }
}
