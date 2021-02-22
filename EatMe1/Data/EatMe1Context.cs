using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EatMe1.Models;

namespace EatMe1.Data
{
    public class EatMe1Context : DbContext
    {
        public EatMe1Context (DbContextOptions<EatMe1Context> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Measure> Measures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().ToTable("Recipe");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Ingredient>().ToTable("Ingredient");
            modelBuilder.Entity<Measure>().ToTable("Measure");
        }
    }
}
