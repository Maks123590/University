namespace Эмпирическая_зависимость
{
    using System;

    /*
     по заданным данным (набор точек (x,y)) определить вид эмпирической зависимости 
     использовать теорию из книги Демидович, Марон, Шувалова, таблица на стр. 103(7 эмпирических зависимостей) 
     + найти коэффициенты эмпирической формулы с двумя параметрами(используется метод наименьших квадратов).
     */


    class Program
    {
        static void Main(string[] args)
        {
            //var x = new double[] { 1, 2, 3, 4, 5 };
            //var y = new double[] { 2.9, 8.9, 19.1, 33.2, 50.8 };

            // Test for 1 function

            //var x = new double[] { 1, 2, 3, 4, 5 };
            //var y = new double[] { 2, 3, 4, 5, 6 };


            // Test for 2 function

            //var x = new double[] { 1, 2, 3, 4, 5 };
            //var y = new double[] { 1, 4, 9, 16, 25 };


            // Test for 3 function

            //var x = new double[] { 1, 2, 3, 4, 5 };
            //var y = new double[] { 2, 4, 8, 16, 32 };


            // Test for 4 function

            var x = new double[] { 1, 2, 3, 4, 5 };
            var y = new double[] { 29, 16.5, 12.33, 10.25, 9 };


            // Test for 5 function

            //var x = new double[] { 1, 2, 3, 4, 5 };
            //var y = new double[] { 1.66, 0.9, 0.625, 0.476, 0.384 };


            // Test for 6 function

            //var x = new double[] { 1, 2, 3, 4, 5 };
            //var y = new double[] { 0.9, 1.11, 1.2, 1.25, 1.282 };


            // Test for 7 function

            //var x = new double[] { 1, 2, 3, 4, 5 };
            //var y = new double[] { 7, 7.693, 8.098, 8.386, 8.609 };


            int type = DefineRelationType(x, y);

            (double, double) coefficients = (0, 0);

            switch (type)
            {
                case 1:
                    coefficients = function1(x, y);
                    break;
                case 2:
                    coefficients = function2(x, y);
                    break;
                case 3:
                    coefficients = function3(x, y);
                    break;
                case 4:
                    coefficients = function4(x, y);
                    break;
                case 5:
                    coefficients = function5(x, y);
                    break;
                case 6:
                    coefficients = function6(x, y);
                    break;
                case 7:
                    coefficients = function7(x, y);
                    break;
            }

            Console.WriteLine($"Вид зависимости: {type}");
            Console.WriteLine($"coefficient1: {coefficients.Item1}\ncoefficient2: {coefficients.Item2}");
            Console.ReadLine();
        }

        // y = ax + b
        public static (double, double) function1(double[] x, double[] y)
        {
            var f1 = SummWithFunction(x, y, (xi, yi) => xi * xi);
            var f2 = SummWithFunction(x, y, (xi, yi) => xi);
            var f3 = SummWithFunction(x, y, (xi, yi) => xi * yi);
            var f4 = SummWithFunction(x, y, (xi, yi) => yi);

            var second = (f2 * f3 - f1 * f4) / (Math.Pow(f2, 2) - x.Length * f1);
            var first = (f4 - second * x.Length) / f2;

            return (first, second);
        }

        // y = ax^b
        public static (double, double) function2(double[] x, double[] y)
        {
            var f1 = SummWithFunction(x, y, (xi, yi) => Math.Log(xi));
            var f2 = SummWithFunction(x, y, (xi, yi) => Math.Log(yi));
            var f3 = SummWithFunction(x, y, (xi, yi) => Math.Pow(Math.Log(xi), 2));
            var f4 = SummWithFunction(x, y, (xi, yi) => Math.Log(xi) * Math.Log(yi));

            
            var second = (x.Length * f4 - f1 * f2) / (x.Length * f3 - Math.Pow(f1, 2));
            var first = Math.Exp((f2 - second * f1) / x.Length);

            return (first, second);
        }

        // y = ab^x
        public static (double, double) function3(double[] x, double[] y)
        {
            var f1 = SummWithFunction(x, y, (xi, yi) => xi);
            var f2 = SummWithFunction(x, y, (xi, yi) => Math.Log(yi));
            var f3 = SummWithFunction(x, y, (xi, yi) => Math.Pow(xi, 2));
            var f4 = SummWithFunction(x, y, (xi, yi) => xi * Math.Log(yi));

            
            var second = (f4 - x.Length * f2) / (f3 - x.Length * f1);
            var first = f2 - second * f1;

            second = Math.Exp(second);
            first = Math.Exp(first);

            return (first, second);
        }

        // y = a + b / x
        public static (double, double) function4(double[] x, double[] y)
        {
            var f1 = SummWithFunction(x, y, (xi, yi) => 1 / Math.Pow(xi, 2));
            var f2 = SummWithFunction(x, y, (xi, yi) => 1 / xi);
            var f3 = SummWithFunction(x, y, (xi, yi) => yi / xi);
            var f4 = SummWithFunction(x, y, (xi, yi) => yi);
            
            var first = (f2 * f3 - f1 * f4) / (Math.Pow(f2, 2) - f1 * x.Length);
            var second = (f4 - first * x.Length) / f2;

            return (first, second);
        }

        // y = 1 / (ax + b) //// ???
        public static (double, double) function5(double[] x, double[] y)
        {
            var f1 = SummWithFunction(x, y, (xi, yi) => Math.Pow(xi, 2));
            var f2 = SummWithFunction(x, y, (xi, yi) => xi);
            var f3 = SummWithFunction(x, y, (xi, yi) => xi / yi);
            var f4 = SummWithFunction(x, y, (xi, yi) => 1 / yi);

            var second = (f2 * f3 - f1 * f4) / (Math.Pow(f2, 2) - f1 * x.Length);
            // var first = (f4 - first * x.Length) / f2;    // ???

            var first = (f4 - second * x.Length) / f2;

            return (first, second);
        }

        // y = x / (ax + b)
        public static (double, double) function6(double[] x, double[] y)
        {
            var f1 = SummWithFunction(x, y, (xi, yi) => 1 / (xi * yi));
            var f2 = SummWithFunction(x, y, (xi, yi) => 1 / xi);
            var f3 = SummWithFunction(x, y, (xi, yi) => 1 / yi);
            var f4 = SummWithFunction(x, y, (xi, yi) => Math.Pow(1 / xi, 2));

            
            var second = (x.Length * f1 - f2 * f3) / (x.Length * f4 - f2);
            var first = (f3 - second * f2) / x.Length;

            return (first, second);
        }

        // y = a * lnx + b
        public static (double, double) function7(double[] x, double[] y)
        {
            var f1 = SummWithFunction(x, y,  (xi, yi) => Math.Pow(Math.Log(xi), 2));
            var f2 = SummWithFunction(x, y,  (xi, yi) => Math.Log(xi));
            var f3 = SummWithFunction(x, y,  (xi, yi) => yi * Math.Log(xi));
            var f4 = SummWithFunction(x, y,  (xi, yi) => yi);

            var second = (f2 * f3 - f1 * f4) / (Math.Pow(f2, 2) - x.Length * f1);
            var first = (f4 - second * x.Length) / f2;

            return (first, second);
        }

        private static double SummWithFunction(double[] x, double[] y, Func<double, double, double> function)
        {
            double result = 0;
            for (var i = 0; i < x.Length; i++)
            {
                result += function(x[i], y[i]);
            }

            return result;
        }

        private static int DefineRelationType(double[] x, double[] y)
        {
            var array = new double[7, 5];

            var n = x.Length;

            array[0, 0] = (x[0] + x[n - 1]) / 2;
            array[1, 0] = Math.Sqrt(x[0] * x[n - 1]);
            array[2, 0] = (x[0] + x[n - 1]) / 2;
            array[3, 0] = (2 * x[0] * x[n - 1]) / (x[0] + x[n - 1]);
            array[4, 0] = (x[0] + x[n - 1]) / 2;
            array[5, 0] = (2 * x[0] * x[n - 1]) / (x[0] + x[n - 1]);
            array[6, 0] = Math.Sqrt(x[0] * x[n - 1]);

            array[0, 2] = (y[0] + y[n - 1]) / 2;
            array[1, 2] = Math.Sqrt(y[0] * y[n - 1]);
            array[2, 2] = Math.Sqrt(y[0] * y[n - 1]);
            array[3, 2] = (y[0] + y[n - 1]) / 2;
            array[4, 2] = (2 * y[0] * y[n - 1]) / (y[0] + y[n - 1]);
            array[5, 2] = (2 * y[0] * y[n - 1]) / (y[0] + y[n - 1]);
            array[6, 2] = (y[0] + y[n - 1]) / 2;

            for (var i = 0; i < 7; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (array[i, 0] == x[j])
                    {
                        array[i, 1] = y[j];
                        break;
                    }
                }
            }

            for (var i = 0; i < 7; i++)
            {
                if (array[i, 1] == 0)
                {
                    for (var j = 1; j < n; j++)
                    {
                        if (array[i, 0] > x[j - 1] && array[i, 0] < x[j])
                        {
                            array[i, 3] = y[j - 1] + ((y[j] - y[j - 1]) / (x[j] - x[j - 1])) * (array[i, 0] - x[j - 1]);
                            break;
                        }
                    }
                }
            }

            var minIndex = 0;

            for (var i = 0; i < 7; i++)
            {
                if (array[i, 1] != 0)
                {
                    array[i, 4] = Math.Abs(array[i, 1] - array[i, 2]);
                }
                else
                {
                    array[i, 4] = Math.Abs(array[i, 2] - array[i, 3]);
                }

                if (array[i, 4] < array[minIndex, 4])
                {
                    minIndex = i;
                }
            }

            return minIndex + 1;
        }
    }
}
