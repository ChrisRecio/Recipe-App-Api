using Recipe_App_Api.Data;
using Recipe_App_Api.Interfaces;
using Recipe_App_Api.Models;

namespace Recipe_App_Api.Repository
{
    public class IngredientRepository : IIngredientInterface
    {
        private readonly DataContext _context;
        public IngredientRepository(DataContext context)
        {
            this._context = context;
        }

        public ICollection<Ingredient> getAllIngredientsByRecipeId(int recipeId)
        {
            var query = _context.Ingredients.Where(x => x.RecipeId == recipeId).ToList();
            return query;
        }

        public Ingredient getIngredientById(int ingredientId)
        {
            var query = _context.Ingredients.Where(x => x.Id == ingredientId).FirstOrDefault();
            return query;
        }

        public bool ingredientExists(int ingredientId)
        {
            return _context.Ingredients.Any(p => p.Id == ingredientId);
        }
    }
}
