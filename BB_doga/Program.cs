namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle v1 =new Vehicle("ABC123", 2020, true);
            Vehicle v2 =new Vehicle("ABC124", 0, false);
            Vehicle v3 =new Vehicle("ABC125", 2026, true);

            v1.TopUp(5000);
            v2.TopUp(2000);
            v3.TopUp(4000);
            v1.Park(3);
            v2.Park(0);
            v3.Park(4);
            ConsoleView view = new ConsoleView();
            view.ShowVehicle(v1);
            view.ShowVehicle(v2);
            view.ShowVehicle(v3);
            view.ShowMessage($"Total vehicles: {Vehicle.Count}");
            view.ShowMessage("__________________________________________________");

            Garage g = new Garage("My Garage", 2);
            g.AddVehicle(v1);
            g.AddVehicle(v2);
            g.AddVehicle(v3);

            view.ShowMessage($"Garage: {g.Name}: Capacity: {g.Capacity}");
            view.ShowVehicle(g.Vehicles);
            view.ShowMessage("__________________________________________________");


            view.ShowVehicle(g.FindByPlate("ABC123"));
            if(g.FindByPlate("MGH123") == null)
            {
                view.ShowMessage("nincs ilyen jármű");
            }

            g.RemoveVehicle("ABC123");
            g.AddVehicle(v3);
            view.ShowMessage("__________________________________________________");

            view.ShowVehicle(g.LowBalance());
            view.ShowMessage($"parkolt órák: {g.TotalHours()}");
            view.ShowMessage(g.LongestParked().Plate);





        }
    }
}
