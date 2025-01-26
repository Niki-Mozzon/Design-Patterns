using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Email : IObserver
    {
        public int Emails = 0;
        public void Update()
        {
            Emails++;
        }

    }
}
