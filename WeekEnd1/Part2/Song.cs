using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part2
{
	internal class Song
	{
		public List<ICreator> Creators { get; } = new List<ICreator>();
		public string Title { get; }
		public int? Year { get;  }

		public Song(string title, int? year)
		{
			Title = title;
			Year = year;
		}
	}
}
