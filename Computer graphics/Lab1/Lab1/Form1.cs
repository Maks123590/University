namespace Lab1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void DrawFraphicButtonClick(object sender, EventArgs e)
        {
            var a = double.Parse(this.aTextBox.Text);
            var b = double.Parse(this.bTextBox.Text);

            this.gridField.a = a;
            this.gridField.b = b;

            this.gridField.fiBegin = double.Parse(this.xBeginTextBox.Text, CultureInfo.InvariantCulture);
            this.gridField.fiEnd = double.Parse(this.xEndTextBox.Text, CultureInfo.InvariantCulture);

            //this.gridField.Funct = this.Circle;

            this.gridField.Funct = GetGraphicPoints;
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
    }
}
