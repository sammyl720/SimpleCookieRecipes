using System;
using CookieCookBook.Models.Ingredients;

namespace CookieCookBook.Models.Recipes
{
    public class Recipe
    {
        public List<IIngredient> ingredients = new List<IIngredient>();
        public Recipe()
        {

        }

        public Recipe(List<IIngredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void Print()
        {
            foreach (var item in ingredients)
            {
                Console.WriteLine(item.Details());
            }
        }

        public override string ToString()
        {
            return String.Join(',', ingredients.Select(ingredient => ingredient.Id));
        }

        public static Recipe FromCommaSeperatedText(string commaSeperatedText)
        {
            var ingredients = commaSeperatedText.Split(",").Select(fromTextId).ToList();
            return new Recipe(ingredients);
        }

        private static IIngredient fromTextId(string textId)
        {
            return IngredientFactory.GetById(textId.ToInt());
        }
    }

    public static class StringExtensions
    {
        public static int ToInt(this string text)
        {
            int integer = int.TryParse(text, out integer) ? integer : 0;
            return integer;
        }
    }
}

