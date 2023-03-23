using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Recipe_App_Api.DTO;
using Recipe_App_Api.Interfaces;
using Recipe_App_Api.Models;

namespace Recipe_App_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : Controller
    {
        private readonly IRecipeInterface _recipeRepository;
        private readonly IMapper _mapper;
        public RecipeController(IRecipeInterface recipeRepository, IMapper mapper)
        {
            this._recipeRepository = recipeRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Recipe>))]
        public IActionResult GetAllRecipes()
        {
            var recipes = _mapper.Map<List<RecipeDto>>(_recipeRepository.GetAllRecipes());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(recipes);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Recipe))]
        [ProducesResponseType(400)]
        public IActionResult GetRecipeById(int id)
        {
            if(!_recipeRepository.RecipeExists(id))
                return NotFound();

            var recipe = _mapper.Map<RecipeDto>(_recipeRepository.GetRecipeById(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(recipe);
        }

    }
}
