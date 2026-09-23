using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Model
    {

        public List<Game> games = new();
        private void Import(string filename)
        {
            games = File.ReadAllLines(filename)
                .Select(x => new Game(x)).ToList();
        }
        public Model()
        {
            Import("games.txt");
        }
        // 1. Készíts egy függvényt, amely kiadó szerint csoportosítja a játékokat, majd megadja, hogy az egyes kiadókhoz hány játék tartozik!
        public Dictionary<string, int> GroupByProducerCount()
        {
            return games.GroupBy(x => x.Producer).ToDictionary(x => x.Key, y => y.Count());
        }
        // 2. Készíts egy függvényt, amely műfaj szerint csoportosítja a játékokat, majd megadja, hogy az egyes műfajokhoz hány játék tartozik!
        public Dictionary<string, int> GroupByTypeCount()
        {
            return games.GroupBy(x=>x.Type).ToDictionary(x => x.Key, y => y.Count());
        }
        // 3. Készíts egy függvényt, amely kiadó szerint csoportosítja a játékokat, majd kiszámolja az egyes kiadókhoz tartozó játékok átlagos árát!
        public Dictionary<string, double> GroupByProducerAveragePrice()
        {
            return games.GroupBy(x => x.Producer).ToDictionary(x => x.Key, y => y.Average(z => z.Price));
        }
        // 4. Készíts egy függvényt, amely műfaj szerint csoportosítja a játékokat, majd kiszámolja az egyes műfajokhoz tartozó játékok átlagos értékelését!
        public Dictionary<string, double> GroupByTypeAverageRating()
        {
            return games.GroupBy(x => x.Type).ToDictionary(x => x.Key, y => y.Average(z => z.Rating));
        }
        // 5. Készíts egy függvényt, amely kiadó szerint csoportosítja a játékokat, majd minden kiadónál megkeresi a legmagasabb értékelést! Az eredményben a kiadó neve és a hozzá tartozó legmagasabb értékelés szerepeljen!
        public Dictionary<string, double> GroupByProducerMaxRating()
        {
            return games.GroupBy(x => x.Producer).ToDictionary(x => x.Key, y => y.Max(z => z.Rating));
        }
        // 6. Készíts egy függvényt, amely műfaj szerint csoportosítja a játékokat, majd minden műfajnál megkeresi a legdrágább játék nevét! Az eredményben a műfaj és a játék neve szerepeljen!
        public Dictionary<string, string> GroupByTypeMaxPrice()
        {
            return games.GroupBy(x => x.Type).ToDictionary(x => x.Key, y => y.OrderByDescending(z => z.Price).First().Name);
        }
        // 7. Készíts egy függvényt, amely kiadó szerint csoportosítja a játékokat, majd visszaadja azoknak a kiadóknak a nevét, amelyekhez legalább 4 játék tartozik!
        public List<string> GroupByProducerAtLeast4Games()
        {
            return games.GroupBy(x => x.Producer).Where(x => x.Count() >= 4).Select(x => x.Key).ToList();
        }
        // 8. Készíts egy függvényt, amely kiadó szerint csoportosítja a játékokat, kiszámolja az egyes kiadók játékainak átlagos értékelését, majd az eredményt az átlagos értékelés szerint csökkenő sorrendbe rendezi! Az eredményben a kiadó neve és az átlagos értékelése szerepeljen!
        public Dictionary<string, double> GroupByProducerAverageRatingDescending()
        {
            return games.GroupBy(x => x.Producer).ToDictionary(x=>x.Key, y=>y.Average(z => z.Rating));
                
        }
        // 9. Készíts egy függvényt, amely először megkeresi a 2020-ban vagy később megjelent játékokat, majd kiadó szerint csoportosítja őket! Add vissza kiadónként, hogy hány ilyen játék található!
        public Dictionary<string, int> GroupByProducerCountAfter2020()
        {
            return games.Where(x => x.Year >= 2020).GroupBy(x => x.Producer).ToDictionary(x => x.Key, y => y.Count());
        }
        // 10. Készíts egy függvényt, amely műfaj szerint csoportosítja a játékokat, majd minden műfajból megkeresi a legjobb értékeléssel rendelkező játékot! Az eredményben a műfaj neve, a játék neve és annak értékelése szerepeljen! Az eredményt a játékok értékelése szerint csökkenő sorrendbe rendezd!
        public Dictionary<string, (string Name, double Rating)> GroupByTypeBestRatedGame()
        {
            return games.GroupBy(x => x.Type)
                .Select(x => (Type: x.Key, Name: x.OrderByDescending(y => y.Rating).First().Name, Rating: x.Max(y => y.Rating)))
                .OrderByDescending(x => x.Rating)
                .ToDictionary(x => x.Type, x => (x.Name, x.Rating));
        }
    }
}
