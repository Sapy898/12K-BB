using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        //1.
        public string Title { get; set; }
        public string Author { get; set; }

        public bool IsAvailable = true;
        //2.
        private int pageCount = 0;

        public static int count = 0;
        //3
        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (value < 0)
                {
                    pageCount = 0;
                }
                else { pageCount = value; }
            }
        }
        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
            count++;
        }
        public void Describe()
        {
            Console.WriteLine($"Cim: {Title}, író: {Author}, oldalszám: {PageCount}");
        }

        public bool IsLong()
        {
            return pageCount > 300;

        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            pageCount = 0;
            count++;
        }
        public bool Borrow()
        {
            if(IsAvailable == true)
            {
               
                IsAvailable = false;
                return true;
            }
            else { return false; }
        }

        public void Return()
        {
            IsAvailable = true;
        }

    }
}
