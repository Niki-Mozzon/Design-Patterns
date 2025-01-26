using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class FemaleFactory : IAnimalFactory
    {
        public IChicken CreateChicken()
        {
            return new FemaleChicken();
        }

        public IDog CreateDog()
        {
            return new FemaleDog();
        }
    }
}
