using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal record Student(string Name,string Classname, int BirthYear)
    {
        private double _average {  get; set; }
        // 2. feladat – Student

        // Készíts egy Student nevű recordot!

        // A record az alábbi adatokat tárolja:
        // - Name : string – public, immutable
        // - ClassName : string – public, immutable
        // - BirthYear : int – public, immutable
        // - Average : double – private, mutable

        // Készíts egy public függvényt, amely paraméterként kap egy új átlagot!
        // Az Average értékét csak akkor módosítsa, ha a kapott érték 1.0 és 5.0 közé esik!
        public void UpdateAverage(double avg)
        {
            _average= avg >=1.0 && avg <= 5.0 ? avg : _average;
        }
        // Készíts egy public függvényt, amely az átlag alapján visszaad egy szöveges értékelést:
        // 4.5 vagy felette: "Kiváló"
        // 3.5 vagy felette: "Jó"
        // 2.0 vagy felette: "Megfelelt"
        // 2.0 alatt: "Fejlesztendő"
        public string Grading()
        {
            switch (_average)
            {
                case < 2.0:
                    return "Fejlesztendő";
                case < 3.5:
                    return "Megfelelt";
                case < 4.5:
                    return "Jó";
                case > 4.5:
                    return "Kiváló";
                default:
                    return "---";
            }
            
        }
    }
}
