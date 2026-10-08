using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Vehicle
    {
        private string _plate {  get; set; }
        private int _year {  get; set; }
        private bool _isElectric {  get; set; }
        public string Plate { get { return _plate; } set { _plate = value; } }
        public int Year { get { return _year; } set 
            { if (Year >= 1990 && Year <= 2026)
                { _year = value; } 
            } }
        public bool IsElectric { get { return _isElectric; } set { _isElectric = value; } }

        public static int _count { get; set; }
        public static int Count { get { return _count; } }

        private int _balance { get; set; }
        private int _hoursParked { get; set; }
        public int Balance { get { return _balance; } }
        public int HoursParked { get { return _hoursParked; } }


        public Vehicle(string plate, int year, bool isElectric)
        {
            _plate = plate;
            _year = year;
            _isElectric = isElectric;
            _count++;
        }

        public bool TopUp(int amount)
        {
            if(amount == 1000 || amount == 2000 || amount == 5000)
            {
                _balance += amount;
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public bool Park(int hours) 
        {
                        
            if (IsElectric)
            {
                if (hours > 1 || _balance -hours *200 < 0)
                {
                    _balance -= hours * 200;
                    _hoursParked += hours;
                    return true;
                }
                return false;

            }
            else if(IsElectric == false)
            {
                if (hours > 1 || _balance - hours * 400 < 0)
                {
                    _balance -= hours * 400;
                    _hoursParked += hours;
                    return true;    
                }
                return false;

            }
            return false;

        }
        public string GetDescription()
        {
            if(_year == 0)
            {
                return $"Plate: {Plate}, Year: Évjárat ismeretlen, Is Electric: {IsElectric}, Balance: {Balance}, Hours Parked: {HoursParked}";
            }
            return $"Plate: {Plate}, Year: {Year}, Is Electric: {IsElectric}, Balance: {Balance}, Hours Parked: {HoursParked}";
        }
    }
}
