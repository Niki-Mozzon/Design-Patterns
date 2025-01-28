using DesignPatterns.Data;

namespace DesignPatterns.Creational.Prototype
{
    public class Car : IPrototype
	{
		public ECarType Type { get; set; }
		// I make the constructor public only for the sake of the example
		public Car(ECarType type)
		{
			Type = type;
		}

		public IPrototype Clone()
		{
			return new Car(Type);
		}
	}
}
