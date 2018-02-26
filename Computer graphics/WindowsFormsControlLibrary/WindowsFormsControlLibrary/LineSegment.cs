namespace WindowsFormsControlLibrary
{
    using System.Drawing;

    public class LineSegment : IDrawableObject
    {
        public readonly PointF Begin;

        public readonly PointF End;

        public LineSegment(PointF begin, PointF end, Pen pen)
        {
            this.Begin = begin;
            this.End = end;
            this.Pen = pen;
        }

        public Pen Pen { get; }

        public void DrawGraphic(Image image, PointF centerPoint, int cellSize)
        {
            var screenBegin = CoordinateConverter.DecartToScreen(this.Begin, centerPoint, cellSize);
            var screenEnd = CoordinateConverter.DecartToScreen(this.End, centerPoint, cellSize);

            var graphics = Graphics.FromImage(image);

            graphics.DrawLine(this.Pen, screenBegin, screenEnd);
        }
    }
}