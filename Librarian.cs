using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Librarian
    {
        public string Name { get; set; }
        private Library _library = new Library("Budapesti Könyvtár");
        public int LentCount { get; set; }

        public Librarian(string name, Library library)
        {
            Name = name;
            _library = library;
        }

        public string Introduce()
        {
            return $"Könyvtáros: {Name}, könyvtár: {_library}";
        }

        public void AddBook(string title, string author, int pageCount)
        {
            Book newBook = new Book(title, author, pageCount);
            _library.AddBook(newBook);
        }

        public void LendBook(string title)
        {
            Book bookToLend = _library.FindByTitle(title);
            if (bookToLend != null && bookToLend.IsAvailable)
            {
                bookToLend.Borrow();
                LentCount++;
                Console.WriteLine($"A '{title}' könyvet kölcsönözték.");
            }
            else
            {
                Console.WriteLine($"A '{title}' könyv nem elérhető.");
            }
        }

        public void TakeBack(string title)
        {
            Book bookToReturn = _library.FindByTitle(title);
            if (bookToReturn != null && bookToReturn.IsAvailable == false)
            {
                bookToReturn.Return();
                Console.WriteLine($"A '{title}' könyvet visszahozta.");
            }
            else
            {
                Console.WriteLine($"A '{title}' könyvet nem lehet visszahozni.");
            }
        }

        public string Report()
        {
            return $"{Name}, {_library.BookCount},{_library.AvailableBooks().Count}, {LentCount}";
        }

        public Book Recommend(int maxPage)
        {
            foreach (var item in _library.AvailableBooks()) 
            {
                if (item.PageCount <= maxPage)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
