using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Factory
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
    }
}
