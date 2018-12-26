namespace Задача_Коши
{
    using System;

    class Program
    {
        /*
         методом Рунге-Кутта 4 порядка и методом экстраполяции Адамса найти численное решение задачи Коши: dy/dx=y-x^2, y(1)=0, h=0.1 в первых десяти точках, т.е. на отрезке [1,2]
         */

        static void Main(string[] args)
        {
            const int iterrationsCount = 10;

            var xStart = 1.0;
            var yStart = 0.0;
            
            var h = 0.1;

            Func<double, double, double> function = (x, y) => y - Math.Pow(x, 2);

            //Метод Рунге-Кутта

            var xArr = new double[iterrationsCount];
            var yArr = new double[iterrationsCount];
            var kArr = new double[4];

            xArr[0] = xStart;
            yArr[0] = yStart;

            Console.WriteLine("Метод Рунге-Кутта");

            for (var i = 1; i < iterrationsCount; i++)
            {
                kArr[0] = h * function(xArr[i - 1], yArr[i - 1]);
                kArr[1] = h * function(xArr[i - 1] + (h / 2), yArr[i - 1] + kArr[0] / 2);
                kArr[2] = h * function(xArr[i - 1] + (h / 2), yArr[i - 1] + kArr[1] / 2);
                kArr[3] = h * function(xArr[i - 1] + h, yArr[i - 1] + kArr[2]);

                var delta = (1.0 / 6) * (kArr[0] + 2 * kArr[1] + 2 * kArr[2] + kArr[3]);
                yArr[i] = +(yArr[i - 1] + delta);
                xArr[i] = +(xArr[i - 1] + h);
                
            };

            for (int i = 0; i < iterrationsCount; i++)
            {
                Console.WriteLine($"x{i + 1}: {xArr[i]} y{i + 1}: {yArr[i]}");
            }

            ////

            // Mетод экстраполяции Адамса

            Console.WriteLine("\n\nMетод экстраполяции Адамса");

            var yt = new double[iterrationsCount];
            yt[0] = function(xArr[0], yArr[0]);
            yt[1] = function(xArr[1], yArr[1]);
            yt[2] = function(xArr[2], yArr[2]);
            yt[3] = function(xArr[3], yArr[3]);

            var delta1 = new double[iterrationsCount];
            delta1[0] = yt[1] - yt[0];
            delta1[1] = yt[2] - yt[1];
            delta1[2] = yt[3] - yt[2];

            var delta2 = new double[iterrationsCount];
            delta2[0] = delta1[1] - delta1[0];
            delta2[1] = delta1[2] - delta1[1];

            var delta3 = new double[iterrationsCount];
            delta3[0] = delta2[1] - delta2[0];

            for (var i = 4; i < iterrationsCount; i++)
            {
                xArr[i] = xArr[i - 1] + h;
                yArr[i] = yArr[i - 1] + ((yt[i - 1]) + (1.0 / 2 * delta1[i - 2]) + (5.0 / 12 * delta2[i - 3]) + (3.0 / 8 * delta3[i - 4])) * h;

                yt[i] = function(xArr[i], yArr[i]);

                delta1[i - 1] = yt[i] - yt[i - 1];
                delta2[i - 2] = delta1[i - 1] - delta1[i - 2];
                delta3[i - 3] = delta2[i - 2] - delta2[i - 3];
            }

            for (int i = 0; i < iterrationsCount; i++)
            {
                Console.WriteLine($"x{i + 1}: {xArr[i]} y{i + 1}: {yArr[i]}");
            }

            ////

            Console.ReadLine();
        }
    }
}
