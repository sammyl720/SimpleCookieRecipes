using System;
using CookieCookBook.Configuration;
using System.IO;
using CookieCookBook.Models.Recipes;
using CookieCookBook.Utils.Parser;

namespace CookieCookBook.Repositories
{
	public class DataAccessRepository : IRecipeRepository
	{
        private readonly string filePath;
        private readonly IRecipeParser parser;
		public DataAccessRepository(FileSetting fileSetting)
		{
            this.filePath = fileSetting.BuildPath();
            this.parser = fileSetting.GetParser();
        }

        public List<Recipe> Read()
        {
            if (!File.Exists(filePath))
            {
                return new List<Recipe>();
            }

            var text = File.ReadAllText(filePath);
            return parser.FromText(text);
        }

        public void Write(Recipe recipe)
        {
            var recipes = this.Read();
            recipes.Add(recipe);
            var text = parser.ToText(recipes);
            File.WriteAllText(filePath, text);
        }
    }
}

