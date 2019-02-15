namespace Task4
{
    using System.Collections;
    using System.Collections.Generic;

    using StudentBookClassLibrary;

    public class BookList : IEnumerable
    {
        public BookList(IEnumerable<Book> books)
        {
            this.Books = books;
        }

        private IEnumerable<Book> Books { get; }

        public IEnumerator GetEnumerator()
        {
            return this.Books.GetEnumerator();
        }
    }
}