using System;
using CookieCookBook.Models;
using CookieCookBook.Utils.Parser;

namespace CookieCookBook.Configuration
{
	public class FileSetting
	{
		public FileFormat Format = FileFormat.Json;
		public string Name = "untitled";

		public string BuildPath() => $"{Name}{FileExtension()}";

		private string FileExtension() => Format switch {
			FileFormat.Text => ".txt",
			_=> ".json"
		};

		public IRecipeParser GetParser()
		{
			return Format switch {
				FileFormat.Text => new PlainTextRecipeParser(),
				_=> new JsonRecipeParser()
			};
		}
	}
}

