using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Game
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Producer { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }
        public Game (string line)
        {
            string[] temp = line.Split(';');
            Name = temp[0];
            Type = temp[1];
            Producer = temp[2];
            Year = Convert.ToInt32(temp[3]);
            Price = Convert.ToInt32(temp[4]);
            Rating = Convert.ToDouble(temp[5].Replace('.', ','));
        }
    }
}
