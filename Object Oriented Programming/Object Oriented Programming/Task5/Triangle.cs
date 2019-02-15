namespace Task5
{
    using System;

    public class Triangle : Figure
    {
        public double a { get; set; }

        public double b { get; set; }

        public double c { get; set; }

        public override double GetArea()
        {
            var p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double GetPerimeter()
        {
            return a + b + c;
        }
    }
}