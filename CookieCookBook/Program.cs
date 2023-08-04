using CookieCookBook.Configuration;
using CookieCookBook.Models;
using CookieCookBook.Repositories;
using CookieCookBook;

var fileSetting = new FileSetting
{
    Format = FileFormat.Text,
    Name = "recipes"
};

IRecipeRepository dataRepository = new DataAccessRepository(fileSetting);
IRecipeRepository recipeRepository = new RecipRepository(dataRepository);
IUserInterface userInterface = new ConsoleUI();

var app = new CookieRecipesApp(recipeRepository, userInterface);
app.Run();

Console.WriteLine("Press any character to exit...");
Console.ReadKey();