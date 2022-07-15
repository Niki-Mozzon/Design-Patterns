using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Factory
{
    internal class AnimalFactory
    {
        internal Animal CreateAnimal(string name,int legs)
        {
            switch (legs)
            {
                case 2:
                    return new Biped(name, legs);
                case 4:
                    return new Quadruped(name,legs);
                default:
                    throw new Exception();
            }
        }
    }
}
