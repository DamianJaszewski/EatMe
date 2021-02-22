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
    public class DetailsModel : PageModel
    {
        private readonly EatMe1.Data.EatMe1Context _context;

        public DetailsModel(EatMe1.Data.EatMe1Context context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipe.FirstOrDefaultAsync(m => m.ID == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
