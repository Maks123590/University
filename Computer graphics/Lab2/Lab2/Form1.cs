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

            IGrapgic graphic1;
            IGrapgic graphic2;

            if (LinesRadioButton.Checked)
            {
                graphic1 = new Line(aBegin, aEnd, Color.Green);
                graphic2 = new Line(bBegin, bEnd, Color.Red);
            }
            else if(RaysRadioButton.Checked)
            {
                graphic1 = new Ray(aBegin, aEnd, Color.Green);
                graphic2 = new Ray(bBegin, bEnd, Color.Red);
            }

            if (graphic1 != null && graphic2 != null)
            {
                gridField.AddGraphic(graphic1);
                gridField.AddGraphic(graphic2);
            }   
        }

        private bool IsIntersect(Point aBeg, Point aEnd, Point bBeg, Point bEnd)
        {
            var v1 = ((bEnd.X - bBeg.X) * (aBeg.Y - bBeg.Y)) - ((bEnd.Y - bBeg.Y) * (aBeg.X - bBeg.X));
            var v2 = ((bEnd.X - bBeg.X) * (aEnd.Y - bBeg.Y)) - ((bEnd.Y - bBeg.Y) * (aEnd.X - bBeg.X));
            var v3 = ((aEnd.X - aBeg.X) * (bBeg.Y - aBeg.Y)) - ((aEnd.Y - aBeg.Y) * (bBeg.X - aBeg.X));
            var v4 = ((aEnd.X - aBeg.X) * (bEnd.Y - aBeg.Y)) - ((aEnd.Y - aBeg.Y) * (bEnd.X - aBeg.X));

            return (v1 * v2 < 0) && (v3 * v4 < 0);
        }
    }
}
