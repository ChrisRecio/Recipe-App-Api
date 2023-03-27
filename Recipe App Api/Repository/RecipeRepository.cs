using Recipe_App_Api.Data;
using Recipe_App_Api.Interfaces;
using Recipe_App_Api.Models;
using System;

public class RecipeRepository : IRecipeInterface
{
	private readonly DataContext _context;
	public RecipeRepository(DataContext context)
	{
		this._context = context;
	}

    public ICollection<Recipe> GetAllRecipes()
    {
		return _context.Recipes.OrderBy(p => p.Id).ToList();
    }

    public Recipe GetRecipeById(int id)
    {
        var query = (from r in _context.Recipes
                     where r.Id == id
                     select new Recipe()
                     {
                         Id = r.Id,
                         Name = r.Name,
                         Image = r.Image,
                         Servings = r.Servings,
                         Description = r.Description,
                         CourseId = r.CourseId,
                         PrepTime = r.PrepTime,
                         CookTime = r.CookTime,
                         PrepTimeMeasurement = r.PrepTimeMeasurement,
                         CookTimeMeasurement = r.CookTimeMeasurement,
                         Ingredients = r.Ingredients.Where(x => x.RecipeId == r.Id).ToList(),
                         RecipeSteps = r.RecipeSteps.Where(x => x.RecipeId == r.Id).ToList(),
                     }).FirstOrDefault();

        return query;

        // Does not inclue Ingredients or RecipeSteps
        // return _context.Recipes.Where(p => p.Id == id).FirstOrDefault();
    }

    public bool RecipeExists(int id)
    {
        return _context.Recipes.Any(p => p.Id == id);
    }
}
