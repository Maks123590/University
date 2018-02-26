namespace WindowsFormsControlLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class ParametricallyMathGraphic : IDrawableObject
    {
        public readonly Func<double, double, double, PointF> Funct;

        public double a { get; set; }

        public double b { get; set; }

        public double FiBegin { get; set; }

        public double FiEnd { get; set; }

        public Pen Pen { get; }

        public ParametricallyMathGraphic(Func<double, double, double, PointF> funct, Pen pen, double a, double b, double fiBegin, double fiEnd)
        {
            this.Funct = funct;
            this.Pen = pen;

            this.a = a;
            this.b = b;

            this.FiBegin = fiBegin;
            this.FiEnd = fiEnd;
        }

        public void DrawGraphic(Image image, PointF centerPoint, int cellSize)
        {
            var graphics = Graphics.FromImage(image);

            var points = new List<PointF>();

            const double Step = 0.01;

            for (var i = this.FiBegin; i <= this.FiEnd; i += Step)
            {
                var point = this.Funct(this.a, this.b, i);

                point = CoordinateConverter.DecartToScreen(point, centerPoint, cellSize);

                points.Add(point);
            }

            graphics.DrawLines(this.Pen, points.ToArray());
        }
    }
}