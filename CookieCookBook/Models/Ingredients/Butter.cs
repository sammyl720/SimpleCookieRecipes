
namespace CookieCookBook.Models.Ingredients
{
	public class Butter : SimpleIngredient, IIngredient
	{
        public int Id => 3;

        public string Name => nameof(Butter);

        public override string Instructions => "Melt on low heat. " + base.Instructions;
    }
}

