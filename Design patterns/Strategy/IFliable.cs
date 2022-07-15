using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Strategy
{
    internal interface IFliable 
    {
        void Fly();
    }

    internal class CanFly : IFliable
    {
        public void Fly()
        {
            Console.WriteLine("Can fly!");
        }
    }


    internal class CannotFly : IFliable
    {
        public void Fly()
        {
            Console.WriteLine("Cannot fly!");
        }
    }

}
