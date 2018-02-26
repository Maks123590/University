namespace WindowsFormsControlLibrary
{
    using System.Drawing;

    public interface IDrawableObject
    {
        void DrawGraphic(Image image, PointF centerPoint, int cellSize);
    }
}