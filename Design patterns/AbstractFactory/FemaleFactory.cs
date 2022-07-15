using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactory
{
    internal class FemaleFactory : IAnimalFactory
    {
        public IChicken CreateChicken()
        {
            return new FemaleChicken("Rosita");
        }

        public IDog CreateDog()
        {
            return new FemaleDog("Kylie");
        }
    }
}
