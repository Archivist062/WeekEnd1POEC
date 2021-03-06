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
            return ((IVehicle)carTemplate).LicencePlate();
        }

        public float MaxLegalSpeed()
        {
            return ((IRoadVehicle)carTemplate).MaxLegalSpeed();
        }

        public int MaxPassengerCount()
        {
            return ((ICar)carTemplate).MaxPassengerCount();
        }
    }
}
