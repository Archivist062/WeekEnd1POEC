using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part2
{
	internal class Band : ICreator
	{
		List<Artist> artists = new List<Artist>();
		string name;
	}
}
