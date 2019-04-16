namespace Алгоритм_Эль_Гамаля
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static int Nod(int i, int j)
        {
            while (i != j)
            {
                if (i > j)
                {
                    i -= j;
                }
                else
                {
                    j -= i;
                }
            }

            return i;
        }

        public static void Main(string[] args)
        {
            var random = new Random();
            
            var p = 11;

            var g = 2; // random.Next(2, p);

            var x = 8; // random.Next(2, p - 1);

            var y = Math.Pow(g, x) % p;
            

            Console.WriteLine($"y = {y}");
            Console.WriteLine($"Открытый ключ (p, g, y) = ({p}, {g}, {y})");




            var alphabet = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            
            var word = "АБРАМОВ".ToLower();

            Console.WriteLine($"Исходное слово: {word}");

            var alphIndexesArray = word.Select(e => alphabet.IndexOf(e)).ToArray();

            var shifrValueArray = new List<Tuple<double, double>>(word.Length);
            
            foreach (var letterPosition in alphIndexesArray)
            {
                var k = random.Next(1, p - 1); // 9

                var a = Math.Pow(g, k) % p;

                var b = (Math.Pow(y, k) * letterPosition) % p;

                shifrValueArray.Add(new Tuple<double, double>(a, b));
            }

            Console.Write($"\nЗашифрованное слово: ");
            foreach (var shifrValue in shifrValueArray)
            {
                Console.Write($"({shifrValue.Item1},{shifrValue.Item2}) ");
            }

            //Console.Write($"\nДешифрованное слово: ");
            //foreach (var shifrValue in shifrValueArray)
            //{
            //    var m = (shifrValue.Item2 * Math.Pow(shifrValue.Item1, p - 1 - x)) % p;

            //    // Console.Write($"{alphabet[(int)m]} ");
            //}

            //Console.WriteLine(word);

            Console.ReadLine();
        }
    }
}
