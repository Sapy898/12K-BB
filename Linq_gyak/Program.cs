namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            foreach (var game in model.games)
            {
                Console.WriteLine($"{game.Name}, {game.Type}, {game.Producer}, {game.Year}, {game.Price}, {game.Rating}");
            }
            Console.WriteLine("_________________________________________________________");
            //1.feladat
            Console.WriteLine("GroupByProducerCount:");
            foreach(var item in model.GroupByProducerCount())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("_________________________________________________________");
            //2.feladat
            Console.WriteLine("GroupByTypeCount:");
            foreach(var item in model.GroupByTypeCount())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("_________________________________________________________");
            //3.feladat
            Console.WriteLine("GroupByProducerAveragePrice:");
            foreach(var item in model.GroupByProducerAveragePrice())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("_________________________________________________________");
            //4.feladat
            Console.WriteLine("GroupByTypeAverageRating:");
            foreach(var item in model.GroupByTypeAverageRating())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("_________________________________________________________");
            //5.feladat
            Console.WriteLine("GroupByProducerMaxRating:");
            foreach(var item in model.GroupByProducerMaxRating())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("_________________________________________________________");
            //6.feladat
            Console.WriteLine("GroupByTypeMaxPrice:");
            foreach(var item in model.GroupByTypeMaxPrice())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("_________________________________________________________");
            //7.feladat
            Console.WriteLine("GroupByProducerAtLeast4Games:");
            foreach(var item in model.GroupByProducerAtLeast4Games())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_________________________________________________________");
            //8.feladat
            Console.WriteLine("GroupByProducerAverageRatingDescending:");
            foreach(var item in model.GroupByProducerAverageRatingDescending())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("_________________________________________________________");
            //9.feladat
            Console.WriteLine("GroupByProducerCountAfter2020:");
            foreach(var item in model.GroupByProducerCountAfter2020())
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("_________________________________________________________");
            //10.feladat
            Console.WriteLine("GroupByTypeBestRatedGame:");
            foreach(var item in model.GroupByTypeBestRatedGame())
            {
                Console.WriteLine($"{item.Key}: {item.Value.Name}, {item.Value.Rating}");
            }
            Console.WriteLine("_________________________________________________________");

        }
    }
}
