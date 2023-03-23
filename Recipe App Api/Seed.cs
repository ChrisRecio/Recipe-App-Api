using Recipe_App_Api.Data;
using Recipe_App_Api.Models;

namespace Recipe_App_Api
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!dataContext.Recipes.Any())
            {
                var recipes = new List<Recipe>()
                {
                    new Recipe()
                    {
                        Name = "Grilled Cheese Sandwich",
                        Image = "",
                        Servings = 1,
                        Description = "A grilled cheese sandwich",
                        CourseId = 1,
                        PrepTime = 5.0,
                        CookTime = 5.0,
                        PrepTimeMeasurement = "Minutes",
                        CookTimeMeasurement = "Minutes",
                        Ingredients = new List<Ingredient>()
                        {
                            new Ingredient(){RecipeId = 1, IngredientName = "Bread"},
                            new Ingredient(){RecipeId = 1, IngredientName = "Cheese"},
                            new Ingredient(){RecipeId = 1, IngredientName = "Butter"},
                        },
                        RecipeSteps = new List<RecipeStep>()
                        {
                            new RecipeStep(){RecipeId = 1, StepNumber = 1, StepDescription = "Spread butter on the outside of the bread"},
                            new RecipeStep(){RecipeId = 1, StepNumber = 2, StepDescription = "Place cheese between both slices of bread"},
                            new RecipeStep(){RecipeId = 1, StepNumber = 3, StepDescription = "Grill sandwich until golden brown"},
                        }
                    },

                    new Recipe()
                    {
                        Name = "Ham and Cheese Sandwich",
                        Image = "",
                        Servings = 1,
                        Description = "A ham and cheese sandwich",
                        CourseId = 1,
                        PrepTime = 5.0,
                        CookTime = 5.0,
                        PrepTimeMeasurement = "Minutes",
                        CookTimeMeasurement = "Minutes",
                        Ingredients = new List<Ingredient>()
                        {
                            new Ingredient(){RecipeId = 2, IngredientName = "Bread"},
                            new Ingredient(){RecipeId = 2, IngredientName = "Cheese"},
                            new Ingredient(){RecipeId = 2, IngredientName = "Ham"},
                        },
                        RecipeSteps = new List<RecipeStep>()
                        {
                            new RecipeStep(){RecipeId = 2, StepNumber = 1, StepDescription = "Place cheese between both slices of bread"},
                            new RecipeStep(){RecipeId = 2, StepNumber = 2, StepDescription = "Place ham between both slices of bread"},
                        }
                    },

                    new Recipe()
                    {
                        Name = "Pb & J Sandwich",
                        Image = "",
                        Servings = 1,
                        Description = "A peanut butter jelly sandwich",
                        CourseId = 1,
                        PrepTime = 5.0,
                        CookTime = 5.0,
                        PrepTimeMeasurement = "Minutes",
                        CookTimeMeasurement = "Minutes",
                        Ingredients = new List<Ingredient>()
                        {
                            new Ingredient(){RecipeId = 3, IngredientName = "Bread"},
                            new Ingredient(){RecipeId = 3, IngredientName = "Peanut Butter"},
                            new Ingredient(){RecipeId = 3, IngredientName = "Jam"},
                        },
                        RecipeSteps = new List<RecipeStep>()
                        {
                            new RecipeStep(){RecipeId = 3, StepNumber = 1, StepDescription = "Spread peanut butter on one slice of bread"},
                            new RecipeStep(){RecipeId = 3, StepNumber = 2, StepDescription = "Spread jam on the other slice of bread"},
                        }
                    },
                };
                dataContext.Recipes.AddRange(recipes);
                dataContext.SaveChanges();
            }
        }
    }
}
