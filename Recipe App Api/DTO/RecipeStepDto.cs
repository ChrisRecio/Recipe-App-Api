namespace Recipe_App_Api.DTO
{
    public class RecipeStepDto
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int StepNumber { get; set; }
        public string? StepDescription { get; set; }
    }
}
