namespace Совмещенный_шифр
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class CombinedСipher
    {
        private static readonly List<string> Alphabet = new List<string>
                                                            {
                                                                "А",
                                                                "Б",
                                                                "В",
                                                                "Г",
                                                                "Д",
                                                                "Е",
                                                                "Ё",
                                                                "Ж",
                                                                "З",
                                                                "И",
                                                                "Й",
                                                                "К",
                                                                "Л",
                                                                "М",
                                                                "Н",
                                                                "О",
                                                                "П",
                                                                "Р",
                                                                "С",
                                                                "Т",
                                                                "У",
                                                                "Ф",
                                                                "Х",
                                                                "Ц",
                                                                "Ч",
                                                                "Ш",
                                                                "Щ",
                                                                "Ъ",
                                                                "Ы",
                                                                "Ь",
                                                                "Э",
                                                                "Ю",
                                                                "Я"
                                                            };

        private static readonly string[] ColumnKeys = { "0", "9", "8", "7", "6", "5", "4", "3", "2", "1" };

        private static readonly string[] RowKeys = { " ", "1", "2", "3" };

        public CombinedСipher(string keyWord)
        {
            this.KeyWord = keyWord.ToUpper();
        }

        private string KeyWord { get; }

        public string Encrypt(string word)
        {
            var alphabetMatrix = this.CreateAlphMatrix();

            var keywordLetters = this.KeyWord.Select(x => x.ToString()).Distinct().ToList();

            var numbers = new List<string>();

            var explBreak = false;

            foreach (var letter in word)
            {
                var letterInString = new string(new[] { letter });

                if (keywordLetters.Contains(letterInString))
                {
                    numbers.Add(ColumnKeys[keywordLetters.IndexOf(letterInString)]);
                }
                else
                {
                    for (var i = 1; i < alphabetMatrix.GetLength(0); i++)
                    {
                        for (var j = 0; j < alphabetMatrix.GetLength(1); j++)
                        {
                            if (alphabetMatrix[i, j] == letterInString)
                            {
                                numbers.Add(RowKeys[i]);
                                numbers.Add(ColumnKeys[j]);

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
            }

            return string.Join(string.Empty, numbers);
        }

        public void WriteMatrix()
        {
            var alphabetMatrix = this.CreateAlphMatrix();

            Console.Write("  ");

            for (int i = 0; i < ColumnKeys.Length; i++)
            {
                Console.Write($"{ColumnKeys[i]} ");
            }

            Console.WriteLine();

            for (var i = 0; i < alphabetMatrix.GetLength(0); i++)
            {
                Console.Write($"{RowKeys[i]} ");

                for (var j = 0; j < alphabetMatrix.GetLength(1); j++)
                {
                    Console.Write($"{alphabetMatrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        private string[,] CreateAlphMatrix()
        {
            var keywordLetters = this.KeyWord.Select(x => x.ToString()).Distinct().ToList();

            var letWithoutKeyword = (this.KeyWord + string.Join(string.Empty, Alphabet)).Select(x => x.ToString()).Distinct()
                .ToList().Except(keywordLetters).ToList();


            var steps = 10 - keywordLetters.Count;

            for (int i = 0; i < steps; i++)
            {
                keywordLetters.Add(" ");
            }
            
            if (letWithoutKeyword.Count < 30)
            {
                var stepsCount = 30 - letWithoutKeyword.Count;

                for (int i = 0; i < stepsCount; i++)
                {
                    letWithoutKeyword.Add("-");
                }
            }

            var alphMatrix = new string[4, 10];


            for (var j = 0; j < alphMatrix.GetLength(1); j++)
            {
                alphMatrix[0, j] = keywordLetters[j];
            }
            
            var tempIndex = 0;

            for (var i = 1; i < alphMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < alphMatrix.GetLength(1); j++)
                {
                    alphMatrix[i, j] = letWithoutKeyword[tempIndex];
                    Debug.Write($" {alphMatrix[i, j]} ");
                    tempIndex++;
                }

                Debug.WriteLine(string.Empty);
            }

            return alphMatrix;
        }
    }
}