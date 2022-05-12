using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class TechnologyNewsSubscriber : INewsSubscriber
    {
        private readonly TechnologyNewsPublisher _publisher;

        public TechnologyNewsSubscriber(TechnologyNewsPublisher publisher)
        {
            _publisher = publisher;
            _publisher.AddSubscriber(this);
        }

        public void Update()
        {
            decimal lastPrice = _publisher.GetLastRtxPrice();
            Console.WriteLine($"Tech Subscriber {this.GetHashCode()} updated last price: {lastPrice}");
        }
    }
}
