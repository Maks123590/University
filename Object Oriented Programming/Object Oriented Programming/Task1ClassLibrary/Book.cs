namespace StudentBookClassLibrary
{
    using System.Collections.Generic;

    public class Book
    {
        public Book(int id, string name, IEnumerable<string> authors, string publisher, int publishYear, int pagesCount, decimal price, string bindingType)
        {
            this.Id = id;
            this.Name = name;
            this.Authors = authors;
            this.Publisher = publisher;
            this.PublishYear = publishYear;
            this.PagesCount = pagesCount;
            this.Price = price;
            this.BindingType = bindingType;
        }

        public int Id { get; set; }

        [ToStringName("Название")]
        public string Name { get; set; }

        [ToStringName("Автор(ы)")]
        public IEnumerable<string> Authors { get; set; }

        [ToStringName("Издатель")]
        public string Publisher { get; set; }

        [ToStringName("Год выпуска")]
        public int PublishYear { get; set; }

        [ToStringName("Количество страниц")]
        public int PagesCount { get; set; }

        [ToStringName("Цена")]
        public decimal Price { get; set; }

        [ToStringName("Переплет")]
        public string BindingType { get; set; }

        public override string ToString()
        {
            return ToStringHelper<Book>.ToString(this);
        }
    }
}