using System;
namespace CookieCookBook
{
	public interface IUserInterface
	{
		public string Read();

		public void Write(string? text = "");
	}
}

