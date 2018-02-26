namespace WindowsFormsControlLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MathGraphGrid : PictureBox
    {
        public MathGraphGrid()
        {
            this.InitializeComponent();

            this.Image = new Bitmap(this.Width, this.Height);

            this.DrawGrid(this.Image, this.CellSize);
        }

        private List<IDrawableObject> functions = new List<IDrawableObject>();

        private const int CellSizeMaxLimit = 200;

        private const int CellSizeMinLimit = 5;

        private int cellSize = 20;

        private bool movable = false;
        private int mouseX = Cursor.Position.X;
        private int mouseY = Cursor.Position.Y;

        public int mouseXOffset = 0;

        public int mouseYOffset = 0;

        private int CellSize
        {
            get => this.cellSize;

            set
            {
                var temp = value;

                if (temp > CellSizeMaxLimit || temp < CellSizeMinLimit)
                {
                    return;
                }

                this.cellSize = temp;
                this.DrawGrid(this.Image, this.cellSize, this.mouseXOffset, this.mouseYOffset);

                if (this.functions.Count > 0)
                {
                    foreach (var graph in this.functions)
                    {
                        graph.DrawGraphic(this.Image, this.GetCenterPoint(this.Image, this.mouseXOffset, this.mouseYOffset), this.cellSize);
                    }
                }

                this.Invalidate();
            }
        }

        public void AddGraphic(IDrawableObject graph)
        {
            this.functions.Add(graph);

            graph.DrawGraphic(this.Image, this.GetCenterPoint(this.Image, this.mouseXOffset, this.mouseYOffset), this.cellSize);

            this.Invalidate();
        }

        public void RemoveAllGrapgics()
        {
            this.functions.Clear();

            this.DrawGrid(this.Image, this.cellSize, this.mouseXOffset, this.mouseYOffset);

            this.Invalidate();
        }

        private void DrawGrid(Image image, int cellSize, int offsetX = 0, int offsetY = 0)
        {

            const int OsPenSize = 2;
            var osColor = Color.CornflowerBlue;

            const int CellPenSize = 1;
            var cellColor = Color.Aqua;

            var graphics = Graphics.FromImage(image);

            graphics.FillRectangle(Brushes.Azure, 0, 0, image.Width, image.Height);

            var centerPoint = this.GetCenterPoint(image, offsetX, offsetY);

            this.DrawOs(image, centerPoint, osColor, OsPenSize);

            this.DrawCells(image, centerPoint, offsetX, offsetY, cellColor, CellPenSize, cellSize);

            this.DrawMarkup(image, centerPoint, Brushes.Black, cellSize);
        }

        private void DrawOs(Image image, Point centerPoint, Color osColor, int osPenSize)
        {
            var graphics = Graphics.FromImage(image);

            // Y os
            graphics.DrawLine(new Pen(osColor, osPenSize), centerPoint.X, 0, centerPoint.X, image.Height);

            // X os
            graphics.DrawLine(new Pen(osColor, osPenSize), 0, centerPoint.Y, image.Width, centerPoint.Y);
        }

        private void DrawCells(Image image, Point centerPoint, int offsetX, int offsetY, Color cellColor, int cellPenSize, int cellSize)
        {
            var graphics = Graphics.FromImage(image);

            for (var i = 0; i <= image.Width + offsetX; i += this.cellSize)
            {
                graphics.DrawLine(new Pen(cellColor, cellPenSize), centerPoint.X - i, 0, centerPoint.X - i, image.Height);
            }

            for (var i = 0; i <= image.Width - offsetX; i += this.cellSize)
            {
                graphics.DrawLine(new Pen(cellColor, cellPenSize), centerPoint.X + i, 0, centerPoint.X + i, image.Height);
            }

            for (var i = 0; i <= image.Height + offsetY; i += this.cellSize)
            {
                graphics.DrawLine(new Pen(cellColor, cellPenSize), 0, centerPoint.Y - i, image.Width, centerPoint.Y - i);
            }

            for (var i = 0; i <= image.Height - offsetY; i += this.cellSize)
            {
                graphics.DrawLine(new Pen(cellColor, cellPenSize), 0, centerPoint.Y + i, image.Width, centerPoint.Y + i);
            }
        }

        private void DrawMarkup(Image image, Point centerPoint, Brush digitBrush, int cellSize)
        {
            const int digitOffset = 2;

            const int tempConst = 60;

            var digitSize = cellSize / 10 < 4 ? 4 : cellSize / 10;

            var step = tempConst / cellSize > 1 ? tempConst / cellSize : 1;

            var graphics = Graphics.FromImage(image);

            var count = 0;

            // ->
            for (var i = centerPoint.X; i <= image.Width; i += cellSize)
            {
                if (count % step == 0)
                {
                    graphics.DrawString(count.ToString(), new Font(FontFamily.GenericSerif, digitSize, FontStyle.Regular), digitBrush, i, centerPoint.Y + digitOffset);
                }

                count += 1;
            }

            count = -1;

            // <-
            for (var i = centerPoint.X - cellSize; i >= 0; i -= cellSize)
            {
                if (count % step == 0)
                {
                    graphics.DrawString(count.ToString(), new Font(FontFamily.GenericSerif, digitSize, FontStyle.Regular), digitBrush, i, centerPoint.Y + digitOffset);
                }

                count -= 1;
            }

            count = -1;

            // ->
            for (var i = centerPoint.Y + cellSize; i <= image.Height; i += cellSize)
            {
                if (count % step == 0)
                {

                    graphics.DrawString(count.ToString(), new Font(FontFamily.GenericSerif, digitSize, FontStyle.Regular), digitBrush, centerPoint.X + digitOffset, i);

                }

                count -= 1;
            }

            count = 1;

            // <-
            for (var i = centerPoint.Y - cellSize; i >= 0; i -= this.cellSize)
            {
                if (count % step == 0)
                {
                    graphics.DrawString(count.ToString(), new Font(FontFamily.GenericSerif, digitSize, FontStyle.Regular), digitBrush, centerPoint.X + digitOffset, i);
                }

                count += 1;
            }
        }

        //private void DrawGraphic(Image image, PointF centerPoint, int cellSize, ParametricallyMathGraphic graphic)
        //{
        //    var graphics = Graphics.FromImage(image);

        //    var points = new List<PointF>();

        //    const double Step = 0.01;

        //    for (var i = graphic.FiBegin; i <= graphic.FiEnd; i += Step)
        //    {
        //        var point = graphic.Funct(graphic.a, graphic.b, i);

        //        point = CoordinateConverter.DecartToScreen(point, centerPoint, cellSize);

        //        points.Add(point);
        //    }

        //    graphics.DrawLines(graphic.Pen, points.ToArray());
        //}


        private Point GetCenterPoint(Image image, int offsetX, int offsetY)
        {
            var centerPoint = new Point((image.Width / 2) + offsetX, (image.Height / 2) + offsetY);

            return centerPoint;
        }


        private void ThisClick(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void ThisMouseDown(object sender, MouseEventArgs e)
        {
            this.movable = true;
            this.mouseX = Cursor.Position.X;
            this.mouseY = Cursor.Position.Y;
        }

        private void ThisMouseMove(object sender, MouseEventArgs e)
        {
            if (this.movable)
            {
                this.mouseXOffset += Cursor.Position.X - this.mouseX;
                this.mouseYOffset += Cursor.Position.Y - this.mouseY;

                this.DrawGrid(this.Image, this.CellSize, this.mouseXOffset, this.mouseYOffset);

                if (this.functions.Count > 0)
                {
                    foreach (var graph in this.functions)
                    {
                        graph.DrawGraphic(this.Image, this.GetCenterPoint(this.Image, this.mouseXOffset, this.mouseYOffset), this.cellSize);
                    }
                }

                this.Invalidate();

                this.mouseX = Cursor.Position.X;
                this.mouseY = Cursor.Position.Y;

            }
        }

        private void ThisMouseUp(object sender, MouseEventArgs e)
        {
            this.movable = false;
        }

        private void ThisMouseWhell(object sender, MouseEventArgs e)
        {
            this.CellSize += e.Delta / 20;
        }

        private void OnSizeChanged(object sender, EventArgs eventArgs)
        {
            this.mouseXOffset = 0;
            this.mouseYOffset = 0;

            this.DrawGrid(this.Image, this.CellSize);

            //var g = Graphics.FromImage(this.Image);

            //g.DrawLine(new Pen(Color.Red, 4), new PointF(5, 5), new PointF(15, 15));

            if (this.functions.Count > 0)
            {
                foreach (var graph in this.functions)
                {
                    graph.DrawGraphic(this.Image, this.GetCenterPoint(this.Image, this.mouseXOffset, this.mouseYOffset), this.cellSize);
                }
            }

            this.Invalidate();
        }
    }
}
