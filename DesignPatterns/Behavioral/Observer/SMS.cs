using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class SMS : IObserver
    {
        public int Messages = 0;

        public void Update()
        {
            Messages++;
        }
    }
}
