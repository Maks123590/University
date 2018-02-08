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

        private PointF targetPoint;

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

            if (this.pointRadioButton.Checked)
            {
                this.ClearMap();

                this.DrawTargetPoint(e.Location);

                this.targetPoint = e.Location;

                this.DrawPolygon();

                if (this.points.Count > 0)
                {
                    this.IsIntoPotygon(this.points, this.targetPoint);
                }
                
            }
            else
            {
                this.DrawPolygonPoint(e.Location);

                this.points.Add(e.Location);
            }

        }

        private void DrawTargetPoint(PointF location)
        {
            this.graphics.FillEllipse(Brushes.Green, location.X - 5, location.Y - 5, 10, 10);

            this.pictureBox.Invalidate();
        }

        private void DrawPolygonPoint(PointF location)
        {
            this.graphics.FillEllipse(Brushes.Red, location.X, location.Y, 6, 6);

            this.pictureBox.Invalidate();
        }

        private void DrawPolygonButtonClick(object sender, EventArgs e)
        {
            this.DrawPolygon();
        }

        private void DrawPolygon()
        {
            foreach (var point in this.points)
            {
                this.DrawPolygonPoint(point);
            }

            if (this.points.Count > 2)
            {
                this.graphics.DrawPolygon(new Pen(Color.BlueViolet, 2), this.points.ToArray());

                this.pictureBox.Invalidate();
            }
        }

        private void DrawRay(Tuple<PointF, PointF> rayPoints)
        {
            this.graphics.DrawLine(new Pen(Color.DarkBlue, 2), rayPoints.Item1, rayPoints.Item2);
        }

        private void IsIntoPotygon(IReadOnlyList<PointF> polygonPoints, PointF targetPoint)
        {
            var ray = this.GetRay(polygonPoints, targetPoint);

            this.DrawRay(ray);

            this.stateLabel.Text = this.RayTracing(polygonPoints, ray.Item1, ray.Item2, targetPoint) ? "Внутри" : "Снаружи";
        }

        private Tuple<PointF, PointF> GetRay(IReadOnlyList<PointF> points, PointF targetPoint)
        {
            //const float AdditionalRange = 30;

            //var minX = points.Min(p => p.X);

            //var maxX = points.Max(p => p.X);

            const float AdditionalRange = 0;

            var minX = 0;

            var maxX = this.pictureBox.Width;

            var y = targetPoint.Y;

            return new Tuple<PointF, PointF>(new PointF(minX - AdditionalRange, y), new PointF(maxX + AdditionalRange, y));

        }

        private bool RayTracing(IReadOnlyList<PointF> points, PointF rayBeg, PointF rayEnd, PointF targetPoint)
        {
            // RayTracing


            var intersectionsCountLeft = 0;
            var intersectionsCountRight = 0;

            for (var i = 1; i < points.Count; i++)
            {
                if (this.IsIntersect(points[i - 1], points[i], rayBeg, targetPoint))
                {
                    intersectionsCountLeft++;
                }

                if (this.IsIntersect(points[i - 1], points[i], targetPoint, rayEnd))
                {
                    intersectionsCountRight++;
                }
            }

            if (this.IsIntersect(points[points.Count - 1], points[0], rayBeg, targetPoint))
            {
                intersectionsCountLeft++;
            }

            if (this.IsIntersect(points[points.Count - 1], points[0], targetPoint, rayEnd))
            {
                intersectionsCountRight++;
            }

            return (intersectionsCountLeft % 2 != 0) && (intersectionsCountRight % 2 != 0);
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
