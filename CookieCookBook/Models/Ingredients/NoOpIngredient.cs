using System;
namespace CookieCookBook.Models.Ingredients
{
	public class NoOpIngredient : IIngredient
	{
        public int Id => 0;

        public string Name => "Not Found";

        public string Instructions => "Ingredient does not exist";
    }
}

