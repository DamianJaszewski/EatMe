using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EatMeApp.Data;
using EatMeApp.Models;

namespace EatMeApp.Controllers
{
    public class IngredientListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IngredientListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IngredientLists
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.IngredientLists.Include(i => i.Measure).Include(i => i.Recipe);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: IngredientLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientLists = await _context.IngredientLists
                .Include(i => i.Measure)
                .Include(i => i.Recipe)
                .FirstOrDefaultAsync(m => m.IngredientListsId == id);
            if (ingredientLists == null)
            {
                return NotFound();
            }

            return View(ingredientLists);
        }

        // GET: IngredientLists/Create
        public IActionResult Create()
        {
            ViewData["MeasureId"] = new SelectList(_context.Measure, "MeasureId", "MeasureId");
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "Id", "Id");
            return View();
        }

        // POST: IngredientLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IngredientListsId,Quantity,RecipeId,IgredientId,MeasureId")] IngredientLists ingredientLists)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ingredientLists);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MeasureId"] = new SelectList(_context.Measure, "MeasureId", "MeasureId", ingredientLists.MeasureId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "Id", "Id", ingredientLists.RecipeId);
            return View(ingredientLists);
        }

        // GET: IngredientLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientLists = await _context.IngredientLists.FindAsync(id);
            if (ingredientLists == null)
            {
                return NotFound();
            }
            ViewData["MeasureId"] = new SelectList(_context.Measure, "MeasureId", "MeasureId", ingredientLists.MeasureId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "Id", "Id", ingredientLists.RecipeId);
            return View(ingredientLists);
        }

        // POST: IngredientLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IngredientListsId,Quantity,RecipeId,IgredientId,MeasureId")] IngredientLists ingredientLists)
        {
            if (id != ingredientLists.IngredientListsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingredientLists);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngredientListsExists(ingredientLists.IngredientListsId))
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
            ViewData["MeasureId"] = new SelectList(_context.Measure, "MeasureId", "MeasureId", ingredientLists.MeasureId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "Id", "Id", ingredientLists.RecipeId);
            return View(ingredientLists);
        }

        // GET: IngredientLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredientLists = await _context.IngredientLists
                .Include(i => i.Measure)
                .Include(i => i.Recipe)
                .FirstOrDefaultAsync(m => m.IngredientListsId == id);
            if (ingredientLists == null)
            {
                return NotFound();
            }

            return View(ingredientLists);
        }

        // POST: IngredientLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ingredientLists = await _context.IngredientLists.FindAsync(id);
            _context.IngredientLists.Remove(ingredientLists);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IngredientListsExists(int id)
        {
            return _context.IngredientLists.Any(e => e.IngredientListsId == id);
        }
    }
}
