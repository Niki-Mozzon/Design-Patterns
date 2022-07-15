using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Factory
{
    internal class Quadruped:Animal
    {

        public Quadruped(string name,int legs)
        {
            this.Name = name;
            this.Legs = legs;
        }
    }
}
