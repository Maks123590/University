namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class QuadraticEquation
    {
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double a { get; set; }

        public double b { get; set; }

        public double c { get; set; }

        public double D => Math.Pow(b, 2) - (4 * a * c);

        public IEnumerable<double> Solve()
        {
            return D < 0 ? null : new List<double>() { (-b + Math.Sqrt(D)) / 2 * a, (-b - Math.Sqrt(D)) / 2 * a }.Distinct();
        }

        public Point GetExtremum()
        {
            var x = -b / 2 * a;
            var y = a * Math.Pow(x, 2) + b * x + c;

            return new Point(x, y);
        }

        public IEnumerable<Range> GetRanges()
        {
            var list = new List<Range>();

            if (a > 0)
            {
                list.Add(new Range
                             {
                                 From = -b / 2 * a,
                                 To = double.PositiveInfinity,
                                 Type = RangeType.Ascending
                             });

                list.Add(new Range
                             {
                                 To = -b / 2 * a,
                                 From = double.PositiveInfinity,
                                 Type = RangeType.Descending
                             });

                return list;
            }

            if (a < 0)
            {
                list.Add(new Range
                             {
                                 From = double.NegativeInfinity,
                                 To = -b / 2 * a,
                                 Type = RangeType.Ascending
                             });

                list.Add(new Range
                             {
                                 From = -b / 2 * a,
                                 To = double.PositiveInfinity,
                                 Type = RangeType.Descending
                             });

                return list;
            }

            if (b > 0)
            {
                list.Add(new Range
                             {
                                 From = double.NegativeInfinity,
                                 To = double.PositiveInfinity,
                                 Type = RangeType.Ascending
                             });
            }
            else
            {
                list.Add(new Range
                             {
                                 From = double.PositiveInfinity,
                                 To = double.NegativeInfinity,
                                 Type = RangeType.Ascending
                             });
            }

            return list;
        }
    }
}