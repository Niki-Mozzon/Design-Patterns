using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class Quadruped : Animal
    {
        public Quadruped(int legs)
        {
            Legs = legs;
        }
    }
}
