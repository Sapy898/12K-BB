namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device d1 = new DimmableLight("Nappali Lámpa", 75);
            d1.TurnOn();
            Console.WriteLine(d1.GetDescription()); 
            d1.TurnOn();
            Console.WriteLine(d1.GetDescription());
            Console.WriteLine(d1.Consumption(5));
            Console.WriteLine("_______________________");
            Heater h1 = new Heater("Fürdőszobai Fűtés",22);
            Console.WriteLine(h1.GetDescription());
            Console.WriteLine("A Heater fogysztása: "+h1.Consumption(3));
            Console.WriteLine("Eszközök száma: "+ h1.Count);
            Console.WriteLine("_______________________");
            h1.TurnOn();
            Console.WriteLine(h1.GetDescription());
            Console.WriteLine("ablak nyitva: "+h1.OpenWindow());
            Console.WriteLine(h1.GetDescription());
            h1.TurnOn();
            Console.WriteLine(h1.GetDescription());
            Console.WriteLine("_______________________");

            Fridge f1 = new Fridge("Konyhai hűtő",false);
            Console.WriteLine(f1.GetDescription());
            Console.WriteLine("A Hűtő fogysztása: " + f1.Consumption(24));
            f1.IsEcoMode = true;
            Console.WriteLine("A Hűtő fogysztása: " + f1.Consumption(24));
            f1.TurnOff();

            Console.WriteLine(f1.GetDescription());
            Console.WriteLine("_______________________");
            Console.WriteLine("Legnagyobb fogyasztó: ");
            if(Device.MoreConsuming(d1, h1, 2) == d1)
            {
                Console.WriteLine(d1.GetDescription());
            }
            else if(Device.MoreConsuming(d1, h1, 2) == h1)
            {
                Console.WriteLine(h1.GetDescription());
            }
            else
            {
                Console.WriteLine("mindkettő eszköz ugyan annyit fogyaszt ");
            }
            Console.WriteLine("_______________________");

            EnergyMeter limit = new EnergyMeter(10000);
            Console.WriteLine($"{h1.Name} 3 órát ment: "+limit.Run(h1, 3));
            Console.WriteLine($"A limit-ből maradt: {limit.Remaining()}");
            Console.WriteLine($"{f1.Name} 24 órát ment: " + limit.Run(f1, 24));
            Console.WriteLine($"A limit-ből maradt: {limit.Remaining()}");
            Console.WriteLine($"{d1.Name} 5 órát ment: " + limit.Run(d1, 5));
            Console.WriteLine($"A limit-ből maradt: {limit.Remaining()}");
            Console.WriteLine($"{h1.Name} 3 órát ment: " + limit.Run(h1, 3));
            Console.WriteLine($"A limit-ből maradt: {limit.Remaining()}");
            Console.WriteLine($"{f1.Name} 24 órát ment: " + limit.Run(f1, 24));
            Console.WriteLine($"A limit-ből maradt: {limit.Remaining()}");

        }
    }
}
