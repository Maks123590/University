namespace BookStore.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class BookRepository
    {
        public static List<Book> Books { get; set; } = new List<Book>();

        private static int lastId = 0;

        public IEnumerable<Book> GetAll()
        {
            return Books;
        }

        public Book Get(int id)
        {
            return Books.Find(e => e.Id == id);
        }

        public int Create(Book book)
        {
            book.Id = ++lastId;

            Books.Add(book);

            return book.Id;
        }

        public void Update(Book book)
        {
            var index = Books.IndexOf(Books.First(b => b.Id == book.Id));

            Books[index] = book;
        }

        public void Delete(int id)
        {
            Books.Remove(Books.Find(e => e.Id == id));
        }
    }
}