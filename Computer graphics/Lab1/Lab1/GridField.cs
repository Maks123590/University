﻿namespace Lab1
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class GridField : UserControl
    {
        private const int CellSizeMaxLimit = 200;

        private const int CellSizeMinLimit = 5;

        private int cellSize = 20;

        private bool movable = false;
        private int mouseX = Cursor.Position.X;
        private int mouseY = Cursor.Position.Y;

        private int mouseXOffset = 0;

        private int mouseYOffset = 0;

        private Func<double, double, double, PointF> funct;

        public double a;

        public double b;

        public double fiBegin;

        public double fiEnd;

        public Func<double, double, double, PointF> Funct
        {
            get => this.funct;
            set
            {
                this.funct = value;

                this.DrawGrid(this.pictureBox.Image, this.cellSize, this.mouseXOffset, this.mouseYOffset);

                if (this.funct != null)
                {
                    this.DrawGraphic(this.pictureBox.Image, this.GetCenterPoint(this.pictureBox.Image, this.mouseXOffset, this.mouseYOffset), Color.Red, this.CellSize, this.funct);
                }
                

                this.pictureBox.Invalidate();
            }
        }

        public GridField()
        {
            this.InitializeComponent();

            this.pictureBox.Image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);

            this.DrawGrid(this.pictureBox.Image, this.CellSize);
        }

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
                this.DrawGrid(this.pictureBox.Image, this.cellSize, this.mouseXOffset, this.mouseYOffset);

                if (this.funct != null)
                {
                    this.DrawGraphic(this.pictureBox.Image, this.GetCenterPoint(this.pictureBox.Image, this.mouseXOffset, this.mouseYOffset), Color.Red, this.CellSize, this.funct);
                }
                


                this.pictureBox.Invalidate();
            }
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

        private Point GetCenterPoint(Image image, int offsetX, int offsetY)
        {
            var centerPoint = new Point((image.Width / 2) + offsetX, (image.Height / 2) + offsetY);

            return centerPoint;
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

        private void DrawGraphic(Image image, PointF centerPoint, Color graphicColor, int cellSize, Func<double, double, double, PointF> func)
        {
            var graphics = Graphics.FromImage(image);

            var points = new List<PointF>();

            const double Step = 0.01;

            for (var i = this.fiBegin; i <= this.fiEnd; i += Step)
            {
                var point = func(this.a, this.b, i);

                point = this.DecartToScreen(point, centerPoint, cellSize);

                points.Add(point);
            }

            graphics.DrawLines(new Pen(graphicColor), points.ToArray());
        }

        private PointF DecartToScreen(PointF decPoint, PointF centerPoint, int cellSize)
        {
            var x = (int)(centerPoint.X + (decPoint.X * cellSize));

            var y = (int)(centerPoint.Y - (decPoint.Y * cellSize));

            return new PointF(x, y);

            //xэ := x0 + round(xд*dd);
            //yэ := y0 - round(yд* dd);
        }

        private void PictureBoxMouseWhell(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.CellSize += e.Delta / 20;
            }
            else
            {
                this.CellSize += e.Delta / 20;
            }
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            this.pictureBox.Focus();
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            this.movable = true;
            this.mouseX = Cursor.Position.X;
            this.mouseY = Cursor.Position.Y;
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (this.movable)
            {
                this.mouseXOffset += Cursor.Position.X - this.mouseX;
                this.mouseYOffset += Cursor.Position.Y - this.mouseY;

                this.DrawGrid(this.pictureBox.Image, this.CellSize, this.mouseXOffset, this.mouseYOffset);

                if (this.funct != null)
                {
                    this.DrawGraphic(this.pictureBox.Image, this.GetCenterPoint(this.pictureBox.Image, this.mouseXOffset, this.mouseYOffset), Color.Red, this.CellSize, this.funct);
                }

                this.pictureBox.Invalidate();

                this.mouseX = Cursor.Position.X;
                this.mouseY = Cursor.Position.Y;

            }
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            this.movable = false;
        }
    }
}
