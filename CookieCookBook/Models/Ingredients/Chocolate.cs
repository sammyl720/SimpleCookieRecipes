
namespace CookieCookBook.Models.Ingredients
{
	public class Chocolate : SimpleIngredient, IIngredient
	{
		public int Id => 4;

		public string Name => nameof(Chocolate);

		public override string Instructions => "Melt in a water bath" + base.Instructions;
    }
}

