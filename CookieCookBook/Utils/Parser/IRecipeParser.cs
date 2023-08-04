using System;
using CookieCookBook.Models.Recipes;

namespace CookieCookBook.Utils.Parser
{
	public interface IRecipeParser
	{
		List<Recipe> FromText(string text);

		string ToText(List<Recipe> recipes);
	}
}