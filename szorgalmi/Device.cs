using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public abstract class Device
    {
        private string _name;
        private bool _isOn;
        public string Name { get { return _name; } set { _name = value; } }
        public bool IsOn { get { return _isOn; }}

        private static int _count = 0;
        public int Count { get { return _count; } }
        public Device(string name) 
        {
            _name = name ;
            _isOn = false;
            _count++;
        }

        public virtual bool TurnOn()
        {
            if (!_isOn)
            {
                _isOn = true;
                return true;
            }
            return false;
        }

        public virtual bool TurnOff()
        {
            if (_isOn)
            {
                _isOn = false;
                return true;
            }
            return false;
        }
        public virtual string GetDescription()
        {
            if (IsOn)
            {
            return $"Eszköz: {_name}, (be van kapcsolva)";
            }
            else
            {
                return $"Eszköz: {_name}, (ki van kapcsolva)";
            }
        }

        public abstract int PowerUsage();

        public int Consumption(int hours)
        {
            if (IsOn)
            {
                return PowerUsage() * hours;
            }
            return 0;
        }

        public static Device MoreConsuming(Device first, Device second, int hours)
        {
            Device most = null;
            if(first.Consumption(hours) > second.Consumption(hours))
            {
                most = first;
            }
            else
            {
                most = second;
            }

            return most;
            
        }
    }
}
