using System;
namespace CookieCookBook.Models.Ingredients
{
	public class Flour : SimpleIngredient, IInstruction
	{
        public override string Instructions => "Sieve. " + base.Instructions;
    }
}

