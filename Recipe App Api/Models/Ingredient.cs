namespace Recipe_App_Api.Models
{
    //CREATE TABLE IF NOT EXISTS Ingredient(id INTEGER NOT NULL PRIMARY KEY autoincrement, recipeId INTEGER NOT NULL, ingredientName TEXT NOT NULL, FOREIGN KEY(recipeId) REFERENCES Recipe(id));
    public class Ingredient
    {
        private int _id;
        private int _recipeId;
        private string? _IngredientName;

        public int Id { get => _id; set => _id = value; }
        public int RecipeId { get => _recipeId; set => _recipeId = value; }
        public string? IngredientName { get => _IngredientName; set => _IngredientName = value; }
    }
}
