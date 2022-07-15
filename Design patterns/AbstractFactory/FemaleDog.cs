using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactory
{
    internal class FemaleDog : IDog     
    {
        public string Name { get; set; }
        public FemaleDog(string name)
        {
            this.Name = name;   
        }

        public void DigHole()
        {
            Console.WriteLine("Doesn't gid any hole");
        }
    }
}
