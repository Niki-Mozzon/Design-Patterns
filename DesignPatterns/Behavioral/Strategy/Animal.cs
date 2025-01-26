using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Animal
    {
        public IFliable FlyingType { get; set; }

        public Animal(IFliable flyingType)
        {
            FlyingType = flyingType;
        }


        public bool TryToFly()
        {
            return FlyingType.Fly();
        }

        public void setFlyingAbility(IFliable newFilyType)
        {
            FlyingType = newFilyType;
        }
    }
}
