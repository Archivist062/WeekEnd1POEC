using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1
{
	internal class Part2Start
	{
		static Part2.Song SongFromLine(IEnumerable<string> strings)
		{
			var line = strings.ToList();
			int year;
			int? songYear = null;
			if(int.TryParse(line[17], out year))
			{
				songYear = year;
			}
			var song = new Part2.Song(line[16], songYear);
			song.Creators.Add(new Part2.Artist(line[8]));
			return song;
		}

		static List<Part2.Album> ReadAlbums(IEnumerable<string[]> data)
		{
			return data.GroupBy(
				x => x[3], 
				(key, lines) =>
				{
					var album =  new Part2.Album();

					album.songs = lines.Select(x => SongFromLine(x)).ToList();

					var albumDateRatio = album.songs.Select(x => x.Year).Aggregate(new Tuple<int, int>(0, 0), (seed, value) =>
					{
						if (value.HasValue)
						{
							return new Tuple<int, int>(1, value.Value);
						}
						return seed;
					});

					album.year = albumDateRatio.Item2 / albumDateRatio.Item1;

					return album;
				}
			).ToList();
		}

		static void Main(string[] args)
		{
			var lines = File.ReadAllLines(@"..\..\..\SongCSV.csv").Select(x => x.Split(',')).Skip(1);

			var mostPopularYearsAlbums = ReadAlbums(lines)
				.Where(x => x.year != 0)
				.GroupBy(x => x.year, (key, set) => new Tuple<int, int>(set.Count(), key))
				.OrderBy(x => x.Item1)
				.Reverse()
				.Take(10);

			foreach(var mostPopularYear in mostPopularYearsAlbums)
			{
				Console.WriteLine(String.Format(@"{0} albums in {1}", mostPopularYear.Item1, mostPopularYear.Item2));
			}
			Console.WriteLine("-----");
			var mostPopularYearsSongs = lines.Select(x => SongFromLine(x))
				.Where(x => x.Year.HasValue)
				.Where(x => x.Year.Value != 0)
				.GroupBy(
					x => x.Year.Value, 
					(key, list) => new Tuple<int, int>(list.Count(), key)
				)
				.OrderBy(x => x.Item1)
				.Reverse()
				.Take(10);
			foreach (var mostPopularYear in mostPopularYearsSongs)
			{
				Console.WriteLine(String.Format(@"{0} songs in {1}", mostPopularYear.Item1, mostPopularYear.Item2));
			}
		}
	}
}
