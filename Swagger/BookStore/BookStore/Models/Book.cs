namespace BookStore.Models
{
    /// <summary>
    /// Модель книги
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Имя автора
        /// </summary>
        public string Author { get; set; }
        
        /// <summary>
        /// Год издания
        /// </summary>
        public int PublishingYear { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public int Price { get; set; }
    }
}