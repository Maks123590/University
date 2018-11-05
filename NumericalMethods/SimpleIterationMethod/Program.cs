namespace SimpleIterationMethod
{
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

            double x1, x2, x3, x4;
            double lastX1, lastX2, lastX3, lastX4;

            x1 = x2 = x3 = x4 = 0;
            lastX1 = lastX2 = lastX3 = lastX4 = 0;

            var rightPrecision = 0.001;
            var i = 0;
            var z = 0d;

            do
            {
                lastX1 = x1;
                lastX2 = x2;
                lastX3 = x3;
                lastX4 = x4;

                x1 = -0.04 * lastX2 + 0.21 * lastX3 - 0.18 * lastX4 + 1.24;
                x2 = 0.45 * lastX1 + 0.06 * lastX3 - 0.88;
                x3 = 0.26 * lastX1 + 0.34 * lastX2 - 0.62;
                x4 = 0.05 * lastX1 - 0.26 * lastX2 + 0.34 * lastX3 - 1.17;

                z = GetPrecision(lastX1, lastX2, lastX3, lastX4, x1, x2, x3, x4);

                Console.CursorTop = 0;
                Console.WriteLine($"Итерация: {++i}");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
                Console.WriteLine($"x3 = {x3}");
                Console.WriteLine($"x4 = {x4}");
                Console.WriteLine($"z = {z}");

                Task.Delay(1000).Wait();
            }
            while (z > rightPrecision);

            Console.ReadLine();
        }

        private static double GetPrecision(double lastx1, double lastx2, double lastx3, double lastx4, double x1, double x2, double x3, double x4) =>
                    Math.Max(Math.Max(Math.Abs(x1 - lastx1), Math.Abs(x2 - lastx2)), Math.Max(Math.Abs(x3 - lastx3), Math.Abs(x4 - lastx4)));
    }
}
