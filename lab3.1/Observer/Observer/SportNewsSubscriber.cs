using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class SportNewsSubscriber : INewsSubscriber
    {
        private readonly SportNewsPublisher _publisher;

        public SportNewsSubscriber(SportNewsPublisher publisher)
        {
            _publisher = publisher;
            _publisher.AddSubscriber(this);
        }

        public void Update()
        {
            string info = _publisher.GetLastSportInfo();
            Console.WriteLine($"Sport Subscriber {this.GetHashCode()} updated info: {info}");
        }
    }
}
