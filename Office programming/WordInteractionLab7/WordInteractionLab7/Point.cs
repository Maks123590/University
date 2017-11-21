namespace WordInteractionLab7
{
    public class Point
    {
        public int x { get; set; }

        public int y { get; set; }


        public static implicit operator System.Drawing.PointF(Point point)
        {
            return new System.Drawing.PointF
            {
                X = point.x,
                Y = point.y
            };
        }
    }
}