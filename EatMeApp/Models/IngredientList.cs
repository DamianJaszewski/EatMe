using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatMeApp.Models
{
    public class IngredientList
    {
        public int ID { get; set; }
        public double Quantity { get; set; }
        public int RecipeID { get; set; }
        public int IngredientID { get; set; }
        public int MeasureID { get; set; }

        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
        public Measure Measure { get; set; }


    }
}
