using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Bird : Animal
    {

        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }

        public Bird(IFliable flyingType) : base(flyingType)
        {

        }
    }
}
