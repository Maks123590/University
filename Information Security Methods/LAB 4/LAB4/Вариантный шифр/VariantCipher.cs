namespace Вариантный_шифр
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class VariantCipher
    {
        private static readonly List<string> Alphabet = new List<string>
                                                            {
                                                                "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У",
                                                                "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", "я"
                                                            };

        private static readonly string[,] ColumnPairs =
            {
                { "Й", "Ц" },
                { "У", "К" },
                { "Е", "Н" },
                { "Г", "Ш" },
                { "Щ", "З" },
                { "Х", "Ъ" },
            };

        private static readonly string[,] RowPairs =
            {
                { "Ф", "Ы" },
                { "В", "А" },
                { "П", "Р" },
                { "О", "Л" },
                { "Д", "Ж" },
                { "Э", "Я" },
            };

        public VariantCipher(string keyWord)
        {
            this.KeyWord = keyWord.ToUpper();
        }

        private string KeyWord { get; }

        public string Encrypt(string word)
        {
            var alphabetMatrix = this.CreateAlphMatrix();

            var bigramms = new List<string>();

            var explBreak = false;

            foreach (var letter in word)
            {
                var letterInString = new string(new[] { letter });

                for (var i = 0; i < alphabetMatrix.GetLength(0); i++)
                {
                    for (var j = 0; j < alphabetMatrix.GetLength(1); j++)
                    {
                        if (alphabetMatrix[i, j] == letterInString)
                        {
                            bigramms.Add(this.GetBigramm(j, i));

                            explBreak = true;
                            
                            break;
                        }
                    }

                    if (explBreak)
                    {
                        explBreak = false;
                        break;
                    }
                }
            }

            return string.Join("_", bigramms);
        }

        public void WriteMatrix()
        {
            var alphabetMatrix = this.CreateAlphMatrix();

            Console.Write($"      ");

            for (int i = 0; i < ColumnPairs.GetLength(0); i++)
            {
                Console.Write($"[{ColumnPairs[i, 0]} {ColumnPairs[i, 1]}] ");
            }

            Console.WriteLine();

            for (var i = 0; i < alphabetMatrix.GetLength(0); i++)
            {
                Console.Write($"[{RowPairs[i, 0]} {RowPairs[i, 1]}]");

                for (var j = 0; j < alphabetMatrix.GetLength(1); j++)
                {
                    Console.Write($"   {alphabetMatrix[i, j]}  ");
                }

                Console.WriteLine();
            }
        }

        private string GetBigramm(int columnPos, int rowPos)
        {
            var random = new Random();

            if (random.Next(2) == 0)
            {
                return ColumnPairs[columnPos, random.Next(2)] + RowPairs[rowPos, random.Next(2)];
            }

            return RowPairs[rowPos, random.Next(2)] + ColumnPairs[columnPos, random.Next(2)];
        }

        private string[,] CreateAlphMatrix()
        {
            var let = (this.KeyWord + string.Join(string.Empty, Alphabet)).Select(x => x.ToString()).Distinct().ToList();

            if (let.Count < 36)
            {
                var stepsCount = 36 - let.Count;

                for (int i = 0; i < stepsCount; i++)
                {
                    let.Add("-");
                }
            }

            var alphMatrix = new string[6, 6];

            var tempIndex = 0;
            

            for (var i = 0; i < alphMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < alphMatrix.GetLength(1); j++)
                {
                    alphMatrix[i, j] = let[tempIndex];
                    Debug.Write($" {alphMatrix[i, j]} ");
                    tempIndex++;
                }

                Debug.WriteLine(string.Empty);
            }

            return alphMatrix;
        }
    }
}