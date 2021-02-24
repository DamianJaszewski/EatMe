using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EatMeAgain.Data;
using EatMeAgain.Models;

namespace EatMeAgain.Controllers
{
    public class IngredientListsController : Controller
    {
        private readonly RecipeContext _context;

        public IngredientListsController(RecipeContext context)
        {
            _context = context;
        }

        // GET: IngredientLists
        public async Task<IActionResult> Index()
        {
            var recipeContext = _context.IngredientLists.Include(i => i.Ingredient).Include(i => i.Measure).Include(i => i.Recipe);
            return View(await recipeContext.ToListAsync());
        }

        // GET: IngredientLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientList = await _context.IngredientLists
                .Include(i => i.Ingredient)
                .Include(i => i.Measure)
                .Include(i => i.Recipe)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ingredientList == null)
            {
                return NotFound();
            }

            return View(ingredientList);
        }

        // GET: IngredientLists/Create
        public IActionResult Create()
        {
            ViewData["IngredientID"] = new SelectList(_context.Ingredients, "ID", "ID");
            ViewData["MeasureID"] = new SelectList(_context.Measures, "ID", "ID");
            ViewData["RecipeID"] = new SelectList(_context.Recipes, "ID", "ID");
            return View();
        }

        // POST: IngredientLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Quantity,RecipeID,IngredientID,MeasureID")] IngredientList ingredientList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ingredientList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IngredientID"] = new SelectList(_context.Ingredients, "ID", "ID", ingredientList.IngredientID);
            ViewData["MeasureID"] = new SelectList(_context.Measures, "ID", "ID", ingredientList.MeasureID);
            ViewData["RecipeID"] = new SelectList(_context.Recipes, "ID", "ID", ingredientList.RecipeID);
            return View(ingredientList);
        }

        // GET: IngredientLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientList = await _context.IngredientLists.FindAsync(id);
            if (ingredientList == null)
            {
                return NotFound();
            }
            ViewData["IngredientID"] = new SelectList(_context.Ingredients, "ID", "ID", ingredientList.IngredientID);
            ViewData["MeasureID"] = new SelectList(_context.Measures, "ID", "ID", ingredientList.MeasureID);
            ViewData["RecipeID"] = new SelectList(_context.Recipes, "ID", "ID", ingredientList.RecipeID);
            return View(ingredientList);
        }

        // POST: IngredientLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Quantity,RecipeID,IngredientID,MeasureID")] IngredientList ingredientList)
        {
            if (id != ingredientList.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingredientList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngredientListExists(ingredientList.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IngredientID"] = new SelectList(_context.Ingredients, "ID", "ID", ingredientList.IngredientID);
            ViewData["MeasureID"] = new SelectList(_context.Measures, "ID", "ID", ingredientList.MeasureID);
            ViewData["RecipeID"] = new SelectList(_context.Recipes, "ID", "ID", ingredientList.RecipeID);
            return View(ingredientList);
        }

        // GET: IngredientLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientList = await _context.IngredientLists
                .Include(i => i.Ingredient)
                .Include(i => i.Measure)
                .Include(i => i.Recipe)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ingredientList == null)
            {
                return NotFound();
            }

            return View(ingredientList);
        }

        // POST: IngredientLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ingredientList = await _context.IngredientLists.FindAsync(id);
            _context.IngredientLists.Remove(ingredientList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IngredientListExists(int id)
        {
            return _context.IngredientLists.Any(e => e.ID == id);
        }
    }
}
