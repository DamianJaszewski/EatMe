using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatMe1.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PreepTime { get; set; }
        public string Instruction { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
