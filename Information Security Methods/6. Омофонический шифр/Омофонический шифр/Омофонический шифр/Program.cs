namespace Омофонический_шифр
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static readonly Dictionary<char, string[]> TableCoderReplace = new Dictionary<char, string[]>()
        {
            ['А'] = new [] { "000", "001", "010", "100" },
            ['Б'] = new [] {"101", "110", "111" },
            ['В'] = new [] {"002", "020" },
            ['Г'] = new [] {"200", "202", "220", "222", "003", "030" },
            ['Д'] = new [] {"300", "303", "330", "333" },
            ['Е'] = new [] {"004", "040", "400" },
            ['Ё'] = new [] {"404", "440", "444", "005" },
            ['Ж'] = new [] {"050", "500", "505", "550", "555" },
            ['З'] = new [] {"006", "060", "600" },
            ['И'] = new [] {"606", "660" },
            ['Й'] = new [] {"666", "007", "070", "700" },
            ['К'] = new [] {"707", "770" },
            ['Л'] = new [] {"777", "008", "080" },
            ['М'] = new [] {"800", "880", "888", "009" },
            ['Н'] = new [] {"090", "900", "990", "909", "999" },
            ['О'] = new [] {"102", "103", "104", "105", "012" },
            ['П'] = new [] {"106", "107", "108", "109" },
            ['Р'] = new [] {"202", "203", "204", "205" },
            ['С'] = new [] {"206", "207", "208" },
            ['Т'] = new [] {"209", "210" },
            ['У'] = new [] {"211", "212", "213", "214" },
            ['Ф'] = new [] {"215", "216", "217", "218", "219", "221" },
            ['Х'] = new [] {"223", "224", "225", "226" },
            ['Ц'] = new [] {"013", "014", "016", "017" },
            ['Ч'] = new [] {"019" },
            ['Ш'] = new [] {"021", "023", "024", "025" },
            ['Щ'] = new [] {"026", "027", "028", "029", "031", "032", "034", "035" },
            ['Ъ'] = new [] {"036", "037", "038", "039" },
            ['Ы'] = new [] {"041", "042", "043", "045", "401" },
            ['Ь'] = new [] {"402", "431", "432" },
            ['Э'] = new [] {"501", "551" },
            ['Ю'] = new [] {"604", "661", "542", "890", "991" },
            ['Я'] = new [] {"177", "153", "190" },
            [' '] = new [] {"098" }
        };

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

            // CODE

            var coderedWord = string.Empty;

            var randpm = new Random();

            foreach (var letter in word)
            {
                var chars = TableCoderReplace[letter];

                coderedWord += chars[randpm.Next(chars.Length)];
            }


            // DECODE

            var decoderedWord = string.Empty;

            for (var i = 0; i < coderedWord.Length; i += 3)
            {
                var currentNumber = string.Empty;

                for (var j = 0; j < 3; j++)
                {
                    var key = i + j;
                    currentNumber += coderedWord[key];
                }
                
                foreach (var key in TableCoderReplace.Keys)
                {
                    decoderedWord += TableCoderReplace[key].Contains(currentNumber) ? new string(new [] { key }) : string.Empty;
                }
            }


            Console.WriteLine($"Закодированное: {coderedWord}");
            Console.WriteLine($"Раскодированное: {decoderedWord}");

            Console.ReadLine();
        }
    }
}
