namespace Lab2
{
    using System.Drawing;

    public interface IGrapgic
    {
        Color Color { get; set; }

        PointF? Function(double i);
    }
}