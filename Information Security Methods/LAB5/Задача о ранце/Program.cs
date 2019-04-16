namespace Задача_о_ранце
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static readonly Dictionary<char, string> AlphabetDictionary = new Dictionary<char, string>()
        {
            ['а'] = "11000000",
            ['б'] = "11000001",
            ['в'] = "11000010",
            ['г'] = "11000011",
            ['д'] = "11000100",
            ['е'] = "11000101",
            ['ж'] = "11000110",
            ['з'] = "11000111",
            ['и'] = "11001000",
            ['й'] = "11001001",
            ['к'] = "11001010",
            ['л'] = "11001011",
            ['м'] = "11001100",
            ['н'] = "11001101",
            ['о'] = "11001110",
            ['п'] = "11001111",
            ['р'] = "11010000",
            ['с'] = "11010001",
            ['т'] = "11010010",
            ['у'] = "11010011",
            ['ф'] = "11010100",
            ['ч'] = "11010101",
            ['ц'] = "11010110",
            ['ч'] = "11010111",
            ['ш'] = "11011000",
            ['щ'] = "11011001",
            ['ъ'] = "11011010",
            ['ы'] = "11011011",
            ['ь'] = "11011100",
            ['э'] = "11011101",
            ['ю'] = "11011110",
            ['я'] = "11011111"
        };

        private static readonly Dictionary<string, char> AlphabetReverseDictionary = new Dictionary<string, char>()
        {
            ["11000000"] = 'а',
            ["11000001"] = 'б',
            ["11000010"] = 'в',
            ["11000011"] = 'г',
            ["11000100"] = 'д',
            ["11000101"] = 'е',
            ["11000110"] = 'ж',
            ["11000111"] = 'з',
            ["11001000"] = 'и',
            ["11001001"] = 'й',
            ["11001010"] = 'к',
            ["11001011"] = 'л',
            ["11001100"] = 'м',
            ["11001101"] = 'н',
            ["11001110"] = 'о',
            ["11001111"] = 'п',
            ["11010000"] = 'р',
            ["11010001"] = 'с',
            ["11010010"] = 'т',
            ["11010011"] = 'у',
            ["11010100"] = 'ф',
            ["11010101"] = 'ч',
            ["11010110"] = 'ц',
            ["11010111"] = 'ч',
            ["11011000"] = 'ш',
            ["11011001"] = 'щ',
            ["11011010"] = 'ъ',
            ["11011011"] = 'ы',
            ["11011100"] = 'ь',
            ["11011101"] = 'э',
            ["11011110"] = 'ю',
            ["11011111"] = 'я',
        };

        public static void Main(string[] args)
        {
            int[] privateKey = { 2, 3, 6, 13, 27, 52, 105, 210 };
            

            int m = 420; // больше суммы всех элементов из privateKey
            int t = 31;

            //// get publick key

            Console.Write("Публичный ключ: ");

            int[] publicKey = new int[privateKey.Length];

            for (int i = 0; i < privateKey.Length; i++)
            {
                publicKey[i] = (privateKey[i] * t) % m;
                Console.Write(publicKey[i] + " ");
            }

            Console.WriteLine();

            ////
            

            var enteredWord = "Абрамов".ToLower();

            Console.WriteLine($"Исходная строка: {enteredWord}");

            var viborkaCodov = new string[enteredWord.Length];

            Console.Write("\nВыборка кодов: ");

            for (int i = 0; i < enteredWord.Length; i++)
            {
                viborkaCodov[i] = AlphabetDictionary[enteredWord[i]];
                Console.Write(viborkaCodov[i] + " ");
            }

            Console.WriteLine();
            

            //// Encription

            var summa = new double[enteredWord.Length];

            for (var i = 0; i < enteredWord.Length; i++)
            {
                summa[i] = 0;
                for (var j = 0; j < privateKey.Length; j++)
                {
                    if (viborkaCodov[i][j] == '1')
                    {
                        summa[i] += publicKey[j];
                    }
                }
            }
            
            Console.Write("\nЗашифрованное слово: ");
            for (var i = 0; i < enteredWord.Length; i++)
            {
                Console.Write(summa[i] + " ");
            }

            Console.WriteLine();

            ////




            //var u = 0;

            //for (var i = 0; i < m; i++)
            //{
            //    if ((t * i) % m == 1)
            //    {
            //        u = i;
            //        break;
            //    }
            //}

            //for (int i = 0; i < enteredWord.Length; i++)
            //{
            //    var summaNew = (summa[i] * u) % m;

            //    Console.Write(summaNew + " ");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < enteredWord.Length; i++)
            //{
            //    Console.Write(viborkaCodov[i] + " ");
            //}

            //Console.WriteLine();


            //// Decription

            var reverseT = 271;


            var deshifrSumm = summa.Select(e => (e * reverseT) % m);
            
            var decryptedString = new string(deshifrSumm.Select(e => GetLetterFromSummItem(e, privateKey)).ToArray());

            Console.WriteLine($"\nДешифрованная строка: {decryptedString}");

            ////

            Console.ReadLine();
        }

        private static char GetLetterFromSummItem(double summItem, int[] privateKey)
        {
            var tempSumm = summItem;

            var preResultArray = new List<char>();

            for (int i = privateKey.Length - 1; i >= 0; i--)
            {
                if (privateKey[i] <= tempSumm)
                {
                    preResultArray.Add('1');
                    tempSumm = tempSumm - privateKey[i];
                }
                else
                {
                    preResultArray.Add('0');
                }
            }

            preResultArray.Reverse();

            var preResult = new string(preResultArray.ToArray());

            return AlphabetReverseDictionary[preResult];
        }
    }
}
