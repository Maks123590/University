namespace Шифр_Хилла
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static readonly List<string> Alphabet = new List<string>
            {
                "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У",
                "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", "я"
            };

        private static readonly int[,] CoderMatrix = { { 6, 27, 1 }, { 13, 16, 32 }, { 28, 17, 15 } };

        private static readonly int[,] DecoderedMatrix = { { 2, 26, 17 }, { 26, 20, 4 }, { 13, 30, 21 } };
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");

            var word = Console.ReadLine()?.Replace(" ", string.Empty).ToUpper();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Слово введено неверно");
                Console.ReadLine();
                return;
            }

            for (var i = 0; i < word.Length % 3; i++)
            {
                word += Alphabet[33];
            }

            // CODE

            var indexList = GetIndexMatrix(word);

            var result = new int[indexList.Length][];

            var coderedWord = string.Empty;

            int tmp;
            for (var i = 0; i < indexList.Length; i++)
            {
                result[i] = new int[indexList[i].Length];

                for (var j = 0; j < indexList[i].Length; j++)
                {
                    tmp = 0;

                    for (var k = 0; k < indexList[i].Length; k++)
                    {
                        tmp += CoderMatrix[j, k] * indexList[i][k];
                    }

                    result[i][j] = tmp % 33;
                    coderedWord += Alphabet[tmp % 33];
                }
            }


            // DECODE

            var decoderedWord = string.Empty;

            for (var i = 0; i < result.Length; i++)
            {
                for (var j = 0; j < result[i].Length; j++)
                {
                    tmp = 0;
                    for (var k = 0; k < result[i].Length; k++)
                    {
                        tmp += DecoderedMatrix[j, k] * result[i][k];
                    }

                    decoderedWord += Alphabet[tmp % 33];
                }
            }

            Console.WriteLine($"Закодированное: {coderedWord}");
            Console.WriteLine($"Раскодированное: {decoderedWord.Substring(0, word.Length)}");

            Console.ReadLine();
        }
        
        private static int[][] GetIndexMatrix(string word)    // переводит в матрицу индексов согласно алфавиту
        {
            var indexList = new int[Convert.ToInt32(Math.Ceiling(word.Length / 3.0))][];
            var index = 0;
            for (var i = 0; i < word.Length; i += 3)
            {
                indexList[index] = new int[3];

                for (var j = i; j < 3 + i; j++)
                {
                    var charString = word[j].ToString();

                    indexList[index][j - i] = Alphabet.IndexOf(charString);
                }

                index++;
            }

            return indexList;
        }
    }
}
