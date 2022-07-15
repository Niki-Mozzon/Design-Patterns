using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactory
{
    internal class FemaleChicken : IChicken
    {
        public string Name { get; set; }
        public FemaleChicken(string name)
        {
            this.Name = name;
        }

        public void MakeEgg()
        {
            Console.WriteLine("Makes an egg.");
        }
    }
}
