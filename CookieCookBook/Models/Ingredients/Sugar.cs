using System;
namespace CookieCookBook.Models.Ingredients
{
    public class Sugar : SimpleIngredient, IIngredient
    {
        public int Id => 5;

        public string Name => "Sugar";
    }
}

