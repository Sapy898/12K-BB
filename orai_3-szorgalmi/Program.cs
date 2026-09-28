using System.Buffers;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member m1 = new Member("Dani", 17, true);
            Member m2 = new Member("Boti", 18, true);
            Member m3 = new Member("Feró", 19, false);
            //Console.WriteLine($"{m1.Name}, {m1.Age}, {m1.IsStudent}");
            //Console.WriteLine($"{m2.Name}, {m2.Age}, {m2.IsStudent}");
            //Console.WriteLine($"{m3.Name}, {m3.Age}, {m3.IsStudent}");

            m1.CheckIn();

            m2.CheckIn();
            m2.CheckIn();

            m3.CheckIn();
            m3.CheckIn();
            m3.CheckIn();

            Console.WriteLine(m1.Describe());
            Console.WriteLine(m2.Describe());
            Console.WriteLine(m3.Describe());
            Console.WriteLine("______________________________________________________________");
            Membership ms1 = new Membership(m1, 1500, 6);
            Membership ms3 = new Membership(m3, 1500, 6);

            Console.WriteLine($"{ms1.Owner.Describe()}, {ms1.MonthlyPrice}, {ms1.Months}");
            Console.WriteLine($"{ms3.Owner.Describe()}, {ms3.MonthlyPrice}, {ms3.Months}");
            Console.WriteLine(ms1.TotalCost()); 
            Console.WriteLine(ms3.TotalCost());
            ms3.Extend(6);
            Console.WriteLine(ms3.TotalCost());
            Console.WriteLine("_____________________________");
            Console.WriteLine(ms1.PricePerVisit());
            Console.WriteLine(ms3.PricePerVisit());
            Console.WriteLine("______________________________________________________________");

            Gym g = new Gym("Kondi");
            g.AddMembership(ms1);
            g.AddMembership(ms3);
            Member m4 = new Member("vendel", 19, true);
            Member m5 = new Member("grasa", 65, false);

            Membership ms2 = new Membership(m2, 1500, 6);
            Membership ms4 = new Membership(m4, 1500,6);
            Membership ms5 = new Membership(m5, 1500, 4);
            g.AddMembership(ms2);
            g.AddMembership(ms4);
            g.AddMembership(ms5);
            Console.WriteLine($"A kondi teljes bevétele: {g.TotalIncome()}");
            Console.WriteLine("A legaktívabb ember");
            Console.WriteLine(g.MostActive().Describe());
            Console.WriteLine(g.BestValue().Owner.Name);
            Console.WriteLine(g.BestValue().PricePerVisit());
        }

    }
}
