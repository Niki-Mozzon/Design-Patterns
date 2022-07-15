using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactory
{
    internal class MaleFactory : IAnimalFactory
    {
        public IChicken CreateChicken()
        {
            return new MaleChicken("Rodrigo");
        }

        public IDog CreateDog()
        {
            return new MaleDog("Fido");
        }
    }
}
