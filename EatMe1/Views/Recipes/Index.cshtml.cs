using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EatMe1.Data;
using EatMe1.Models;

namespace EatMe1.Views.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly EatMe1.Data.EatMe1Context _context;

        public IndexModel(EatMe1.Data.EatMe1Context context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipe.ToListAsync();
        }
    }
}
