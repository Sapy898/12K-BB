using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I. rész
            Book book1 = new Book("Vagabond", "idk", 100);
            Book book2 = new Book("Vagabond1", "idk", 100);
            book1.PageCount = 301;
            book2.PageCount = 250;
            book1.Describe();
            book2.Describe();

            Console.WriteLine(book1.IsLong());
            Console.WriteLine(book2.IsLong());

            Book book3 = new Book("Berserk", "idk");
            Console.WriteLine($"{Book.count} könyvünk van");

            Console.WriteLine(book1.IsAvailable);
            book1.Borrow();
            Console.WriteLine(book1.IsAvailable);
            book1.Return();
            Console.WriteLine(book1.IsAvailable);
            Console.WriteLine("________________________________________________________________________");

            //II.rész 

            Library _books = new Library("Budapesti Könyvtár");
            _books.AddBook(book1);
            _books.AddBook(book2);
            _books.AddBook(book2);
            Book book4 = new Book("The Climber", "c");
            Book book5 = new Book("The Climber 2", "d");
            _books.AddBook(book4);
            _books.AddBook(book5);

            _books.PrintAll();
            Console.WriteLine(_books.BookCount);

            _books.FindByTitle("The Climber").Describe();

            List<Book> bok = _books.FindByAuthor("idk");
            foreach (Book item in bok)
            {
                item.Describe();
            }

            Console.WriteLine("könyv kölcsönzés:");
            book1.Borrow();
            List<Book> availableBooks = _books.AvailableBooks();
            foreach (Book book in availableBooks)
            {
                book.Describe();
            }
            Console.WriteLine("________________________________________________________________________");
            //III.rész
            Librarian librarian = new Librarian("Marcell", _books);//ezt nem tudom ugy megoldani , hogy a könyvtár nevét is átadjam neki
            Console.WriteLine(librarian.Introduce());
            Console.WriteLine("BookAdd:");
            librarian.AddBook("New Book", "Author", 123);
            _books.PrintAll();

            librarian.LendBook("New Book");
            librarian.LendBook("Book");
            Console.WriteLine("_________________________________");

            librarian.TakeBack("New Book");
            librarian.TakeBack("Book");
            Console.WriteLine("_________________________________");
            Console.WriteLine(librarian.Report());
            Console.WriteLine("_________________________________");
            librarian.Recommend(300).Describe();
            librarian.Recommend(100).Describe();

        }
    }
}
