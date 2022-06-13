using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part3
{
	public enum FilmType
	{
		Movie, Show, Other
	}
	internal class Film
	{
		public Film(string[] line)
		{
			id = line[0];
			title = line[1];
			description = line[3];
			switch(line[2].ToLowerInvariant())
			{
				case "movie":
					{
						type = FilmType.Movie;
					}break;
				case "show":
					{
						type = FilmType.Show;
					}
					break;
				default:
					type = FilmType.Other;
					break;
			}

		}

		public string id;
		public string title;
		public string description;
		public FilmType type;

	}
}
