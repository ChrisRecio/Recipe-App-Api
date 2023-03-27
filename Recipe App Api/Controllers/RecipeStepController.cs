using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Recipe_App_Api.DTO;
using Recipe_App_Api.Interfaces;
using Recipe_App_Api.Models;

namespace Recipe_App_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RecipeStepController : Controller
    {
        private readonly IRecipeStepInterface _recipeStepRepository;
        private readonly IMapper _mapper;
        public RecipeStepController(IRecipeStepInterface recipeStepRepository, IMapper mapper)
        {
            this._recipeStepRepository = recipeStepRepository;
            this._mapper = mapper;
        }

        [HttpGet("GetAllRecipeStepsByRecipeId/{recipeId}", Name = "getAllRecipeStepsByRecipeId")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<RecipeStep>))]
        public IActionResult getAllRecipeStepsByRecipeId(int recipeId)
        {
            var recipeSteps = _mapper.Map<List<RecipeStepDto>>(_recipeStepRepository.getAllRecipeStepsByRecipeId(recipeId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(recipeSteps);
        }

        [HttpGet("GetRecipeStepById/{recipeStepById}", Name = "getRecipeStepById")]
        [ProducesResponseType(200, Type = typeof(Ingredient))]
        [ProducesResponseType(400)]
        public IActionResult getRecipeStepById(int ingredientId)
        {
            if (!_recipeStepRepository.recipeSteptExists(ingredientId))
                return NotFound();

            var recipeStep = _mapper.Map<RecipeStepDto>(_recipeStepRepository.getRecipeStepById(ingredientId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(recipeStep);
        }


    }
}
