
namespace CookieCookBook.Models.Ingredients
{
    public class Cardamom : HalfTeaspoon, IIngredient
    {
        public int Id => 6;

        public string Name => nameof(Cardamom);
    }
}

