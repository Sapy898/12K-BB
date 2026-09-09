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
    }
}
