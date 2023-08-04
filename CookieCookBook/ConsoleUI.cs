using System;
namespace CookieCookBook
{
	public class ConsoleUI : IUserInterface
	{
		public ConsoleUI()
		{
		}

        public string Read()
        {
            return Console.ReadLine();
        }

        public void Write(string? text)
        {
            Console.WriteLine(text);
        }
    }
}

