namespace Lab2.models
{
    using System.Drawing;

    public class Segment : IGrapgic
    {
        private PointF a;

        private PointF b;


        public Segment(PointF a, PointF b, Color color)
        {
            this.a = a;
            this.b = b;
            Color = color;
        }

        public Color Color { get; set; }

        public PointF? Function(double i)
        {
            var y = (float)((a.Y - b.Y) * -i - (a.X * b.Y - b.X * a.Y)) / (b.X - a.X);

            if (b.X < a.X)
            {
                if (i > a.X || i < b.X)
                {
                    return null;
                }
            }
            else if (i < a.X || i > b.X)
            {
                return null;
            }

            return new PointF((float)i, y);
        }
    }
}