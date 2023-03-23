using Recipe_App_Api.Models;

namespace Recipe_App_Api.Interfaces
{
    public interface IRecipeInterface
    {
        ICollection<Recipe> GetAllRecipes();
        Recipe GetRecipeById(int id);
        bool RecipeExists(int id);
    }
}

