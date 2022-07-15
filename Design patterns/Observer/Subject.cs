using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Observer
{
    internal class Subject : ISubject
    {
        //using index as banal way to implement some logic
        int index;

        //I have a list of listeners
        private List<IObserver> listeners = new List<IObserver>();

        public void NotifyObserver()
        {

            foreach (var listener in listeners)
            {
                listener.Update(this.index);
            }
        }

        public void Register(IObserver newObserver)
        {
            listeners.Add(newObserver);
        }

        public void Unregister(IObserver deleteObserver)
        {
            listeners.Remove(deleteObserver);
        }


        internal async Task DoSomething()
        {
            while (true)
            {
            this.index++;

            await Task.Delay(1000);

            this.NotifyObserver();
            Console.WriteLine("Index: " + index);
            }

        }
    }
}
