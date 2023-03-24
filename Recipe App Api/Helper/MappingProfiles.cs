using AutoMapper;
using Recipe_App_Api.DTO;
using Recipe_App_Api.Models;

namespace Recipe_App_Api.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Recipe, RecipeDto>();
            CreateMap<Ingredient, IngredientDto>();
            CreateMap<RecipeStep, RecipeStepDto>();
        }
    }
}
