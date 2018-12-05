namespace Gauss_JordanMethod
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args) // Доделать
        {
            var matrix = new[]
                             {
                                 new double[] { 1, -4, 1, 1 },
                                 new double[] { 1, -1, -4, 3 },
                                 new double[] { 3, -1, 1, 0 },
                             };

            MatrixWriteline(matrix);

            // прямой ход
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    matrix[j] = SummVectors(matrix[j], MultipleVectorOnConstant(matrix[i], -matrix[j][i] / matrix[i][i]));
                }

                MatrixWriteline(matrix);
            }

            //Обратный ход
            for (int i = matrix.Length - 1; i >= 0 ; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    matrix[j] = SummVectors(matrix[j], MultipleVectorOnConstant(matrix[i], -matrix[j][i] / matrix[i][i]));
                }

                MatrixWriteline(matrix);
            }

            //Деление на ведущий элемент
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = MultipleVectorOnConstant(matrix[i], 1.0 / matrix[i][i]);
            }

            MatrixWriteline(matrix);

            Console.ReadLine();
        }

            private static double[] SummVectors(double[] a, double[] b)
        {
            return a.Zip(b, (f, s) => f + s).ToArray();
        }

        private static double[] MultipleVectorOnConstant(double[] vector, double constant)
        {
            return vector.Select(v => v * constant).ToArray();
        }

        private static void MatrixWriteline(double[][] matrix)
        {
            Console.WriteLine();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {

                    Console.Write($" {matrix[i][j], 4} ");
                }

                Console.Write('|');

                Console.WriteLine($" {matrix[i][matrix[i].Length - 1], 4} ");
            }

            Console.WriteLine();
        }
    }
}
