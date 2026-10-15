using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class EnergyMeter
    {
        private int _limit;
        private int _used;
        public int Limit { get { return _limit; } }
        public int Used { get { return _used; } }

        public EnergyMeter(int limit)
        {
            _limit = limit;
            _used = 0;
        }

        public bool Run(Device d, int hours)
        {
            if(!(d.Consumption(hours)> _limit))
            {
            _used += d.Consumption(hours);
            return true;
            }
            d.TurnOff();
            return false;
            
        }

        public int Remaining()
        {
            return _limit -= _used;
        }


    }
}
