namespace Шифр_перестановки
{
    using System;

    public class Transposition
    {
        private int[] Key { get; set; } = null;

        public void SetKey(int[] key)
        {
            this.Key = new int[key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                this.Key[i] = key[i];
            }
        }

        public void SetKey(string[] key)
        {
            this.Key = new int[key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                this.Key[i] = Convert.ToInt32(key[i]);
            }
        }

        public void SetKey(string key)
        {
            this.SetKey(key.Split(' '));
        }

        public string Encrypt(string input)
        {
            for (int i = 0; i < input.Length % this.Key.Length; i++)
            {
                input += input[i];
            }

            var result = string.Empty;

            for (var i = 0; i < input.Length; i += this.Key.Length)
            {
                char[] transposition = new char[this.Key.Length];

                for (int j = 0; j < this.Key.Length; j++)
                {
                    transposition[this.Key[j] - 1] = input[i + j];
                }

                for (int j = 0; j < this.Key.Length; j++)
                {
                    result += transposition[j];
                }
            }

            return result;
        }

        public string Decrypt(string input)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length; i += this.Key.Length)
            {
                char[] transposition = new char[this.Key.Length];

                for (int j = 0; j < this.Key.Length; j++)
                {
                    transposition[j] = input[i + this.Key[j] - 1];
                }

                for (int j = 0; j < this.Key.Length; j++)
                {
                    result += transposition[j];
                }
            }

            return result;
        }
    }
}
