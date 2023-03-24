using Recipe_App_Api.Models;

namespace Recipe_App_Api.Interfaces
{
    public interface IIngredientInterface
    {
        ICollection<Ingredient> getAllIngredientsByRecipeId(int recipeId);
        Ingredient getIngredientById(int ingredientId);
        bool ingredientExists(int recipeId);
    }
}
