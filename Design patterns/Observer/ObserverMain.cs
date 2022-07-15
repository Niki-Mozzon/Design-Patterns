using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Observer
{
    public class ObserverMain
    {
        //The observer allows us to trigger/inform various services about an event
        public static async Task RunAsync()
        {
            //The subject is what the observers are subscribed
            Subject subject = new();
            //I create some future observers
            SMS smsService = new SMS();
            Email emailService = new Email();
            //I subscribe some observer
            subject.Register(smsService);
            subject.Register(emailService);
            await subject.DoSomething();
            //I unsubscribe an observer
            subject.Unregister(smsService);
            

        }
    }
}
