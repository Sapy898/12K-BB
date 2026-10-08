using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class ConsoleView
    {
        public void ShowVehicle(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetDescription());
        }

        public void ShowVehicle(List<Vehicle> vehicles)
        {
            foreach(Vehicle item in vehicles)
            {
                Console.WriteLine(item.GetDescription());

            }
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
