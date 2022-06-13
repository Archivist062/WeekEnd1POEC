using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part3
{
	internal class Actor : IComparable<Actor>
	{
		public string name;
		public List<string> filmIds; 

		int IComparable<Actor>.CompareTo(Actor other)
        {
			return filmIds.Count() - other.filmIds.Count();
        }
	}
}
