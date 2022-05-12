using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class TechnologyNewsPublisher : NewsPublisher
    {
        private decimal _rtxPrice;

        public void SetLastRtxPrice(decimal price)
        {
            _rtxPrice = price;
            NotifySubscribers();
        }

        public decimal GetLastRtxPrice()
        {
            return _rtxPrice;
        }
        
    }
}
