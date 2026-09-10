using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Library
    {
        public string Name { get; set; }

        private List<Book> _books = new List<Book>();

        public int BookCount { get { return _books.Count; } }

        public Library(string name)
        {
            name = Name;
            List<Book> _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void PrintAll()
        {
            foreach (Book book in _books)
            {
                book.Describe();
            }
        }

        public Book FindByTitle(string title)
        {
            foreach (Book book in _books) 
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }
        public List<Book> FindByAuthor(string author)
        {
            List<Book> booksByAuthor = new List<Book>();
            foreach (Book book in _books)
            {
                if (book.Author == author)
                {
                    booksByAuthor.Add(book);   
                }
            }
            return booksByAuthor;
        }

        public int TotalPages(){
            int totalPages = 0;
            foreach (Book book in _books)
            {
                totalPages += book.PageCount;
            }
            return totalPages;
        }

        public double AveragePages()
        {
            if (_books.Count == 0)
            {
                Console.WriteLine("a könyvtárban nincs könyv");
                return 0;
            }
            return (double)TotalPages() / _books.Count;
        }

        public List<Book> AvailableBooks()
        {
                       List<Book> availableBooks = new List<Book>();
            foreach (Book book in _books)
            {
                if (book.IsAvailable)
                {
                    availableBooks.Add(book);
                }
            }
            return availableBooks;
        }

    }
}
