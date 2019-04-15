namespace Совмещенный_шифр
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // var key = ReadValueFromConsole<string>("\nВведите ключевое слово");

            var key = "ДЯДИНА";

            var vc = new CombinedСipher(key);

            var first = true;

            while (true)
            {
                int choise;
                if (first)
                {
                    choise = ReadValueFromConsole<int>("Выберите действие:\n1. Зашифровать указанную строку\n2. Показать матрицу\n3. Выход");
                    first = false;
                }
                else
                {
                    choise = ReadValueFromConsole<int>("Введите номер команды: ");
                }

                switch (choise)
                {
                    case 1:
                        Console.Write("Шифрование строки.");

                        var normalMessage = ReadValueFromConsole<string>("\nВведите строку для шифрования: ");

                        var crypted = vc.Encrypt(normalMessage.ToUpper());

                        Console.WriteLine("\nРезультат: " + crypted);
                        break;
                    case 2:
                        vc.WriteMatrix();
                        break;
                }

                if (choise == 3)
                {
                    break;
                }
            }
        }

        private static T ReadValueFromConsole<T>(string message)
        {
            Console.WriteLine(message);

            while (true)
            {
                try
                {
                    return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }
                catch (Exception)
                {
                    Console.WriteLine("Возникла ошибка. Повторите ввод");
                }
            }
        }
    }
}
