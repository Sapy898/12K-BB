using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Gym
    {
        private string _name {  get; set; }
        private List<Membership> _memberships {  get; set; }
        public string Name { get { return _name; } set { _name = value; } }
        public List<Membership> Memberships { get { return _memberships; } set { _memberships = value; } } 
        
        public Gym(string name) 
        {
            _name = name;
            Memberships = new List<Membership>();
        }

        public void AddMembership(Membership membership)
        {
            Memberships.Add(membership);
        }

        public int TotalIncome()
        {
            double total = 0;
            foreach (Membership item in Memberships)
            {
                total += item.TotalCost();
            }
            return (int)(total);
        }

        public Member MostActive()
        {
            Member active = Memberships[0].Owner;
            foreach(Membership item in Memberships)
            {
                if(item.Owner.Visits > active.Visits)
                {
                    active = item.Owner;
                }
            }
            return active;
        }

        public Membership BestValue()
        {
            Membership cheap= Memberships[0];
            foreach(Membership item in Memberships)
            {
                if(item.PricePerVisit() < cheap.PricePerVisit())
                {
                    cheap = item;
                }
            }
            return cheap;
        }
    }
}
