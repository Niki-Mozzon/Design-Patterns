using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactory
{
    internal class MaleDog : IDog   
    {
        public string Name { get; set; }
        public MaleDog(string name)
        {
            this.Name = name;
        }

        public void DigHole()
        {
            Console.WriteLine("Digs a hole!");
        }
    }
}
