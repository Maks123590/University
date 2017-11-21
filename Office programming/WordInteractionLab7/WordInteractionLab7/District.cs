namespace WordInteractionLab7
{
    public class District
    {
        public string Name { get; set; }

        public DistrictCenter Center { get; set; }

        public Point[] Contour { get; set; }

        public Point maxPoint { get; set; }

        public Point minPoint { get; set; }

        public double Area { get; set; }

        public int Population { get; set; }
    }
}