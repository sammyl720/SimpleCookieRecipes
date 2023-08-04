using System;
using CookieCookBook.Models.Recipes;

namespace CookieCookBook.Repositories
{
	public class RecipRepository : IRecipeRepository
	{
		private readonly IRecipeRepository dataRepository;
		public RecipRepository(IRecipeRepository dataRepository)
		{
            this.dataRepository = dataRepository;
        }

        public void Write(Recipe recipe)
        {
            dataRepository.Write(recipe);
        }

        public List<Recipe> Read()
        {
            return dataRepository.Read();
        }
    }
}

