using System;
using CookieCookBook.Models.Ingredients;
using CookieCookBook.Models.Recipes;
using CookieCookBook.Repositories;

namespace CookieCookBook
{
	public class CookieRecipesApp
	{
        private readonly IRecipeRepository recipeRepository;
        private readonly IUserInterface userInterface;

        public CookieRecipesApp(
            IRecipeRepository recipeRepository,
            IUserInterface userInterface 
        )
		{
            this.recipeRepository = recipeRepository;
            this.userInterface = userInterface;
        }

		public void Run()
		{
            var recipes = recipeRepository.Read();
            if (recipes.Count > 0)
            {
                userInterface.Write("Existing recipes are: ");
                userInterface.Write();

                foreach (var item in recipes.Select((recipe, index) => new { recipe, index }))
                {

                    userInterface.Write($"*****{item.index + 1}*****");
                    item.recipe.Print();
                    userInterface.Write();
                }
            }

            userInterface.Write("Create a new cookie recipe! Available ingredients are: ");
            IngredientFactory.PrintOptions();
            var ingredients = new List<IIngredient>();

            while (true)
            {
                Console.WriteLine("Add an ingredient by its ID or type anthing else if finished");
                var ingredientId = userInterface.Read().ToInt();
                if (ingredientId == 0)
                {
                    break;
                }

                var ingredient = IngredientFactory.GetById(ingredientId);

                if (ingredient is not NoOpIngredient)
                {
                    ingredients.Add(ingredient);
                }
            }

            if (ingredients.Count > 0)
            {
                var recipe = new Recipe(ingredients);
                recipeRepository.Write(recipe);
                userInterface.Write("Recipe added:");
                recipe.Print();
            }
            else
            {
                userInterface.Write("No ingredients have been selected. Recipe will not be saved.");
            }

        }
    }
}

