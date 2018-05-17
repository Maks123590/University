using Lab2.models;

namespace Lab2
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private readonly GridField gridField = new GridField();

        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(gridField);

            gridField.Width = this.Width;
            gridField.Height = (int)(this.Height * 0.6);

        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            var aBegin = new PointF(float.Parse(ax1TextBox.Text), float.Parse(ay1TextBox.Text));
            var aEnd = new PointF(float.Parse(ax2TextBox.Text), float.Parse(ay2TextBox.Text));

            var bBegin = new PointF(float.Parse(bx1TextBox.Text), float.Parse(by1TextBox.Text));
            var bEnd = new PointF(float.Parse(bx2TextBox.Text), float.Parse(by2TextBox.Text));

            gridField.RemoveAllGraphics();

            IGrapgic graphic1 = null;
            IGrapgic graphic2 = null;

            if (LinesRadioButton.Checked)
            {
                graphic1 = new Line(aBegin, aEnd, Color.Green);
                graphic2 = new Line(bBegin, bEnd, Color.Red);

                var intersectPoint = GetIntersectPoint(aBegin, aEnd, bBegin, bEnd);

                intersectLabel.Text = LinesIsIntersect(aBegin, aEnd, bBegin, bEnd) ? "Пересекаются. " + $"Точка пересечения ({intersectPoint.X}, {intersectPoint.Y})" : "Не пересекаются";
            }
            else if(RaysRadioButton.Checked)
            {
                graphic1 = new Ray(aBegin, aEnd, Color.Green);
                graphic2 = new Ray(bBegin, bEnd, Color.Red);

                if (RaysIsIntersect(aBegin, aEnd, bBegin, bEnd, out var rayOrSegment, out var intersectPoint))
                {
                    intersectLabel.Text = "Пересекаются ";

                    if (intersectPoint != null)
                    {
                        intersectLabel.Text += $"В точке ({intersectPoint.Value.X}, {intersectPoint.Value.Y})";
                    }
                    else
                    {
                        if (rayOrSegment.IsSegment)
                        {
                            intersectLabel.Text += $"Пересечение отрезок ({rayOrSegment.Begin.X}, {rayOrSegment.Begin.Y})({rayOrSegment.End.X}, {rayOrSegment.End.Y})";
                        }
                    }
                }
                else
                {
                    intersectLabel.Text = "Не пересекаются";
                }
                
            }
            else if (SegmentRadioButton.Checked)
            {
                graphic1 = new Segment(aBegin, aEnd, Color.Green);
                graphic2 = new Segment(bBegin, bEnd, Color.Red);

                var intersectPoint = GetIntersectPoint(aBegin, aEnd, bBegin, bEnd);

                intersectLabel.Text = SegmentsIsIntersect(aBegin, aEnd, bBegin, bEnd) ? "Пересекаются. " + $"Точка пересечения ({intersectPoint.X}, {intersectPoint.Y})" : "Не пересекаются";
            }


            if (graphic1 != null && graphic2 != null)
            {
                gridField.AddGraphic(graphic1);
                gridField.AddGraphic(graphic2);
            }
        }

        private bool SegmentsIsIntersect(PointF aBeg, PointF aEnd, PointF bBeg, PointF bEnd)
        {
            var v1 = ((bEnd.X - bBeg.X) * (aBeg.Y - bBeg.Y)) - ((bEnd.Y - bBeg.Y) * (aBeg.X - bBeg.X));
            var v2 = ((bEnd.X - bBeg.X) * (aEnd.Y - bBeg.Y)) - ((bEnd.Y - bBeg.Y) * (aEnd.X - bBeg.X));
            var v3 = ((aEnd.X - aBeg.X) * (bBeg.Y - aBeg.Y)) - ((aEnd.Y - aBeg.Y) * (bBeg.X - aBeg.X));
            var v4 = ((aEnd.X - aBeg.X) * (bEnd.Y - aBeg.Y)) - ((aEnd.Y - aBeg.Y) * (bEnd.X - aBeg.X));

            return (v1 * v2 < 0) && (v3 * v4 < 0);
        }

        private bool LinesIsIntersect(PointF aBeg, PointF aEnd, PointF bBeg, PointF bEnd)
        {
            var a1 = aBeg.Y - aEnd.Y;
            var b1 = aEnd.X - aBeg.X;

            var a2 = bBeg.Y - bEnd.Y;
            var b2 = bEnd.X - bBeg.X;

            var test = Math.Abs(a1 * b2 - a2 * b1);

            return test != 0;

            // 𝑎1𝑏2 − 𝑎2𝑏1 = 0. то (колиниарны) параллельны
        }

        private PointF GetIntersectPoint(PointF aBeg, PointF aEnd, PointF bBeg, PointF bEnd)
        {
            var a1 = aBeg.Y - aEnd.Y;
            var b1 = aEnd.X - aBeg.X;
            var c1 = aBeg.X * aEnd.Y - aEnd.X * aBeg.Y;

            var a2 = bBeg.Y - bEnd.Y;
            var b2 = bEnd.X - bBeg.X;
            var c2 = bBeg.X * bEnd.Y - bEnd.X * bBeg.Y;

            var x = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
            var y = (c1 * a2 - c2 * a1) / (a1 * b2 - a2 * b1);

            return new PointF(x, y);

            //𝑥 = (𝑏1𝑐2 − 𝑏2𝑐1)/(𝑎1𝑏2 − 𝑎2𝑏1) 
            //𝑦 = (𝑐1𝑎2 − 𝑐2𝑎1)/(𝑎1𝑏2 − 𝑎2𝑏1)
        }

        private bool RaysIsIntersect(PointF aBeg, PointF aEnd, PointF bBeg, PointF bEnd, out RayOrSegment rayOrSegment, out PointF? intersectPoint)
        {
            if (ScalarMultiple(aBeg, aEnd, bBeg, bEnd) == 0) // на одной прямой
            {
                if (ScalarMultiple(aBeg, bBeg, aBeg, aEnd) != 0) //прямые различны
                {
                    rayOrSegment = null;

                    intersectPoint = null;

                    return false;
                }
                else
                {
                    if (ScalarMultiple(aBeg, aEnd, bBeg, bEnd) > 0) // смотрят в одну сторону
                    {
                        if (ScalarMultiple(aBeg, aEnd, aBeg, bBeg) > 0)
                        {
                            //пересечение луч P3P4

                            rayOrSegment = new RayOrSegment()
                            {
                                Begin = bBeg,
                                End = bEnd
                            };
                        }
                        else
                        {
                            //пересечение луч P1P2

                            rayOrSegment = new RayOrSegment()
                            {
                                Begin = aBeg,
                                End = aEnd
                            };
                        }

                        intersectPoint = null;

                        return true;
                    }
                    else //смотрят в разные
                    {
                        if ((ScalarMultiple(aBeg, aEnd, aBeg, bBeg) == 0) && aBeg.X == bBeg.X && aBeg.Y == bBeg.Y)
                        {
                            //пересечение точка P1=P3

                            intersectPoint = new PointF(aBeg.X, aBeg.Y);

                            rayOrSegment = null;

                            return true;
                        }

                        if (ScalarMultiple(aBeg, aEnd, aBeg, bBeg) >= 0)
                        {
                            //пересечение отрезок P1P3

                            rayOrSegment = new RayOrSegment()
                            {
                                Begin = aBeg,
                                End = bBeg,
                                IsSegment = true
                            };

                            intersectPoint = null;

                            return true;
                        }
                        else
                        {
                            rayOrSegment = null;

                            intersectPoint = null;

                            return false;
                        }
                    }
                }
            }
            else
            {
                rayOrSegment = null;

                intersectPoint = GetIntersectPoint(aBeg, aEnd, bBeg, bEnd);

                return ScalarMultiple(aBeg, aEnd, aBeg, intersectPoint.Value) >= 0 &&
                       ScalarMultiple(bBeg, bEnd, aBeg, intersectPoint.Value) >= 0;
            }


        }

        private double ScalarMultiple(PointF aBeg, PointF aEnd, PointF bBeg, PointF bEnd)
        {
            var a = new PointF(aEnd.X - aBeg.X, aEnd.Y - aBeg.Y);
            var b = new PointF(bEnd.X - bBeg.X, bEnd.Y - bBeg.Y);


            //[𝑎,𝑏] = 𝑎𝑥𝑏𝑦 − 𝑏𝑥𝑎𝑦 

            var test = a.X * b.Y - b.X * a.Y;

            return test;
        }

        private class RayOrSegment
        {
            public bool IsSegment { get; set; }

            public PointF Begin { get; set; }

            public PointF End { get; set; }
        }

        private double PseudoscalarProduct(PointF aBeg, PointF aEnd, PointF bBeg, PointF bEnd) =>
            (aEnd.X - aBeg.X) * (bEnd.Y - bBeg.Y) - (bEnd.X - bBeg.X) * (aEnd.Y - aBeg.Y);
    }
}
