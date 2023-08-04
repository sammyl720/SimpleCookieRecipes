using System;
namespace CookieCookBook.Models.Ingredients
{
	public interface IIngredient : IInstruction
	{
		public int Id { get; }
		public string Name { get; }
	}

	public static class IngredientExtensions {
		public static string Details(this IIngredient ingredient)
		{
			return $"{ingredient.Name}. {ingredient.Instructions}";
		}

		public static string Describe(this IIngredient ingredient)
		{
			return $"{ingredient.Id}. {ingredient.Name}";
		}
	}


}

