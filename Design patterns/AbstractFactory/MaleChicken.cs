using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactory
{
    internal class MaleChicken : IChicken
    {
        public string Name { get; set; }
        public MaleChicken(string name)
        {
            this.Name = name;
        }

        public void MakeEgg()
        {
            Console.WriteLine("Cannot make any egg!");
        }
    }
}
