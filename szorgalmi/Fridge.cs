using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Fridge : Device
    {
        private bool _isEcoMode;
        public bool IsEcoMode { get { return _isEcoMode; }  set { _isEcoMode = value; } }
        public Fridge(string name, bool iseco) : base(name)
        {
            _isEcoMode = iseco;
            TurnOn();
        }

        public override int PowerUsage()
        {
            if (_isEcoMode)
            {
                return 100;
            }
            return 150;
        }

        public override string GetDescription()
        {
            if (IsEcoMode)
            {
             return base.GetDescription() + $", Eco mód";

            }
            return base.GetDescription() + $", normál mód";

        }
        public override bool TurnOff()
        {
            return false;
        }
    }
}
