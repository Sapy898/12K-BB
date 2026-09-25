using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal record FootballPlayer(string Name, string Nationality, int BirthYear)
    {
        private string Team {  get; set; }
        protected int Goals {  get; set; }
        protected int Matches { get; set; }

        public void UpdateStats(int goals)
        {
            Matches++;
            Goals =+ goals;
        }

        public double AvgGoalPerMatch()
        {
            return Goals / Matches;
        }

        private bool IsTradeable(FootballPlayer p)
        {
            if(p.Matches >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateTeam(string t)
        {
            if(IsTradeable(this) == true)
            {
                Team = t;
            }
        }
    }
}
