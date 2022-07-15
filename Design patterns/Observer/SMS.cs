using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Observer
{
    internal class SMS : IObserver
    {
        public void Update(int index)
        {
            if (index%5==0)
            {
            Console.WriteLine("SMS: the index is now multiple of 5");
            }
        }
    }
}
