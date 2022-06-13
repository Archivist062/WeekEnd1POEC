using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part1
{
	internal class RenaultClio : ICar
	{
		CarTemplate carTemplate;

		public string LicencePlate()
		{
			return ((Part1.IVehicle)carTemplate).LicencePlate();
		}

		public float MaxLegalSpeed()
		{
			return ((Part1.IRoadVehicle)carTemplate).MaxLegalSpeed();
		}

		public int MaxPassengerCount()
		{
			return ((Part1.ICar)carTemplate).MaxPassengerCount();
		}
	}
}
