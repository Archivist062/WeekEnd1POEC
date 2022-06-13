using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part2
{
	internal class Album
	{
		public ICreator figurehead;
		public int year;
		public List<Song> songs = new List<Song>();
	}
}
