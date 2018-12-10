namespace Задача_Коши
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            const int iterrationsCount = 10;

            var xStart = 0;
            var yStart = 0;
            
            var h = 0.1;

            Func<double, double, double> function = (x, y) => y - Math.Pow(x, 2);

            //Метод Рунге-Кутта

            var xArr = new double[iterrationsCount];
            var yArr = new double[iterrationsCount];
            var kArr = new double[4];

            xArr[0] = xStart;
            yArr[0] = yStart;

            var delta = 0.0;

            Console.WriteLine("Метод Рунге-Кутта");

            for (var i = 1; i < iterrationsCount; i++)
            {
                kArr[0] = h * function(xArr[i - 1], yArr[i - 1]);
                kArr[1] = h * function(xArr[i - 1] + (h / 2), yArr[i - 1] + kArr[0] / 2);
                kArr[2] = h * function(xArr[i - 1] + (h / 2), yArr[i - 1] + kArr[1] / 2);
                kArr[3] = h * function(xArr[i - 1] + h, yArr[i - 1] + kArr[2]);

                delta = (1.0 / 6) * (kArr[0] + 2 * kArr[1] + 2 * kArr[2] + kArr[3]);
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

            var ys = new double[iterrationsCount];
            ys[0] = function(xArr[0], yArr[0]);
            ys[1] = function(xArr[1], yArr[1]);
            ys[2] = function(xArr[2], yArr[2]);
            ys[3] = function(xArr[3], yArr[3]);

            var delta1 = new double[iterrationsCount];
            delta1[0] = ys[1] - ys[0];
            delta1[1] = ys[2] - ys[1];
            delta1[2] = ys[3] - ys[2];

            var delta2 = new double[iterrationsCount];
            delta2[0] = delta1[1] - delta1[0];
            delta2[1] = delta1[2] - delta1[1];

            var delta3 = new double[iterrationsCount];
            delta3[0] = delta2[1] - delta2[0];

            for (var i = 4; i < iterrationsCount; i++)
            {
                xArr[i] = xArr[i - 1] + h;
                yArr[i] = yArr[i - 1] + ((ys[i - 1]) + (1.0 / 2 * delta1[i - 2]) + (5.0 / 12 * delta2[i - 3]) + (3.0 / 8 * delta3[i - 4])) * h;

                ys[i] = function(xArr[i], yArr[i]);

                delta1[i - 1] = ys[i] - ys[i - 1];
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
