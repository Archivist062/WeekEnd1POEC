using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part1
{
	internal class TruckTemplate : ITruck
	{
		string IVehicle.LicencePlate()
		{
			throw new NotImplementedException();
		}

		float ITruck.MaxFreightKg()
		{
			throw new NotImplementedException();
		}

		float IRoadVehicle.MaxLegalSpeed()
		{
			throw new NotImplementedException();
		}
	}
}
