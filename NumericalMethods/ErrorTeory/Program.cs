namespace ErrorTeory
{
    using System;
    using System.Globalization;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.");
            
            var a1 = Math.Sqrt(18);
            var a2 = 17 / 11.0;

            var q1 = Math.Round(Math.Abs(a1 - 4.24), 7); // предельные абсолютные погрешности
            var q2 = Math.Round(Math.Abs(a2 - 1.545), 7);

            var delta1 = q1 / 4.24; // предельные относительные погрешности
            var delta2 = q2 / 1.545;

            Console.WriteLine((delta1 < delta2 ? "Первое равенство точнее" : "Второе равенство точнее"));

            //2 a)
            var a = 24.3618;
            var deltaA = a * 0.0022; // абсолютная погрешность

            Console.WriteLine("2. a)");
            Console.WriteLine($"Число из верных цифр в узком смысле {Task2(a, deltaA, Type.Strait)}");
            Console.WriteLine($"Число из верных цифр в широком смысле {Task2(a, deltaA, Type.Large)}");

            //2 b)
            var b = 0.8647;
            var deltaB = 0.0013; // абсолютная погрешность

            Console.WriteLine("2. b)");
            Console.WriteLine($"Число из верных цифр в узком смысле {Task2(b, deltaB, Type.Strait)}");
            Console.WriteLine($"Число из верных цифр в широком смысле {Task2(b, deltaB, Type.Large)}");

            //3 a)
            Console.WriteLine("3. a)");
            Console.WriteLine($"Предельная абсолютная погрешность. Число из верных цифр в узком смысле {Task3(2.4516, Type.Strait).Абсолютная}");
            Console.WriteLine($"Предельная относительная погрешность. Число из верных цифр в узком смысле {Task3(2.4516, Type.Strait).Относительная}");

            //3 b)
            Console.WriteLine("3. b)");
            Console.WriteLine($"Предельная абсолютная погрешность. Число из верных цифр в широком смысле {Task3(0.863, Type.Large).Абсолютная}");
            Console.WriteLine($"Предельная относительная погрешность. Число из верных цифр в широком смысле {Task3(0.863, Type.Large).Относительная}");

            Console.ReadLine();
        }

        private static double Task2(double a, double deltaA, Type type)
        {
            StringBuilder trueNumbers = new StringBuilder();

            var strA = a.ToString(CultureInfo.InvariantCulture).Split('.');

            trueNumbers.Append(strA[0]);

            var fraction = strA[1];

            var firstIter = true;

            var p = 0.1;
            var i = 0;

            while (p / (int)type > deltaA)
            {
                if (firstIter)
                {
                    trueNumbers.Append('.');
                    firstIter = false;
                }

                trueNumbers.Append(fraction[i]);
                p /= 10;
                i++;
            }

            return double.Parse(trueNumbers.ToString(), CultureInfo.InvariantCulture);
        }

        private static ПредельнаяПогрешность Task3(double number, Type type)
        {
            var fractionLength= number.ToString(CultureInfo.InvariantCulture).Split('.')[1].Length;

            var предельнаяАбсолютнаяПогрешность = 1.0 / Math.Pow(10, fractionLength - 1) / (int)type;

            var предельнаяОтносительнаяПогрешность = предельнаяАбсолютнаяПогрешность / number;

            return new ПредельнаяПогрешность
            {
                Абсолютная = предельнаяАбсолютнаяПогрешность,
                Относительная = предельнаяОтносительнаяПогрешность,
            };
        }
        
        
        public class ПредельнаяПогрешность
        {
            public double Абсолютная { get; set; }

            public double Относительная { get; set; }
        }

        private enum Type
        {
            Large = 1,
            Strait = 2,
        }
    }
}
