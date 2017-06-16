using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class User : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("User has been updated new video.");
        }
    }
}
