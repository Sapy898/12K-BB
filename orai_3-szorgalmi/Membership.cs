using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Membership
    {
        private Member _owner { get; set; }
        private int _monthlyPrice { get; set; }
        private int _months {  get; set; }
        public Member Owner { get {return _owner; } set {_owner = value; } }
        public int MonthlyPrice { get { return _monthlyPrice; } set { _monthlyPrice = value; } }
        public int Months { get { return _months; } set { _months = value; } }
        

        public Membership(Member owner, int monthlyPrice, int months)
        {
            _owner = owner;
            _monthlyPrice = monthlyPrice;
            _months = months;
        }

        public  int TotalCost()
        {
            if (Owner.IsStudent)
            {
                double ar = ((MonthlyPrice * Months) * 0.8);
                return (int)(ar);
            }
            else { return MonthlyPrice * Months; }
        }

        public void Extend(int months)
        {
            _months++;
        }

        public int PricePerVisit()
        {
            if (this._owner.Visits == 0) { return TotalCost(); }
            else { 
                return TotalCost() / this._owner.Visits;
            }
        }
    }

}
