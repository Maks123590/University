namespace RunningMethod
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            //var A = new[,]
            //            {
            //                { 2, 1, 0, 0 },
            //                { 1, 10, -5, 0 },
            //                { 0, 1, -5, 2 },
            //                { 0, 0, 1, 4 }
            //            };

            //var f = new double[] { -5, -18, -40, -27 };


            var A = new[,]
                        {
                            { 4.5, 0.5, 0, 0 },
                            { 1, 2.6, 0.9, 0 },
                            { 0, 0.4, 2.5, 0.5 },
                            { 0, 0, 0.5, 1.5 }
                        };

            var f = new double[] { 1, 0, 1, 0 };

            var a = new[] { 0, A[1, 0], A[2, 1], A[3, 2] };
            var b = new[] { A[0, 0], A[1, 1], A[2, 2], A[3, 3] };
            var c = new[] { A[0, 1], A[1, 2], A[2, 3], 0 };  // last 0?
            var d = f;



            int n = a.Length;

            var y = new double[n];
            var alpha = new double[n];
            var betta = new double[n];
            var x = new double[n];



            y[0] = b[0];

            alpha[0] = -c[0] / y[0];
            betta[0] = d[0] / y[0];

            for (int i = 1; i <= n - 2; i++)
            {
                y[i] = a[i] * alpha[i - 1] + b[i];

                alpha[i] = -c[i] / y[i];
                betta[i] = (d[i] - a[i] * betta[i - 1]) / y[i];
            }

            alpha[n - 1] = 0;
            betta[n - 1] = (d[n - 1] - a[n - 1] * betta[n - 2]) / (a[n - 1] * alpha[n - 2] + b[n - 1]);

            x[n - 1] = betta[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                x[i] = alpha[i] * x[i + 1] + betta[i];
            }


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x[{i+1}] = {x[i]}");
            }
            
            Console.ReadLine();
        }
    }
}
