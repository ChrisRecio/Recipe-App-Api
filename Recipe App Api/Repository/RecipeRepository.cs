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
        return _context.Recipes.Where(p => p.Id == id).FirstOrDefault();
    }

    public bool RecipeExists(int id)
    {
        return _context.Recipes.Any(p => p.Id == id);
    }
}
