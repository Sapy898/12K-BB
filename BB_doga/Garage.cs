using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Garage
    {
        private string _name { get; set; }
        private int _capacity { get; set; }
        private List<Vehicle> _vehicles { get; set; }

        public string Name { get { return _name; } set { _name = value; } }
        public int Capacity { get { return _capacity; } }
        public List<Vehicle> Vehicles { get { return _vehicles; } }

        public Garage(string name, int capacity)
        {
            _name = name;
            _capacity = capacity;
            _vehicles = new List<Vehicle>();
        }
        public bool AddVehicle(Vehicle vehicle)
        {
            if (!(_vehicles.Count() == Capacity))
            {
                _vehicles.Add(vehicle);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Vehicle FindByPlate(string plate)
        {
            foreach (Vehicle item in _vehicles)
            {
                if (plate == item.Plate)
                {
                    return item;
                }
            }
            return null;

        }
        public bool RemoveVehicle(string plate)
        {
            //FindByPlate(plate);
            if (FindByPlate(plate) != null)
            {
                foreach(Vehicle item in Vehicles)
                {
                    Vehicles.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public List<Vehicle> LowBalance()
        {
            List<Vehicle> lowBalanceVehicles = new List<Vehicle>();
            foreach (Vehicle item in Vehicles)
            {
                if(item.Balance < 1000)
                {
                    lowBalanceVehicles.Add(item);
                }
            }
                    return lowBalanceVehicles;
        }
        public int TotalHours()
        {
            int sum = 0;
            foreach(Vehicle item in Vehicles)
            {
                sum += item.HoursParked;
            }
            return sum;
        }

        public Vehicle LongestParked()
        {
            Vehicle longestParked = null;
            int maxHours = 0;
            foreach(Vehicle item in Vehicles)
            {
                if(item.HoursParked > maxHours)
                {
                    maxHours = item.HoursParked;
                    longestParked = item;
                }
            }
            return longestParked;
        }

    }
}
