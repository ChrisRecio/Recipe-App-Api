using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Recipe_App_Api.DTO;
using Recipe_App_Api.Interfaces;
using Recipe_App_Api.Models;

namespace Recipe_App_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : Controller
    {
        private readonly IIngredientInterface _ingredientRepository;
        private readonly IMapper _mapper;
        public IngredientController(IIngredientInterface ingredientRepository, IMapper mapper)
        {
            this._ingredientRepository = ingredientRepository;
            this._mapper = mapper;
        }

        [HttpGet("GetAllIngredientsByRecipeId/{recipeId}", Name = "getAllIngredientsByRecipeId")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Ingredient>))]
        public IActionResult getAllIngredientsByRecipeId(int recipeId)
        {
            var ingredients = _mapper.Map<List<IngredientDto>>(_ingredientRepository.getAllIngredientsByRecipeId(recipeId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ingredients);
        }

        [HttpGet("GetIngredientById/{ingredientId}", Name = "getIngredientById")]
        [ProducesResponseType(200, Type = typeof(Ingredient))]
        [ProducesResponseType(400)]
        public IActionResult getIngredientById(int ingredientId)
        {
            if (!_ingredientRepository.ingredientExists(ingredientId))
                return NotFound();

            var ingredient = _mapper.Map<IngredientDto>(_ingredientRepository.getIngredientById(ingredientId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ingredient);
        }

    }

}
