namespace Recipe_App_Api.Models
{
    // CREATE TABLE IF NOT EXISTS RecipeStep(id INTEGER NOT NULL PRIMARY KEY autoincrement, recipeId INTEGER NOT NULL, stepNumber INTEGER NOT NULL, stepDescription TEXT, FOREIGN KEY(recipeId) REFERENCES Recipe(id));
    public class RecipeStep
    {
        private int _id;
        private int _recipeId;
        private int _stepNumber;
        private string? _stepDescription;

        public int Id { get => _id; set => _id = value; }
        public int RecipeId { get => _recipeId; set => _recipeId = value; }
        public int StepNumber { get => _stepNumber; set => _stepNumber = value; }
        public string? StepDescription { get => _stepDescription; set => _stepDescription = value; }
    }
}
