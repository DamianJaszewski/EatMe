using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatMeApp.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<IngredientList> IngredientLists { get; set; }
    }
}
