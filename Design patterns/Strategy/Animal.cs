using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Strategy
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public IFliable FlyingType{ get; set; }

        public Animal(string name,string sound,IFliable flyingType)
        {
            this.Name = name;
            this.Sound= sound;
            this.FlyingType = flyingType;   
        }

        public void Play()
        {
            Console.WriteLine(this.Sound);
        }

        public void TryToFly()
        {
            this.FlyingType.Fly();
        }

        public void setFlyingAbility(IFliable newFilyType)
        {
            this.FlyingType = newFilyType;
        }
    }
}
