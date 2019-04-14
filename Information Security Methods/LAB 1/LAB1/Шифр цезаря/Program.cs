namespace Шифр_цезаря
{
    using System;

    public partial class Program
    {
        public static void Main(string[] args)
        {
            CaesarCipher.Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            CaesarCipher.Shift = 3;

            string text = "текст";

            Console.WriteLine("Текст {0}", text);

            string crypt = CaesarCipher.Encryption(text);

            Console.WriteLine("Шифруем текст: {0}", crypt);

            text = CaesarCipher.Decryption(crypt);

            Console.WriteLine("Дешифруем текст: {0}", text);

            Console.ReadKey();
        }
    }
}
