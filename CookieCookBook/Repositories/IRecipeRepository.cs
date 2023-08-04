using System;
using CookieCookBook.Models.Recipes;

namespace CookieCookBook.Repositories
{
	public interface IRecipeRepository
	{
		void Write(Recipe recipe);
		List<Recipe> Read();
	}
}

