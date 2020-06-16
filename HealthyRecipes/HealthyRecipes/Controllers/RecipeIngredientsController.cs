using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthyRecipes.Data;
using HealthyRecipes.Models;
using HealthyRecipes.Migrations;
using HealthyRecipes.ViewModels;

namespace HealthyRecipes.Controllers
{
    public class RecipeIngredientsController : Controller
    {
        private readonly HealthyRecipesContext _context;

        public RecipeIngredientsController(HealthyRecipesContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> SetIngredientsInRecipe(int amount)
        {
            IQueryable<Ingredient> ingredients = _context.Ingredient;
            IQueryable<Recipe> recipes = _context.Recipe;
            int[] quantities = Enumerable.Range(1,100).Reverse().ToArray();
            int[] calories = Enumerable.Range(0, 1000).Reverse().ToArray();
            int[] proteins = Enumerable.Range(0, 1000).Reverse().ToArray();
            var setIngredientsViewModel = new SetIngredientsViewModel
            {
                Recipes = new SelectList(await recipes.ToListAsync(), "Id", "Title"),
                Ingredients = new SelectList(await ingredients.OrderBy(s => s.Name).ToListAsync(), "Id", "Name"),
                IngredientQuntities = new SelectList(quantities.ToList()),
                CaloriesPerRecipes = new SelectList(calories.ToList()),
                ProteinsPerRecipes = new SelectList(proteins.ToList())
            };
            return View(setIngredientsViewModel);


        }

        [HttpPost]
        public async Task<IActionResult> SetIngredientsInRecipe(SetIngredientsViewModel entry)
        {
            Recipe recipe = await _context.Recipe.FirstOrDefaultAsync(c => c.Id == entry.RecipeId);
            if (recipe == null) return NotFound();

            if (ModelState.IsValid)
            {
                foreach (int ingId in entry.IngredientIds)
                {
                    RecipeIngredient recipeIngredient = await _context.RecipeIngredient
                                        .FirstOrDefaultAsync(c => c.RecipeId == entry.RecipeId && c.IngredientId == ingId
                                        && c.IngredientQuantity == entry.IngredientQuntity && c.CaloriesPerRecipe == entry.CaloriesPerRecipe && c.ProteinsPerRecipe == entry.ProteinsPerRecipe);
                    if (recipeIngredient == null)
                    {
                        recipeIngredient = new RecipeIngredient
                        {
                            RecipeId = entry.RecipeId,
                            IngredientId = ingId,
                            IngredientQuantity = entry.IngredientQuntity,
                            CaloriesPerRecipe = entry.CaloriesPerRecipe,
                            ProteinsPerRecipe = entry.ProteinsPerRecipe

                        };
                        _context.Add(recipeIngredient);
                        }

                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { rTitle = recipe.Title, rIngQuan = entry.IngredientQuntity, rCal = entry.CaloriesPerRecipe, rProt = entry.ProteinsPerRecipe });
            }
            return RedirectToAction(nameof(Index));
        }


        // GET: RecipeIngredients
        public async Task<IActionResult> Index()
        {
            var healthyRecipesContext = _context.RecipeIngredient.Include(r => r.Ingredient).Include(r => r.Recipe);
            return View(await healthyRecipesContext.ToListAsync());
        }

        // GET: RecipeIngredients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipeIngredient = await _context.RecipeIngredient
                .Include(r => r.Ingredient)
                .Include(r => r.Recipe)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipeIngredient == null)
            {
                return NotFound();
            }

            return View(recipeIngredient);
        }

        // GET: RecipeIngredients/Create
        public IActionResult Create()
        {
            ViewData["IngredientId"] = new SelectList(_context.Ingredient, "Id", "Name");
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "Id", "Description");
            return View();
        }

        // POST: RecipeIngredients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RecipeId,IngredientId,CaloriesPerRecipe,ProteinsPerRecipe")] RecipeIngredient recipeIngredient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipeIngredient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IngredientId"] = new SelectList(_context.Ingredient, "Id", "Name", recipeIngredient.IngredientId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "Id", "Description", recipeIngredient.RecipeId);
            return View(recipeIngredient);
        }

        // GET: RecipeIngredients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipeIngredient = await _context.RecipeIngredient.FindAsync(id);
            if (recipeIngredient == null)
            {
                return NotFound();
            }
            ViewData["IngredientId"] = new SelectList(_context.Ingredient, "Id", "Name", recipeIngredient.IngredientId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "Id", "Description", recipeIngredient.RecipeId);
            return View(recipeIngredient);
        }

        // POST: RecipeIngredients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RecipeId,IngredientId,CaloriesPerRecipe,ProteinsPerRecipe")] RecipeIngredient recipeIngredient)
        {
            if (id != recipeIngredient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipeIngredient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeIngredientExists(recipeIngredient.Id))
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
            ViewData["IngredientId"] = new SelectList(_context.Ingredient, "Id", "Name", recipeIngredient.IngredientId);
            ViewData["RecipeId"] = new SelectList(_context.Recipe, "Id", "Description", recipeIngredient.RecipeId);
            return View(recipeIngredient);
        }

        // GET: RecipeIngredients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipeIngredient = await _context.RecipeIngredient
                .Include(r => r.Ingredient)
                .Include(r => r.Recipe)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipeIngredient == null)
            {
                return NotFound();
            }

            return View(recipeIngredient);
        }

        // POST: RecipeIngredients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipeIngredient = await _context.RecipeIngredient.FindAsync(id);
            _context.RecipeIngredient.Remove(recipeIngredient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipeIngredientExists(int id)
        {
            return _context.RecipeIngredient.Any(e => e.Id == id);
        }
    }
}
