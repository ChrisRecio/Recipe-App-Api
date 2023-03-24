using Recipe_App_Api.Data;
using Recipe_App_Api.Interfaces;
using Recipe_App_Api.Models;

namespace Recipe_App_Api.Repository
{
    public class RecipeStepRepository : IRecipeStepInterface
    {
        private readonly DataContext _context;
        public RecipeStepRepository(DataContext context)
        {
            this._context = context;
        }
        public ICollection<RecipeStep> getAllRecipeStepsByRecipeId(int recipeId)
        {
            var query = _context.RecipeSteps.Where(x => x.RecipeId == recipeId).OrderBy(x=> x.StepNumber).ToList();
            return query;
        }

        public RecipeStep getRecipeStepById(int recipeStepId)
        {
            var query = _context.RecipeSteps.Where(x => x.Id == recipeStepId).FirstOrDefault();
            return query;
        }

        public bool recipeSteptExists(int recipeStepId)
        {
            return _context.RecipeSteps.Any(p => p.Id == recipeStepId);
        }
    }
}
