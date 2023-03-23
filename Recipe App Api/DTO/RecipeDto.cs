namespace Recipe_App_Api.DTO
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public int Servings { get; set; }
        public string? Description { get; set; }
        public int CourseId { get; set; }
        public double PrepTime { get; set; }
        public double CookTime { get; set; }
        public string? PrepTimeMeasurement { get; set; }
        public string? CookTimeMeasurement { get; set; }
    }
}
