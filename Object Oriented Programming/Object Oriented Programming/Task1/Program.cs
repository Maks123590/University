namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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
                new Student(5, "Илья", "Ильин", "Иванович", new DateTime(1997, 11, 12), "Саранск", "78291748264", "ФМиИТ", 1, "101"),
                new Student(6, "Евгений", "Ильин", "Кузьмич", new DateTime(1998, 11, 12), "Саранск", "78291748264", "ФМиИТ", 2, "201"),
                new Student(7, "Илья", "Степанов", "Иванович", new DateTime(1998, 11, 12), "Саранск", "78291748264", "ФЭТ", 3, "301"),
                new Student(8, "Роман", "Романов", "Степанович", new DateTime(1997, 11, 12), "Саранск", "78291748264", "ФМиИТ", 4, "401"),
                new Student(9, "Илья", "Евгеньевич", "Иванович", new DateTime(1998, 11, 12), "Саранск", "78291748264", "ФЭТ", 1, "101"),
                new Student(10, "Станислав", "Петров", "Евгеньевич", new DateTime(1998, 11, 12), "Саранск", "78291748264", "ФМиИТ", 2, "201"),
                new Student(11, "Владимир", "Иванов", "Владимирович", new DateTime(1997, 11, 12), "Саранск", "78291748264", "ФМиИТ", 3, "301"),
                new Student(12, "Степан", "Степанов", "Иванович", new DateTime(1998, 11, 12), "Саранск", "78291748264", "ФЭТ", 4, "401"),
            };

            // StudentsByFaculty(students, "ФМиИТ");

            // StudentsByFacultyAndYearsStudy(students);

            // StudentsAfterDate(students, new DateTime(1998, 1, 1));

            StudentsByGroup(students, "401");

            Console.ReadLine();
        }

        private static void StudentsByFaculty(IEnumerable<Student> students, string faculty)
        {
            Console.WriteLine($"Список студентов факультета {faculty}");

            foreach (var student in students.Where(s => s.Faculty == faculty))
            {
                Console.WriteLine(student.ToString());
            }
        }

        private static void StudentsByFacultyAndYearsStudy(IEnumerable<Student> students)
        {
            Console.WriteLine("\n\nCписки студентов для каждого факультета и курса");

            foreach (var studentsByFaculty in students.GroupBy(s => s.Faculty))
            {
                foreach (var studentByYears in studentsByFaculty.GroupBy(sg => sg.StudyYearsCount))
                {
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine($"Список для факультета {studentsByFaculty.Key} курса {studentByYears.Key}");
                    Console.WriteLine("==========================================================================");

                    foreach (var student in studentByYears)
                    {
                        Console.WriteLine(student.ToString());
                    }
                }
            }
        }

        private static void StudentsAfterDate(IEnumerable<Student> students, DateTime date)
        {
            Console.WriteLine($"Студенты родившиеся после {date}");

            foreach (var student in students.Where(s => s.Birthday > date))
            {
                Console.WriteLine(student.ToString());
            }
        }

        private static void StudentsByGroup(IEnumerable<Student> students, string group)
        {
            Console.WriteLine($"Студенты группы {group}");

            foreach (var student in students.Where(s => s.Group == group))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
