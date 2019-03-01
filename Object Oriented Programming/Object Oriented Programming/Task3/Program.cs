namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var euqations = new[]
                                {
                                    new QuadraticEquation(2, 4, 2),
                                    new QuadraticEquation(1, 5, 4),
                                    new QuadraticEquation(1, 5, 0),
                                    new QuadraticEquation(2, 2, 16),
                                    new QuadraticEquation(2, 5, 10),
                                };

            var allRoots = new List<double>();

            for (int i = 0; i < euqations.Length; i++)
            {
                Console.WriteLine($"Корни уравнения {i + 1}: ");

                var roots = euqations[i].Solve();

                var rootsArray = roots?.ToArray() ?? new double[0];

                allRoots.AddRange(rootsArray);

                if (rootsArray.Length == 0)
                {
                    Console.WriteLine("Корней нет");
                    continue;
                }
                

                for (var j = 0; j < rootsArray.Length; j++)
                {
                    Console.WriteLine($"   x{j + 1} = {rootsArray[j]}");
                }
            }

            Console.WriteLine($"Максимальный корень {allRoots.Max()}");
            Console.WriteLine($"Минимальный корень {allRoots.Min()}");

            Console.ReadLine();
        }
    }
}
