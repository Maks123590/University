namespace Шифр_цезаря
{
    using System.Text;

    public partial class Program
    {
        public class CaesarCipher
        {
            public static string Alphabet { get; set; }

            public static int Shift { private get; set; }

            public static string Encryption(string text)
            {
                text = text.ToLower();
                var res = new StringBuilder();

                foreach (char t in text)
                {
                    for (int j = 0; j < Alphabet.Length; j++)
                    {
                        if (t == Alphabet[j])
                        {
                            res.Append(Alphabet[(j + Shift) % Alphabet.Length]);
                        }
                    }
                }
                    

                return res.ToString();
            }

            public static string Decryption(string crypt)
            {
                crypt = crypt.ToLower();
                var res = new StringBuilder();

                foreach (char t in crypt)
                {
                    for (int j = 0; j < Alphabet.Length; j++)
                    {
                        if (t == Alphabet[j])
                        {
                            res.Append(Alphabet[(j - Shift + Alphabet.Length) % Alphabet.Length]);
                        }
                    }
                }
                    

                return res.ToString();
            }
        }
    }
}
