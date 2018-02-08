namespace Pract1
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {

        private readonly Graphics graphics;

        private readonly List<PointF> points;

        private readonly PointF targetPoint;

        private Point lastPoint;

        public Form1()
        {
            this.InitializeComponent();

            this.pictureBox.Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);

            this.graphics = Graphics.FromImage(this.pictureBox.Image);

            this.points = new List<PointF>();

            this.ClearMap();
        }

        private void ClearMap()
        {
            this.graphics.Clear(Color.White);

            this.pictureBox.Invalidate();
        }

        private void ClearPolygonClick(object sender, EventArgs e)
        {
            this.points.Clear();

            this.ClearMap();
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {

            this.graphics.FillEllipse(Brushes.Red, e.X, e.Y, 6, 6);

            this.points.Add(e.Location);

            this.pictureBox.Invalidate();
        }

        private void DrawPolygonButtonClick(object sender, EventArgs e)
        {
            if (this.points.Count > 2)
            {
                this.graphics.DrawPolygon(new Pen(Color.BlueViolet), this.points.ToArray());

                this.pictureBox.Invalidate();
            } 
        }

        private bool IsIntoPotygon(IReadOnlyList<PointF> points, PointF targetPoint)
        {
            var ray = this.GetRay(points, targetPoint);

            return this.RayTracing(points, ray.Item1, ray.Item2);
        }

        private Tuple<PointF, PointF> GetRay(IReadOnlyList<PointF> points, PointF targetPoint)
        {
            const float AdditionalRange = 10;


            var minX = points.Min(p => p.X);

            var maxX = points.Max(p => p.X);

            var y = targetPoint.Y;

            return new Tuple<PointF, PointF>(new PointF(minX - AdditionalRange, y), new PointF(maxX + AdditionalRange, y));

        }

        private bool RayTracing(IReadOnlyList<PointF> points, PointF rayBeg, PointF rayEnd)
        {
            // RayTracing
            var intersectionsCount = 0;

            for (var i = 1; i < points.Count; i++)
            {
                if (this.IsIntersect(points[i - 1], points[i], rayBeg, rayEnd))
                {
                    intersectionsCount++;
                }
            }

            return intersectionsCount % 2 == 0;
        }

        private bool IsIntersect(PointF aBeg, PointF aEnd, PointF bBeg, PointF bEnd)
        {
            var v1 = ((bEnd.X - bBeg.X) * (aBeg.Y - bBeg.Y)) - ((bEnd.Y - bBeg.Y) * (aBeg.X - bBeg.X));

            var v2 = ((bEnd.X - bBeg.X) * (aEnd.Y - bBeg.Y)) - ((bEnd.Y - bBeg.Y) * (aEnd.X - bBeg.X));

            var v3 = ((aEnd.X - aBeg.X) * (bBeg.Y - aBeg.Y)) - ((aEnd.Y - aBeg.Y) * (bBeg.X - aBeg.X));

            var v4 = ((aEnd.X - aBeg.X) * (bEnd.Y - aBeg.Y)) - ((aEnd.Y - aBeg.Y) * (bEnd.X - aBeg.X));

            return (v1 * v2 < 0) && (v3 * v4 < 0);
        }


        /*
         
        function Intersection(ax1,ay1,ax2,ay2,bx1,by1,bx2,by2:real):boolean;
        var v1,v2,v3,v4:real;
        begin
        v1:=(bx2-bx1)*(ay1-by1)-(by2-by1)*(ax1-bx1);
        v2:=(bx2-bx1)*(ay2-by1)-(by2-by1)*(ax2-bx1);
        v3:=(ax2-ax1)*(by1-ay1)-(ay2-ay1)*(bx1-ax1);
        v4:=(ax2-ax1)*(by2-ay1)-(ay2-ay1)*(bx2-ax1);
        Intersection:=(v1*v2<0) and (v3*v4<0);
        end;
         
         */
    }
}
