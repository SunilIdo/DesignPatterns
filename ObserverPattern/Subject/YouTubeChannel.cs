using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    public class YouTubeChannel
    {
        private IList<ISubscriber> subsCribers = new List<ISubscriber>();
        public void Subscribe(ISubscriber s)
        {
            subsCribers.Add(s);
        }
        public void UnSubscribe(ISubscriber s)
        {
            subsCribers.Remove(s);
        }
        public void NotifySubscribers()
        {
            foreach (ISubscriber s in subsCribers)
            {
                s.Notify();
            }
        }
    }
}
