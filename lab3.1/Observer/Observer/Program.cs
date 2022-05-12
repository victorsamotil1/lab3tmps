using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            SportNewsPublisher sportPublisher = new SportNewsPublisher();

            SportNewsSubscriber sportSubscriber1 = new SportNewsSubscriber(sportPublisher);
            SportNewsSubscriber sportSubscriber2 = new SportNewsSubscriber(sportPublisher);

            sportPublisher.SetLastSportInfo("Chelsea - Arsenal 1:1");

            TechnologyNewsPublisher techPublisher = new TechnologyNewsPublisher();

            TechnologyNewsSubscriber techSubscriber1 = new TechnologyNewsSubscriber(techPublisher);
            TechnologyNewsSubscriber techSubscriber2 = new TechnologyNewsSubscriber(techPublisher);
            TechnologyNewsSubscriber techSubscriber3 = new TechnologyNewsSubscriber(techPublisher);

            techPublisher.SetLastRtxPrice(1000.0m);
        }
    }
}
