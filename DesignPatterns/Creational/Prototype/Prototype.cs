using DesignPatterns.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
	public interface IPrototype
	{
		public IPrototype Clone();
	}

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
