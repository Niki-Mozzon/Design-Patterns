using DesignPatterns.Data;

namespace DesignPatterns.Behavioral.Command
{
	public class Mechanic : ICommand
    {
        private readonly EVehicle Vehicle;
        public Mechanic(EVehicle vehicle)
        {
            Vehicle = vehicle;
        }
        public EAction Execute()
        {
            //Using fields as args
            if (Vehicle == EVehicle.Car)
            {
                return EAction.FixCar;
            }
            else
            {
                return EAction.FixBike;
            }
        }
    }

}
