namespace WindowsFormsControlLibrary
{
    using System.Drawing;

    public static class CoordinateConverter
    {

        public static PointF DecartToScreen(PointF decPoint, PointF centerPoint, int cellSize)
        {
            var x = (int)(centerPoint.X + (decPoint.X * cellSize));

            var y = (int)(centerPoint.Y - (decPoint.Y * cellSize));

            return new PointF(x, y);

            // xэ := x0 + round(xд*dd);
            // yэ := y0 - round(yд* dd);
        }
    }
}