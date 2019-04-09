namespace Шифр_Плейфера
{
    using System;
    using System.Diagnostics;

    public class Program
    {
        public static void Main(string[] args)
        {
            ActivateMenu();
        }

        private static void ActivateMenu()
        {
            var alph = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

            var key = ReadValueFromConsole<string>("\nВведите ключевое слово");

            var pc = new PlayfairCipher(alph, key);

            var first = true;

            while (true)
            {
                int choise;
                if (first)
                {
                    choise = ReadValueFromConsole<int>("Выберите действие:\n1. Зашифровать указанную строку\n2. Десшифровать указанную строку\n3. Показать матрицу\n4. Выход");
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

                        var crypted = pc.Crypt(normalMessage);

                        Console.WriteLine("\nРезультат: " + crypted);
                        Console.WriteLine("Расшифрованный результат: " + pc.Uncrypt(crypted));
                        break;
                    case 2:
                        Console.Write("Дешифрование строки.");

                        var cryptedMessage = ReadValueFromConsole<string>("\nВведите строку для дешифровки: ");

                        var normal = pc.Uncrypt(cryptedMessage);

                        Console.WriteLine("\nРезультат: " + normal);
                        Console.WriteLine("Зашифрованный результат: " + pc.Crypt(normal));
                        break;
                    case 3:
                        WriteMatrix(pc.GetAlphabetMatrix());
                        break;
                }

                if (choise == 4)
                {
                    break;
                }
            }
        }

        private static void WriteMatrix(string[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
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
