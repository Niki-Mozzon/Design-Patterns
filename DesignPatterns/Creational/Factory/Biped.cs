using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class Biped : Animal
    {
        public Biped(int legs)
        {
            Legs = legs;
        }
    }
}
