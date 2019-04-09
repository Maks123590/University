namespace Шифр_Плейфера
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public class PlayfairCipher
    {
        public PlayfairCipher(string alphabet, string keyWord)
        {
            this.KeyWord = string.Join(string.Empty, keyWord.ToLower().Replace("й", "и").Replace("ё", "е").Replace("ъ", "ь").Replace(" ", string.Empty).Distinct());

            this.Alphabet = alphabet.ToLower()
                .Replace("й", string.Empty)
                .Replace("ё", string.Empty)
                .Replace(" ", string.Empty)
                .Replace("ь", string.Empty);
        }

        private string Alphabet { get; }

        private string KeyWord { get; }

        public string Crypt(string message)
        {
            Func<string[,], int[], int[], string> getPair = GetPairForCrypt;

            return this.CryptOrUncrypt(message, getPair);
        }

        public string Uncrypt(string message)
        {
            Func<string[,], int[], int[], string> getPair = GetPairForUncrypt;

            return this.CryptOrUncrypt(message, getPair);
        }

        public string[,] GetAlphabetMatrix() => this.CreateAlphMatrix();

        private static string GetPairForUncrypt(string[,] aplhMatrix, int[] firstLetterIndexs, int[] secondLetterIndexs)
        {
            var pair = string.Empty;

            if (firstLetterIndexs[0] == secondLetterIndexs[0])
            {
                pair += aplhMatrix[
                    firstLetterIndexs[0],
                      ((firstLetterIndexs[1] - 1 + aplhMatrix.GetLength(1)) % aplhMatrix.GetLength(1))];

                pair += aplhMatrix[
                    secondLetterIndexs[0],
                      ((secondLetterIndexs[1] - 1 + aplhMatrix.GetLength(1)) % aplhMatrix.GetLength(1))];
            }
            // В одном столбце
            else if (firstLetterIndexs[1] == secondLetterIndexs[1])
            {
                pair += aplhMatrix[
                 ((firstLetterIndexs[0] - 1 + aplhMatrix.GetLength(0)) % aplhMatrix.GetLength(0)),
                    firstLetterIndexs[1]];


                pair += aplhMatrix[
                ((secondLetterIndexs[0] - 1 + aplhMatrix.GetLength(0)) % aplhMatrix.GetLength(0)),
                    secondLetterIndexs[1]];
            }
            // В одном блое
            else
            {
                pair += aplhMatrix[
                   firstLetterIndexs[0],
                   secondLetterIndexs[1]];

                pair += aplhMatrix[
                    secondLetterIndexs[0],
                    firstLetterIndexs[1]];
            }

            return pair;
        }

        private static string GetPairForCrypt(string[,] aplhMatrix, int[] firstLetterIndexs, int[] secondLetterIndexs)
        {
            var pair = string.Empty;

            if (firstLetterIndexs[0] == secondLetterIndexs[0])
            {
                pair += aplhMatrix[
                 firstLetterIndexs[0],
                   ((firstLetterIndexs[1] + 1) % aplhMatrix.GetLength(1))];

                pair += aplhMatrix[
                    secondLetterIndexs[0],
                      ((secondLetterIndexs[1] + 1) % aplhMatrix.GetLength(1))];
            }
            else // В одном столбце
            if (firstLetterIndexs[1] == secondLetterIndexs[1]) 
            {
                pair += aplhMatrix[
                 (firstLetterIndexs[0] + 1) % aplhMatrix.GetLength(0),
                    firstLetterIndexs[1]];

                pair += aplhMatrix[(secondLetterIndexs[0] + 1) % aplhMatrix.GetLength(0), secondLetterIndexs[1]];
            }
            else // В одном блоке
            {
                pair += aplhMatrix[firstLetterIndexs[0], secondLetterIndexs[1]];

                pair += aplhMatrix[secondLetterIndexs[0], firstLetterIndexs[1]];
            }

            return pair;
        }

        private static int[] GetIndex(string[,] matrix, string letter)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == letter)
                        return new int[] { i, j };
                }
            }
            throw new Exception();
        }

        private static IEnumerable<Bigram> CreateBigrams(string normalMessage)
        {
            normalMessage = normalMessage.ToLower()
                .Replace("й", "и")
                .Replace("ё", "е")
                .Replace("ь", "ъ")
                .Replace(" ", string.Empty);
            var temp = new List<Bigram>();

            for (int i = 0; i < normalMessage.Length; i += 2)
            {
                if (i == normalMessage.Length - 1)
                {
                    temp.Add(new Bigram()
                    {
                        FirstLetter = normalMessage[i].ToString(),
                        SecondLetter = "х"
                    });
                }
                else if (normalMessage[i] == normalMessage[i + 1])
                {
                    temp.Add(new Bigram()
                    {
                        FirstLetter = normalMessage[i].ToString(),
                        SecondLetter = "х"
                    });
                    i--;
                }
                else
                {
                    temp.Add(new Bigram()
                    {
                        FirstLetter = normalMessage[i].ToString(),
                        SecondLetter = normalMessage[i + 1].ToString()
                    });
                }
            }

            return temp;
        }

        private string CryptOrUncrypt(string message, Func<string[,], int[], int[], string> getPair)
        {
            var alphMatrix = this.CreateAlphMatrix();
            var bigrams = CreateBigrams(message);

            var returnMessage = string.Empty;

            foreach (var bi in bigrams)
            {
                var fIndex = GetIndex(alphMatrix, bi.FirstLetter);
                var sIndex = GetIndex(alphMatrix, bi.SecondLetter);

                returnMessage += getPair(alphMatrix, fIndex, sIndex);
            }

            return returnMessage;
        }

        private string[,] CreateAlphMatrix()
        {
            var let = (this.KeyWord + this.Alphabet).Select(x => x.ToString()).Distinct().ToArray();

            var alphMatrix = new string[5, 6];

            var tempIndex = 0;

            Debug.WriteLine("New alphabet:");

            for (var i = 0; i < alphMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < alphMatrix.GetLength(1); j++)
                {
                    alphMatrix[i, j] = let[tempIndex];
                    Debug.Write(alphMatrix[i, j] + " ");
                    tempIndex++;
                }

                Debug.WriteLine(string.Empty);
            }

            return alphMatrix;
        }
    }
}