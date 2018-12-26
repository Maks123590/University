namespace Метод_Простой_итерации_и_комбинированной__Ньютона__для_уравнения
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            SimpleIteration();
            NewTonMethod();

            Console.ReadLine();

        }

        public static void SimpleIteration()
        {
            const double eps = 0.0001;
            var x0 = 0.0;
            var x1 = 0.0;

            Func<double, double> function = x => (1 / 3.0) * (1 - Math.Pow(x, 3.0));

            do
            {
                x1 = function(x0);

                if (Math.Abs(x1 - x0) >= eps)
                {
                    break;
                }
                x0 = x1;
            } while (Math.Abs(x0 - function(x0)) > eps);

            Console.WriteLine($"Ответ: X = {x1} ");
        }

        public static void NewTonMethod()
        {
            //возвращает значение функции f(x) = x^3 + 3x - 1
            Func<double, double> f = x => Math.Pow(x, 3) + 3 * x - 1;

            //возвращает значение производной
            Func<double, double> df = x => 3 * Math.Pow(x, 2) + 3;

            // значение второй производной
            Func<double, double> d2f = x => 6 * x;

            double x0, xn;// вычисляемые приближения для корня

            // границы отрезка и необходимая точность
            var a = 0;
            var b = 1;
            var eps = 0.0001;

            if (f(a) * f(b) > 0) // если знаки функции на краях отрезка одинаковые, то здесь нет корня
            {
                Console.WriteLine("\nError! No roots in this interval\n");
            }
            else
            {
                x0 = f(a) * d2f(a) > 0 ? a : b; // для выбора начальной точки проверяем f(x0)*d2f(x0)>0 ?

                xn = x0 - f(x0) / df(x0); // считаем первое приближение

                while (Math.Abs(x0 - xn) > eps)
                {
                    x0 = xn;
                    xn = x0 - f(x0) / df(x0); // формула Ньютона
                }

                Console.WriteLine($"answer = {xn}"); // вывод вычисленного корня
            }
        }
    }
}
