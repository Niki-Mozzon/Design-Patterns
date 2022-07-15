using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Observer
{
    internal class Email : IObserver
    {
        public void Update(int index)
        {
            if(index%7 == 0)
            Console.WriteLine("Email: the index is now multiple of 7");
        }

    }
}
