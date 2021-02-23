using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EatMeAgain.Models;
using Microsoft.EntityFrameworkCore;

namespace EatMeAgain.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<IngredientList> IngredientLists { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Measure> Measures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().ToTable("Recipe");
            modelBuilder.Entity<IngredientList>().ToTable("IngredientList");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<Measure>().ToTable("Measure");
        }
    }
}
