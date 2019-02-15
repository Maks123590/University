namespace Task5
{
    using System;

    public class Circle : Figure
    {
        public double r { get; set; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * r;
        }
    }
}