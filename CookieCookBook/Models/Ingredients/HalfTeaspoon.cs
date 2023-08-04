using System;
namespace CookieCookBook.Models.Ingredients
{
	public class HalfTeaspoon : SimpleIngredient, IInstruction
	{
		public override string Instructions => "Take half a teaspoon. " + base.Instructions;
	}
}

