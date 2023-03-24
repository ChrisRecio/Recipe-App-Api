using Recipe_App_Api.Models;

namespace Recipe_App_Api.Interfaces
{
    public interface IRecipeStepInterface
    {
        ICollection<RecipeStep> getAllRecipeStepsByRecipeId(int recipeId);
        RecipeStep getRecipeStepById(int recipeStepId);
        bool recipeSteptExists(int recipeStepId);
    }
}
