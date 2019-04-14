namespace Шифр_перестановки
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите строку для шифрования: ");
            string str = Console.ReadLine();

            var transcription = new Transposition();

            transcription.SetKey("3 2 1");

            var encrypted = transcription.Encrypt(str);

            Console.WriteLine("Шифруем текст: {0}", encrypted);
            Console.WriteLine("Дешифруем текст: {0}", transcription.Decrypt(encrypted).Substring(0, str.Length));

            Console.ReadKey();
        }
    }
}
