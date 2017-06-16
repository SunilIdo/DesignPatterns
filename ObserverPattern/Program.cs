using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel myChannel = new YouTubeChannel();
            ISubscriber Joey = new User();
            ISubscriber Alex = new User();
            ISubscriber Gal = new Moderator();
            myChannel.Subscribe(Joey);
            myChannel.Subscribe(Alex);
            myChannel.Subscribe(Gal);
            myChannel.NotifySubscribers();
            Console.ReadKey();
        }
    }
}
