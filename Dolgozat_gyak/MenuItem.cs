using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class MenuItem
    {
        public static int Count { get; set; }
        public string Name { get; set; }
        public string Category {  get; set; }
        private int _price;
        
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value < 0 ? 0 : value;
            }
        }

        public bool IsAvailabe { get; set;}

        public void SellOut()
        {
            IsAvailabe = false;
        }

        public void ReStock()
        {
            IsAvailabe=true;
        }

        public MenuItem(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
            IsAvailabe = true;  
            Count++;
        }

        public string GetDescription()
        {
            
            return $"{Name}, {Category}, {Price}";
        }
    }
}
