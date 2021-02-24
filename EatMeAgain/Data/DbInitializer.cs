using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EatMeAgain.Models;

namespace EatMeAgain.Data
{
    public class DbInitializer
    {
        public static void Initalize(RecipeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Recipes.Any())
            {
                return; //DB has been seeded
            }

            var recipes = new Recipe[]
            {
                new Recipe{Name="Bolognese ze szpinakiem",PreepTime=30,Instruction="Ugotuj makaron. Na oleju podsmaż cebulę i czosnek, dodaj drobno  pokruszone tofu i obficie dopraw. Podsmażaj aż tofu zrobi się z wierzchu twarde i chrupiące. Dodaj passatę i szpinak i gotuj ok. 5-10 min.  Podawaj z makaronem. "},
            };
            foreach (Recipe r in recipes)
            {
                context.Recipes.Add(r);
            }
            context.SaveChanges();

            var ingredients = new Ingredient[]
            {
                new Ingredient{Name = "Olej"},
                new Ingredient{Name = "Cebula"}
            };
            foreach (Ingredient i in ingredients)
            {
                context.Ingredients.Add(i);
            }
            context.SaveChanges();

            var measures = new Measure[]
            {
                new Measure{Name = "Łyżka"},
                new Measure{Name = "Szt."}
            };
            foreach (Measure m in measures)
            {
                context.Measures.Add(m);
            }
            context.SaveChanges();

            var ingredientLists = new IngredientList[]
            {
                new IngredientList{Quantity=1,RecipeID=1,IngredientID=1,MeasureID=1},
                new IngredientList{Quantity=1,RecipeID=1,IngredientID=2,MeasureID=2}
            };
            foreach (IngredientList iL in ingredientLists)
            {
                context.IngredientLists.Add(iL);
            }
            context.SaveChanges();
        }
    }
}
