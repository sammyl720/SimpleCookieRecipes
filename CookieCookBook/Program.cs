using CookieCookBook.Configuration;
using CookieCookBook.Models;
using CookieCookBook.Models.Ingredients;
using CookieCookBook.Models.Recipes;
using CookieCookBook.Repositories;

var fileSetting = new FileSetting
{
    Format = FileFormat.Json,
    Name = "recipes"
};

IRecipeRepository dataRepository = new DataAccessRepository(fileSetting);
IRecipeRepository recipeRepository = new RecipRepository(dataRepository);

var recipes = recipeRepository.Read();

if (recipes.Count > 0)
{
    Console.WriteLine("Existing recipes are: ");
    Console.WriteLine();

    foreach (var item in recipes.Select((recipe, index) => new { recipe, index }))
    {
        
        Console.WriteLine($"*****{item.index + 1}*****");
        item.recipe.Print();
        Console.WriteLine();
    }
}

Console.WriteLine("Create a new cookie recipe! Available ingredients are: ");
IngredientFactory.PrintOptions();
var ingredients = new List<IIngredient>();

while(true)
{
    Console.WriteLine("Add an ingredient by its ID or type anthing else if finished");
    var ingredientId = Console.ReadLine().ToInt();
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
    Console.WriteLine("Recipe added:");
    recipe.Print();
}
else
{
    Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
}

Console.WriteLine("Press any character to exit...");
Console.ReadKey();