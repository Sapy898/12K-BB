using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal record Movie(string Title, string Director, string Genre, int ReleaseYear)
    {
        private double _rating {  get; set; }
        protected int ViewCount {  get; set; }

        private bool IsRatingOk() 
        {
            if (this._rating >= 0 && _rating <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateRating(double r)
        {
            if (IsRatingOk())
            {
                _rating = r;
            }
        }

        protected bool IsMoviePopular()
        {
            if (ViewCount >= 1000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Summary()
        {
            return $"{Title}, {Director}, {ReleaseYear}, {_rating}";
        }



    }
}
