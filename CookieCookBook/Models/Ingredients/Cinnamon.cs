namespace CookieCookBook.Models.Ingredients
{
    public class Cinnamon : HalfTeaspoon, IIngredient
    {
        public int Id => 7;

        public string Name => nameof(Cinnamon);
    }
}

