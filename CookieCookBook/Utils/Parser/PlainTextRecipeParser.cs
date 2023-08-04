using CookieCookBook.Models.Recipes;

namespace CookieCookBook.Utils.Parser
{
	public class PlainTextRecipeParser : IRecipeParser
	{

        public List<Recipe> FromText(string text)
        {
            List<Recipe> recipes = text.Split(Environment.NewLine)
                .Select(Recipe.FromCommaSeperatedText).ToList();
            return recipes;
        }

        public string ToText(List<Recipe> recipes)
        {
            return String.Join(
                Environment.NewLine,
                recipes.Select(ToText)
            );
        }

        private string ToText(Recipe recipe)
        {
            return recipe.ToString();
        }

    }
}

