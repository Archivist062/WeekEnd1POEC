using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part2
{
	internal class Artist : ICreator
	{
		public string Name;

		public Artist(string name)
		{
			Name = name;
		}
	}
}
