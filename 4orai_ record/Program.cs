namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Példányosíts két Book objektumot:
            // "The Hobbit", "J. R. R. Tolkien", 310, 6500
            // "Dune", "Frank Herbert", 688, 7900

            // Az egyik könyv árát csökkentsd 20%-kal!
            // Írd ki mindkét könyv címét, oldalszámát és aktuális árát!
            Book hobbit = new Book("The Hobbit", "J.R.R.", 310) { Price = 6500 };
            hobbit.UpdatePrice(20);
            Console.WriteLine(hobbit);

            Book dune = new Book("Dune", "Moliere", 315) { Price = 6500 };
            
            Console.WriteLine("_____________________________");
            //Book dune = hobbit with (Author = "Frank Herbert", Title="Dune",Pages = 350 );
            Student anna = new Student("Nagy Anna", "12.A", 2000);
            anna.UpdateAverage(4.7);
            Console.WriteLine(anna);
            Console.WriteLine(anna.Grading());

            Student bence = new Student("Nagy Bence", "12.B", 2001);
            bence.UpdateAverage(2.3);
            Console.WriteLine(bence);
            Console.WriteLine(bence.Grading());
            Console.WriteLine("_____________________________");

            VidioGame Cyberpunk = new VidioGame("CyberPunk 2077", "CD Project", 2020) { Rating = 8.6 };
            Cyberpunk.UpdatePrice(19900);
            Console.WriteLine(Cyberpunk);
            Console.WriteLine(Cyberpunk.CanIBuy(14000));
            Console.WriteLine(Cyberpunk.HowOld(DateTime.Now.Year));


            VidioGame Sekiro = new VidioGame("Sekiro", "Souls", 2015) { Rating = 9.4 };
            Cyberpunk.UpdatePrice(19900);
            Console.WriteLine(Cyberpunk);
            Console.WriteLine(Cyberpunk.CanIBuy(14000));
            Console.WriteLine(Cyberpunk.HowOld(DateTime.Now.Year));
            Console.WriteLine("_____________________________");

            Employee peter = new Employee("Kovacs Peter", "Devs");
            peter.UpdateWage(15);
            Console.WriteLine(peter.Calc2());
            peter.UpdateWage(15);
            Console.WriteLine(peter);

            Employee eva = new Employee("Szabo Eva", "Designer");
            Console.WriteLine(peter.Calc2());
            peter.UpdateWage(15);
            Console.WriteLine(peter);
            Console.WriteLine("_____________________________");

            FootballPlayer dani = new FootballPlayer("Daniel Kovacs", "Hungarian", 2001);
            dani.UpdateStats(2);
            Console.WriteLine(dani.AvgGoalPerMatch());
            dani.UpdateTeam("Real Madrid");
            Console.WriteLine($"{dani.Name},{dani.Nationality},{dani.BirthYear}");

            FootballPlayer adam = new FootballPlayer("Adam Nagy", "Hungarian", 2005);
            adam.UpdateStats(1);
            Console.WriteLine(adam.AvgGoalPerMatch());
            adam.UpdateTeam("Real Madrid");
            Console.WriteLine($"{adam.Name},{adam.Nationality},{adam.BirthYear}");

            Console.WriteLine("_____________________________");
            Movie m = new Movie("Interstellar", "Christopher Nolan", "Sci fi", 2014);
            //m.Title = "alma";
            m.UpdateRating(9.1);
            Console.WriteLine(m.Summary());
            // nem értem hogy hogyan kell használni a with-et és nem is segit a copilot sem

        }

    }
}
