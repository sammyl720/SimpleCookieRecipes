using System;
namespace CookieCookBook.Models.Ingredients
{
	public class SimpleIngredient : IInstruction
	{
        public virtual string Instructions => "Add to other ingredients.";
    }
}

