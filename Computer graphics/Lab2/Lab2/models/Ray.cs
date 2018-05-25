namespace Lab2.models
{
    using System.Drawing;

    public class Ray : IGrapgic
    {
        private PointF a;

        private PointF b;


        public Ray(PointF a, PointF b, Color color)
        {
            this.a = a;
            this.b = b;
            Color = color;
        }

        public Color Color { get; set; }

        public PointF? Function(double i)
        {
            var y = (float) ((a.Y - b.Y) * -i - (a.X * b.Y - b.X * a.Y)) / (b.X - a.X);

            if (b.X < a.X)
            {
                if (i > a.X)
                {
                    return null;
                }
            }
            else
            {
                if (i < a.X)
                {
                    return null;
                }
            }

            return new PointF((float)i, y);
        }
    }
}