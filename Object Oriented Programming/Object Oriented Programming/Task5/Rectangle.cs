namespace Task5
{
    public class Rectangle : Figure
    {
        public double a { get; set; }

        public double b { get; set; }

        public override double GetArea()
        {
            return a * b;
        }

        public override double GetPerimeter()
        {
            return (a + b) * 2;
        }
    }
}