using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class Subject : ISubject
    {
        //using index as banal way to implement some logic

        //I have a list of listeners
        private List<IObserver> listeners = new List<IObserver>();

        public void NotifyObserver()
        {

            foreach (var listener in listeners)
            {
                listener.Update();
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


        public void DoSomething()
        {
            NotifyObserver();
        }
    }
}
