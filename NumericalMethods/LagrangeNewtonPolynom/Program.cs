namespace LagrangeNewtonPolynom
{
    using System;

    class Program
    {
        /*
         Написать программу: найти значение табличной функции используя полном Лагранжа и Ньютона
         */

        static void Main()
        {
            const int size = 10;

            var xValues = new double[size];
            var yValues = new double[size];

            for (var i = 0; i < size; i++)
            {
                xValues[i] = i;
                yValues[i] = TestFunction(i);
            }

            var step = 1;

            Console.WriteLine($"Интерполяция полиномом Лагранжа: {InterpolateLagrangePolynomial(0.25, xValues, yValues, size)}");
            Console.WriteLine($"Интерполяция полиномом Ньютона: {InterpolateNewtonPolynomial(0.25, xValues, yValues, 1)}");
            Console.ReadLine();
        }

        static double InterpolateLagrangePolynomial(double x, double[] xValues, double[] yValues, int size)
        {
            double lagrangePol = 0;

            for (var i = 0; i < size; i++)
            {
                double basicsPol = 1;
                for (var j = 0; j < size; j++)
                {
                    if (j != i)
                    {
                        basicsPol *= (x - xValues[j]) / (xValues[i] - xValues[j]);
                    }
                }
                lagrangePol += basicsPol * yValues[i];
            }

            return lagrangePol;
        }

        static double InterpolateNewtonPolynomial(double x, double[] xValues, double[] yValues, int step)
        {
            var factorial = (Func<double, double>)((value) =>
            {
                var fact = 1;

                for (var i = 2; i <= value; i++)
                {
                    fact *= i;
                }

                return fact;
            });

            Func<int, int, double> delta = null;
    
            delta = (p, i) =>
            {
                if (p == 1)
                    return yValues[i] - yValues[i - 1];
                return delta(p - 1, i) - delta(p - 1, i - 1);
            };

            var Cj = (Func<int, double>)(j =>
            {
                if (j == 0)
                    return yValues[0];
                var delt = delta(j, j);
                return delt / (factorial(j) * Math.Pow(step, j));
            });

            
            var n = xValues.Length;
            var result = Cj(0);

            for (var j = 1; j < n; j++)
            {
                var something = Cj(j);

                for (var k = 0; k < j; k++)
                {
                    something *= x - xValues[k];
                }

                result += something;
            }

            return result;

            

        }

        static double TestFunction(double x)
        {
            return x * x * x + 3 * x * x + 3 * x + 1; // for example
        }
    }
}
