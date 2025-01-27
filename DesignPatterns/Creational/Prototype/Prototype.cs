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
        public IPrototype Clone()
        {
            return this;
        }
    }
}
