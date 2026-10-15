using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Heater : Device
    {
        private int _targetTemperature;
        public int TargetTemperature { 
            set {
                if (_targetTemperature < 5 || _targetTemperature > 30)
                {
                    _targetTemperature = 20;
                }
            }
        }

        public Heater(string name, int targetTemperature) : base(name)
        {
            _targetTemperature = targetTemperature;
        }

        public override int PowerUsage()
        {
            return _targetTemperature * 100;
        }

        public override string GetDescription()
        {
             return base.GetDescription() + $",{_targetTemperature}°C";
        }

        private bool _isWindowOpen;

        public bool IsWindowOpen { get { return _isWindowOpen; } }

        public bool OpenWindow()
        {
            _isWindowOpen = true;
            return TurnOff();
        }

        public void CloseWindow()
        {
            TurnOff();
        }

        public override bool TurnOn()
        {
            if (_isWindowOpen)
            {
                return false;
            }
            
            return base.TurnOn();
        }
    }
}
