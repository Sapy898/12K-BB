using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Order
    {
        private List<MenuItem> _items;
        public int ItemCount { get { return _items.Count; } }

        public Order()
        {
            _items = new List<MenuItem>();
        }
        public bool Add(MenuItem item)
        {
            if (item.IsAvailabe == true)
            {
                _items.Add(item);
                return true;
            }
            return false;
        }

        public int Total()
        {
            int total = 0;
            foreach (MenuItem item in _items)
            {
                total += item.Price;
            }
            return total;
        }

        public string GetSummary()
        {
            return $"{Total().ToString()}, {ItemCount.ToString()}";
        }
        
    }
}
