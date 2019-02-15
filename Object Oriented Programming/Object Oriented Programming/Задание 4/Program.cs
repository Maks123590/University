namespace Task4
{
    using System;

    using StudentBookClassLibrary;

    public class Program
    {
        public static void Main(string[] args)
        {
            var students = new[]
                               {
                                   new Student(1, "Иван", "Иванов", "Иванович", new DateTime(1997, 11, 12), "Саранск", "78291748264", "ФМиИТ", 1, "101"),
                                   new Student(2, "Петр", "Семенов", "Владимирович", new DateTime(1997, 11, 12), "Саранск", "78291748264", "ФЭТ", 2, "201"),
                                   new Student(3, "Иван", "Петров", "Иванович", new DateTime(1997, 11, 12), "Саранск", "78291748264", "ФМиИТ", 3, "301"),
                                   new Student(4, "Семен", "Иванов", "Ильич", new DateTime(1998, 11, 12), "Саранск", "78291748264", "ФЭТ", 4, "401"),
                               };

            var books = new[]
                            {
                                new Book(1, "Книга 1", new[] { "Автор 1", "Автор 2" }, "Издательство 1", 2005, 175, 100m, "Твердый"),
                                new Book(2, "Книга 2", new[] { "Автор 1" }, "Издательство 1", 2002, 175, 100m, "Мягкий"),
                                new Book(3, "Книга 3", new[] { "Автор 1" }, "Издательство 2", 2001, 175, 100m, "Твердый"),
                                new Book(4, "Книга 4", new[] { "Автор 2" }, "Издательство 3", 2005, 175, 100m, "Мягкий"),
                            };

            var studentsList = new StudentList(students);

            foreach (var student in studentsList)
            {
                Console.WriteLine(student);
            }

            var bookList = new BookList(books);

            foreach (var book in bookList)
            {
                Console.WriteLine(book);
            }

            Console.ReadLine();
        }
    }
}
