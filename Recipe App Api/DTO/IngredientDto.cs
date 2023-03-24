namespace Recipe_App_Api.DTO
{
    public class IngredientDto
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public string? IngredientName { get; set; }
    }
}
