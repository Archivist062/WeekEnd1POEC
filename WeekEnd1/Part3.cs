using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1
{
	internal class Part3Start
	{
		static void LoadFilmDatabase(IEnumerable<string[]> lines)
		{
			if (FilmDatabase == null) FilmDatabase = new Dictionary<string, Part3.Film>();
			int inserts = lines
				.Select(line => new Part3.Film(line))
				.Select(
					film => FilmDatabase.TryAdd(film.id, film)
				).Count(x => x);
			Console.WriteLine("{0} movies and shows loaded", inserts);
		}

		static Dictionary<string, Part3.Film> FilmDatabase;

		static IEnumerable<string[]> Normalize(IEnumerable<string[]> lines)
		{
			var supposedLength = lines.First().Count(); //< Count <- IEnumerable
			return lines.Skip(1).Where(x => supposedLength == x.Length); //< Length <- string[]
		}

		static void Main(string[] args)
		{
			var liste = File.ReadAllLines(@"..\..\..\NetflixCredits.csv").Select(x => x.Split(','));
			var linesCredits = Normalize(liste);
			var linesTitles = Normalize(File.ReadAllLines(@"..\..\..\NetflixTitles.csv").Select(x => x.Split(',')));

			LoadFilmDatabase(linesTitles);
			var actors = linesCredits.GroupBy(x => x[2], (name, credits) =>
			{
				var actor = new Part3.Actor();
				actor.name = name;
				actor.filmIds = credits.Select(x => x[1]).ToList();
				return actor;
			}).OrderByDescending(x => x).Take(10).ToList();
			
			foreach(var actor in actors)
			{
				Console.WriteLine("{0} movies for {1}", actor.filmIds.Count(), actor.name);
				foreach(var filmId in actor.filmIds)
				{
					Part3.Film film;
					if(FilmDatabase.TryGetValue(filmId, out film))
					{
						Console.WriteLine("\t{0}", film.title);
					}
				}
			}

			foreach(string v in liste.First())
            {
				Console.WriteLine(v);
            }
		}
	}
}
