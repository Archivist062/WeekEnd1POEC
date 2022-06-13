using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part1
{
	internal class MercedesAccros : ITruck
	{
		TruckTemplate truckTemplate;

		public string LicencePlate()
		{
			return ((Part1.IVehicle)truckTemplate).LicencePlate();
		}

		public float MaxFreightKg()
		{
			return ((Part1.ITruck)truckTemplate).MaxFreightKg();
		}

		public float MaxLegalSpeed()
		{
			return ((Part1.IRoadVehicle)truckTemplate).MaxLegalSpeed();
		}
	}
}
