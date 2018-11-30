namespace FiniteDifferences
{
    using System;

    /*
        Написать программу:
        На основании свойств конечных разностей найти значение полинома третьей степени P(x) в точке x=10(x=i, i=1,...,10),
        при условии, что сам полином не известен, а известны только первые 4 значения P(0)=1,P(1)=3,P(2)=7,P(3)=19. 
        + Реализовать в общем случае, когда степень полинома и значения x и P(x) вводятся с клавиатуры
    */

    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            double value = 10;

            var x = new [] { 0, 1, 2, 3 };
            var y = new [] { 1, 3, 7, 19 };

            var l = new double[y.Length, n];
            
            for (int i = 0; i < y.Length; i++)
            {
                l[i, 0] = y[i];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    l[j, i + 1] = 1.0 / (x[i + j + 1] - x[j]) * (l[j, i] * (x[i + j + 1] - value) - l[j + 1, i] * (x[j] - value));
                }
            }

            Console.WriteLine(l[0, n-1]);
            Console.WriteLine();

            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{l[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
