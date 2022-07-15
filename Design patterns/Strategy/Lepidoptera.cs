using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Strategy
{
    internal class Lepidoptera : Animal
    {
        public Lepidoptera(string name, string sound, IFliable flyingType) : base(name, sound,flyingType)
        {
        }
    }
}
