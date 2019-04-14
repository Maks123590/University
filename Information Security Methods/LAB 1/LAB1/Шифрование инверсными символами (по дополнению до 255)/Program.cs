namespace Шифрование_инверсными_символами__по_дополнению_до_255_
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите строку для шифрования: ");
            string str = Console.ReadLine();
            
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var edcoding1251 = Encoding.GetEncoding(1251);
            
            string encryptedString = edcoding1251.GetString(edcoding1251.GetBytes(str).Select(e => (byte)(255 - e)).ToArray());

            var decriptedString = edcoding1251.GetString(edcoding1251.GetBytes(encryptedString).Select(e => (byte)(255 - e)).ToArray());

            Console.WriteLine($"Зашифрованная строка: {encryptedString}");
            Console.WriteLine($"Расшифрованная строка: {decriptedString}");

            Console.ReadLine();
        }
    }
}
