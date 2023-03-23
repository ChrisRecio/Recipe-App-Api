namespace Recipe_App_Api.Models
{
    // Recipe(id INTEGER NOT NULL PRIMARY KEY autoincrement, name TEXT, image BLOB, servings INTEGER NOT NULL, description TEXT, courseId INTEGER NOT NULL, prepTime TIME, prepTimeMeasurement TEXT, cookTime TIME, cookTimeMeasurement TEXT,
    // FOREIGN KEY(courseId) REFERENCES Course(id))
    public class Recipe
    {
        private int _id;
        private string? _name;
        private string? _image;
        private int _servings;
        private string? _description;
        private int _courseId;
        private double _prepTime;
        private double _cookTime;
        private string? _prepTimeMeasurement;
        private string? _cookTimeMeasurement;

        private ICollection<Ingredient>? _ingredients;
        private ICollection<RecipeStep>? _recipeSteps;

        public int Id { get => _id; set => _id = value; }
        public string? Name { get => _name; set => _name = value; }
        public string? Image { get => _image; set => _image = value; }
        public int Servings { get => _servings; set => _servings = value; }
        public string? Description { get => _description; set => _description = value; }
        public int CourseId { get => _courseId; set => _courseId = value; }
        public double PrepTime { get => _prepTime; set => _prepTime = value; }
        public double CookTime { get => _cookTime; set => _cookTime = value; }
        public string? PrepTimeMeasurement { get => _prepTimeMeasurement; set => _prepTimeMeasurement = value; }
        public string? CookTimeMeasurement { get => _cookTimeMeasurement; set => _cookTimeMeasurement = value; }
        public ICollection<Ingredient>? Ingredients { get => _ingredients; set => _ingredients = value; }
        public ICollection<RecipeStep>? RecipeSteps { get => _recipeSteps; set => _recipeSteps = value; }
    }
}
