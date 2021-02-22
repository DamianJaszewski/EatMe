using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatMe1.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public decimal Quantity { get; set; }
        public int RecipeID { get; set; }
        public int IngredientID { get; set; }
        public int MeasureID { get; set; }

        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
        public Measure Measure { get; set; }


    }
}
