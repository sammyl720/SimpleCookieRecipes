using System;
namespace CookieCookBook.Models.Ingredients
{
	public class IngredientFactory
	{
		public static List<IIngredient> ingredients = new List<IIngredient>
		{
			
			new WheatFlour(),
			new CoconutFlour(),
			new Butter(),
			new Chocolate(),
			new Sugar(),
			new Cardamom(),
			new Cinnamon(),
			new CocoaPowder()
		};

		public static IIngredient GetById(int Id)
		{
			return ingredients.ElementAt(Id - 1) ?? new NoOpIngredient();
		}

		public static void PrintOptions()
		{
			foreach (var ingredient in ingredients)
			{
				Console.WriteLine(ingredient.Describe());
			}
		}
	}
}

