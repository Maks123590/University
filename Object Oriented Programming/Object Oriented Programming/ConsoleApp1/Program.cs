namespace Task2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using StudentBookClassLibrary;

    public class Program
    {
        public static void Main(string[] args)
        {
            var books = new[]
                            {
                                new Book(1, "Книга 1", new[] { "Автор 1", "Автор 2" }, "Издательство 1", 2005, 175, 100m, "Твердый"),
                                new Book(2, "Книга 2", new[] { "Автор 1" }, "Издательство 1", 2002, 175, 100m, "Мягкий"),
                                new Book(3, "Книга 3", new[] { "Автор 1" }, "Издательство 2", 2001, 175, 100m, "Твердый"),
                                new Book(4, "Книга 4", new[] { "Автор 2" }, "Издательство 3", 2005, 175, 100m, "Мягкий"),
                                new Book(5, "Книга 5", new[] { "Автор 2" }, "Издательство 4", 2005, 175, 100m, "Твердый"),
                            };

            BooksByAuthor(books, "Автор 1");
            BooksByPublisher(books, "Издательство 1");
            BooksAfterYear(books, 2002);

            Console.ReadLine();
        }

        public static void BooksByAuthor(IEnumerable<Book> books, string author)
        {
            Console.WriteLine($"Книги автора {author}\n");

            foreach (var book in books.Where(b => b.Authors.Contains(author)))
            {
                Console.WriteLine(book.ToString());
            }
        }

        public static void BooksByPublisher(IEnumerable<Book> books, string publisher)
        {
            Console.WriteLine($"Книги издательства {publisher}\n");

            foreach (var book in books.Where(b => b.Publisher == publisher))
            {
                Console.WriteLine(book.ToString());
            }
        }

        public static void BooksAfterYear(IEnumerable<Book> books, int year)
        {
            Console.WriteLine($"Книги после {year} года\n");

            foreach (var book in books.Where(b => b.PublishYear > year))
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
