using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Menu
    {
        public string Name { get; set; }
        private List<MenuItem> _items { get; set; }
        public Menu(string name)
        {
            Name = name;
            _items = new List<MenuItem>();
        }
        public void AddItem(MenuItem item)
        {
            _items.Add(item);
        }

        public List<MenuItem> Items { get { return _items; } }

        public MenuItem FindByName(string name)
        {
            foreach (MenuItem item in _items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        public List<MenuItem> AvailabeItems()
        {
            List<MenuItem> list = new List<MenuItem>();
            foreach (MenuItem item in _items)
            {
                if(item.IsAvailabe == true)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public List<MenuItem> ItemsByCategory(string category)
        {
            List<MenuItem> list = new List<MenuItem>();
            foreach (MenuItem item in _items)
            {
                if (item.Category == category)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public string AveragePrice(string category)
        {
            List<MenuItem> items = ItemsByCategory(category);
            double sum = 0;
            foreach (MenuItem item in items)
            {
                sum += item.Price;
                if(sum <= 0)
                {
                    return null;
                }
            }
            return (sum / items.Count).ToString();
        }
    }
}
