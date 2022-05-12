using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class SportNewsPublisher : NewsPublisher
    {
        private string _lastSportInfo;

        public void SetLastSportInfo(string info)
        {
            _lastSportInfo = info;
            NotifySubscribers();
        }

        public string GetLastSportInfo()
        {
            return _lastSportInfo;
        }
    }
}
