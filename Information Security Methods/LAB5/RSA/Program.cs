namespace RSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static readonly List<string> Alphabet = new List<string>()
                                                     {
                                                         "",
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

        public static void Main(string[] args)
        {
            var p = 7;
            var q = 13;

            Func<int, int, int> eilerFunct = (P, Q) => (P - 1) * (Q - 1);

            Func<int, int, int> evclidAlgorithm = (firstNumb, sechondNumb) =>
                {
                    while (firstNumb != 0 && sechondNumb != 0)
                    {
                        if (firstNumb > sechondNumb)
                        {
                            firstNumb = firstNumb % sechondNumb;
                        }
                        else
                        {
                            sechondNumb = sechondNumb % firstNumb;
                        }
                    }

                    return firstNumb + sechondNumb;
                };

            var n = p * q;

            var phi = eilerFunct(p, q);


            // Get public key

            int publicKey = 0;

            for (int i = 2; i < phi; i++)
            {
                if (evclidAlgorithm(i, phi) == 1)
                {
                    publicKey = i;
                    break;
                }
            }

            // Get private key

            var privateKey = 0;

            for (var i = 2; i <= 1000; i++)
            {
                if ((i * publicKey) % phi == 1)
                {
                    privateKey = i;
                    break;
                }
            }

            ////////

            var word = "Абрамов".ToUpper();

            Console.WriteLine($"word = {word}");

            Console.WriteLine($"p = {p}\nq = {q}");
            Console.WriteLine($"n = {n}\nphi = {phi}");

            Console.WriteLine($"publicKey = {publicKey}\nprivateKey = {privateKey}");

            var encryptedWord = Encrypt(word, publicKey, n);
            var decryptedWord = Decrypt(encryptedWord, privateKey, n);

            Console.WriteLine($"Encrypted: {encryptedWord}");
            Console.WriteLine($"Decrypted: {decryptedWord}");

            Console.ReadLine();
        }

        public static string Encrypt(string word, int publicKey, int n)
        {
            var result = new List<string>();

            foreach (var letter in word)
            {
                var tmp = 1;

                for (var i = 1; i <= publicKey; i++)
                {
                    tmp = (tmp * Alphabet.IndexOf(new string(new[] { letter }))) % n;
                }

                result.Add(tmp.ToString());
            }

            return string.Join(",", result);
        }

        public static string Decrypt(string word, int privateKey, int n)
        {
            var result = new List<string>();

            foreach (var letter in word.Split(","))
            {
                var tmp = 1;

                for (var i = 1; i <= privateKey; i++)
                {
                    tmp = (tmp * int.Parse(letter)) % n;
                }

                result.Add(Alphabet[tmp]);
            }

            return string.Join(string.Empty, result);
        }
    }
}
