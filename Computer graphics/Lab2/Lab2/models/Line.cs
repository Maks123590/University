using System.Drawing;

namespace Lab2.models
{
    public class Line : IGrapgic
    {
        private PointF a;

        private PointF b;


        public Line(PointF a, PointF b, Color color)
        {
            this.a = a;
            this.b = b;
            Color = color;
        }

        public Color Color { get; set; }

        public PointF? Function(double i)
        {
            return new PointF((float)i, (float)((a.Y - b.Y) * -i - (a.X * b.Y - b.X * a.Y)) / (b.X - a.X));
        }
    }
}