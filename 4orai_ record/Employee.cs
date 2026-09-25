using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal record Employee(string Name, string Position)
    {

        // Készíts egy Employee nevű recordot!

        // A record az alábbi adatokat tárolja:
        // - Name : string – public, immutable
        // - Position : string – public, immutable
        // - Salary : int – private, mutable
        // - WorkedHours : int – private, mutable
        // - OvertimeHours : int – private, mutable

        private int _salary {  get; set; }
        private int _workedHours {  get; set; }
        private int _overtimeHours {  get; set; }
        // Készíts egy private függvényt, amely kiszámolja az órabért!
        // Az órabér kiszámításához a fizetést oszd el 160-nal!
        private double Calc()
        {
            return _workedHours / 160.0;
        }
        // Készíts egy public függvényt, amely a private órabérszámító függvény segítségével kiszámolja a túlórákért járó összeget!
        // Egy túlóra az alap órabér 150%-át érje!
        public double Calc2() 
        { 
            return Calc() * _overtimeHours * 1.5; 
        }

        // Készíts egy public függvényt, amely paraméterként kap egy ledolgozott óraszámot!
        // Ha a dolgozó eléri a 160 órát, az ezen felüli órákat az OvertimeHours értékéhez adja hozzá!
        public void UpdateWage(int hours)
        {
            if(_workedHours + hours >= 160)
            {
                _overtimeHours += (_workedHours + hours - 160);
            }
            //_workedHours + hours > 160 ? _overtimeHours += hours : _overtimeHours;
        }
    }
}
