using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatMe1.Models
{
    public class Measure
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
