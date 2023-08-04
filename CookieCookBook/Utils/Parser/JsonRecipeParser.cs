using System;
using System.Text.Json;
using CookieCookBook.Models.Recipes;

namespace CookieCookBook.Utils.Parser
{
	public class JsonRecipeParser : IRecipeParser
	{

        public List<Recipe> FromText(string text)
        {
            var recipeList = JsonSerializer.Deserialize<List<string>>(text);
            return recipeList?.Select(Recipe.FromCommaSeperatedText).ToList() ?? new List<Recipe>();
        }

        public string ToText(List<Recipe> recipes)
        {
            var recipesAsTextList = recipes.Select(recipe => recipe.ToString()).ToList();
            return JsonSerializer.Serialize(recipesAsTextList);
        }
    }
}

