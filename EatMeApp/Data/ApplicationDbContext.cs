using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EatMeApp.Models;

namespace EatMeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EatMeApp.Models.Recipe> Recipe { get; set; }
        public DbSet<EatMeApp.Models.IngredientLists> IngredientLists { get; set; }
        public DbSet<EatMeApp.Models.Ingredient> Ingredient { get; set; }
        public DbSet<EatMeApp.Models.Measure> Measure { get; set; }
    }
}
