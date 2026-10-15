using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class DimmableLight : Device
    {
        private int _brightness;
        public int Brightness {  
            set {
                if (_brightness < 0)
                {
                    Brightness = 0;
                }
                else if (_brightness > 100)
                {
                    Brightness = 100;
                }
                Brightness = value;
            } }
        public DimmableLight(string name, int brightness) : base(name)
        {
            _brightness = brightness;
        }

        public override int PowerUsage()
        {
            return _brightness / 10;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $", fényereje: {_brightness}%";
        }
    }
}
