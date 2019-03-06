namespace BookStore.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    using BookStore.Models;

    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        public readonly BookRepository BookRepository;

        public BooksController()
        {
            this.BookRepository = new BookRepository();
        }

        /// <summary>
        /// Получает все книги
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get-all")]
        public IEnumerable<Book> GetAllBooks()
        {
            return this.BookRepository.GetAll();
        }

        /// <summary>
        /// Получает книгу по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public Book GetBook(int id)
        {
            return this.BookRepository.Get(id);
        }

        /// <summary>
        /// Создает новую книгу
        /// </summary>
        /// <param name="bookName">Наименование книги</param>
        /// <param name="author">Автор</param>
        /// <param name="publishingYear">Год публикации</param>
        /// <param name="price">Цена</param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public int CreateBook(string bookName, string author, int publishingYear, int price)
        {
            var newBook = new Book
                              {
                                  Name = bookName,
                                  Author = author,
                                  PublishingYear = publishingYear,
                                  Price = publishingYear
                              };

            return this.BookRepository.Create(newBook);
        }

        /// <summary>
        /// Обновляет информацию о книге
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="bookName">Наименование книги</param>
        /// <param name="author">Автор</param>
        /// <param name="publishingYear">Год публикации</param>
        /// <param name="price">Цена</param>
        [HttpPut]
        [Route("{id}")]
        public void UpdateBook(int id, string bookName, string author, int publishingYear, int price)
        {
            var newBook = new Book
                              {
                                  Id = id,
                                  Name = bookName,
                                  Author = author,
                                  PublishingYear = publishingYear,
                                  Price = publishingYear
                              };

            this.BookRepository.Update(newBook);
        }

        /// <summary>
        /// Удаляет книгу по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        [HttpDelete]
        [Route("{id}")]
        public void DeleteBook(int id)
        {
            this.BookRepository.Delete(id);
        }
    }
}
