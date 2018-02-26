using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    using System.Runtime.CompilerServices;

    using WindowsFormsControlLibrary;

    public partial class Form1 : Form
    {
        private MathGraphGrid graphField;

        public Form1()
        {
            InitializeComponent();

            this.graphField = new MathGraphGrid();
            this.Controls.Add(this.graphField);

            this.graphField.Top = 15;
            this.graphField.Left = 15;

            //this.graphField.Width = 628;
            //this.graphField.Height = 400;

            graphField.Size = new System.Drawing.Size(628, 400);
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            this.graphField.RemoveAllGrapgics();
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            //this.graphField.AddGraphic(new ParametricallyMathGraphic(this.GetGraphicPoints, new Pen(Color.Red, 2), 5, 6, -10, 10));
            //this.graphField.AddGraphic(new ParametricallyMathGraphic(this.Circle, new Pen(Color.Green, 1), 5, 6, -10, 10));
            //this.graphField.AddGraphic(new ParametricallyMathGraphic(this.var9Funct, new Pen(Color.BlueViolet, 2), 10, 5, -10, 10));

            var segment = new LineSegment(new PointF(1, 1), new PointF(10, 10), new Pen(Color.Green));

            this.graphField.AddGraphic(segment);

            //graphField.Size = new System.Drawing.Size(555, 400);
        }

        private PointF GetGraphicPoints(double a, double b, double fi)
        {
            var x = a * fi - b * Math.Sin(fi);

            var y = a - b * Math.Cos(fi);

            return new PointF((float)x, (float)y);

        }

        private PointF Circle(double a, double b, double fi)
        {
            var r = 10;

            var x = r * Math.Cos(fi);

            var y = r * Math.Sin(fi);

            return new PointF((float)x, (float)y);
        }

        private PointF var9Funct(double a, double b, double fi)
        {
            var x = (a * a - b * b) * Math.Pow(Math.Cos(fi), 3);

            var y = (a * a - b * b) * Math.Pow(Math.Sin(fi), 3);

            return new PointF((float)(x / a), (float)(y / b));
        }
    }
}
