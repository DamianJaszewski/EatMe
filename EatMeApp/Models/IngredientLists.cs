using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EatMeApp.Models
{
    public class IngredientLists
    {
        public  int IngredientListsId { get; set; }
        public decimal Quantity { get; set; }
        public virtual int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual int IgredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public virtual int MeasureId { get; set; }
        public virtual Measure Measure { get; set; }

    }
}
