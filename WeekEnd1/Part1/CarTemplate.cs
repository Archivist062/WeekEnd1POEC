﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekEnd1.Part1
{
	internal class CarTemplate : ICar
	{
		string IVehicle.LicencePlate()
		{
			throw new NotImplementedException();
		}

		float IRoadVehicle.MaxLegalSpeed()
		{
			throw new NotImplementedException();
		}

		int ICar.MaxPassengerCount()
		{
			throw new NotImplementedException();
		}
	}
}
