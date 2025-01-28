using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Data
{
	public enum EAction
	{
		MowLawn,
		FixCar,
		FixBike
	}

	public enum EVehicle
	{
		Car,
		Bike
	}

	public enum ECarType
	{
		SUV, Sport, StationWagon
	}

    public class Passenger
    {
        public bool hasTicket { get; set; }
        public bool hasAllowedGoods { get; set; }
        public bool hasPassport { get; set; }
    }
}
