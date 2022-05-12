using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class NewsPublisher
    {
        protected List<INewsSubscriber> _subscribers = new List<INewsSubscriber>();
        public void AddSubscriber(INewsSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(INewsSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in _subscribers)
                subscriber.Update();
        }
    }
}
