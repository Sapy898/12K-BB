using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal record VidioGame(string Title, string Publisher,int ReleaseYear)
    {
        // Készíts egy VideoGame nevű recordot!

        // A record az alábbi adatokat tárolja:
        // - Title : string – public, immutable
        // - Publisher : string – public, immutable
        // - ReleaseYear : int – private, immutable
        // - Price : int – private, mutable
        // - Rating : double – public, mutable
        private int _releaseYear {  get; init; } = ReleaseYear;
        private int _price {  get; set; }
        public double Rating { get; set; }

        

        // Készíts egy public függvényt, amely kiszámolja, hogy hány éves a játék a paraméterként kapott évben!
        public int HowOld(int y)
        {
            return y - _releaseYear;
        }
        // Készíts egy public függvényt, amely paraméterként kap egy összeget, és eldönti, hogy a játék megvásárolható-e a megadott összegből!
        //Ha igen, adja vissza azt a szöveget, hogy $"megvásárolható, marad {x} forintod", ha nem akkor $"még gyűjts rá, {xy} ft hiányzik"
        public string CanIBuy(int budget)
        {
            return _price <= budget? $"Megvásárolható, marad{budget-_price} forintod":$"még gyüjts{_price-budget} ft hiányzik";
        }
        // Készíts egy public függvényt, amely paraméterként kap egy új árat!
        // Az árat csak akkor módosítsa, ha az új ár nagyobb 0-nál!
        public void UpdatePrice(int newPrice)
        {
            _price = newPrice > 0 ? newPrice : _price;
        }
    }
}
