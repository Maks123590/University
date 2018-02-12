using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private const int CellSizeMaxLimit = 200;

        private const int CellSizeMinLimit = 5;

        private int cellSize = 20;

        public Form1()
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
                this.DrawGrid(this.pictureBox.Image, this.cellSize, this.mouse_x_offset, this.mouse_y_offset);
                this.pictureBox.Invalidate();
            }
        }

        private void DrawGrid(Image image, int cellSize, int offsetX = 0, int offsetY = 0)
        {
            const int OsPenSize = 2;
            var osColor = Color.CornflowerBlue;

            const int CellPenSize = 1;
            var cellColor = Color.Aqua;

            var centerPoint = new Point((image.Width / 2) + offsetX, (image.Height / 2) + offsetY);

            var graphics = Graphics.FromImage(image);

            graphics.FillRectangle(Brushes.Azure, 0, 0, image.Width, image.Height);

            // Y os
            graphics.DrawLine(new Pen(osColor, OsPenSize), centerPoint.X, 0, centerPoint.X, image.Height);

            // X os
            graphics.DrawLine(new Pen(osColor, OsPenSize), 0, centerPoint.Y, image.Width, centerPoint.Y);

            for (var i = 0; i <= image.Width + offsetX; i += cellSize)
            {
                //graphics.DrawLine(new Pen(cellColor, CellPenSize), centerPoint.X + i, 0, centerPoint.X + i, image.Height);
                graphics.DrawLine(new Pen(cellColor, CellPenSize), centerPoint.X - i, 0, centerPoint.X - i, image.Height);
            }

            for (var i = 0; i <= image.Width - offsetX; i += cellSize)
            {
                graphics.DrawLine(new Pen(cellColor, CellPenSize), centerPoint.X + i, 0, centerPoint.X + i, image.Height);
                //graphics.DrawLine(new Pen(cellColor, CellPenSize), centerPoint.X - i, 0, centerPoint.X - i, image.Height);
            }

            for (var i = 0; i <= image.Height + offsetY; i += cellSize)
            {
                //graphics.DrawLine(new Pen(cellColor, CellPenSize), 0, centerPoint.Y + i, image.Width, centerPoint.Y + i);
                graphics.DrawLine(new Pen(cellColor, CellPenSize), 0, centerPoint.Y - i, image.Width, centerPoint.Y - i);
            }

            for (var i = 0; i <= image.Height - offsetY; i += cellSize)
            {
                graphics.DrawLine(new Pen(cellColor, CellPenSize), 0, centerPoint.Y + i, image.Width, centerPoint.Y + i);
                //graphics.DrawLine(new Pen(cellColor, CellPenSize), 0, centerPoint.Y - i, image.Width, centerPoint.Y - i);
            }
        }

        private void PictureBoxMouseWhell(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                CellSize += e.Delta / 10;
            }
            else
            {
                CellSize += e.Delta / 10;
            }
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            this.pictureBox.Focus();
        }





        private bool movable = false;
        int mouse_x = Cursor.Position.X;
        int mouse_y = Cursor.Position.Y;

        private int mouse_x_offset = 0;

        private int mouse_y_offset = 0;


        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            movable = true;
            mouse_x = Cursor.Position.X;
            mouse_y = Cursor.Position.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (movable)
            {
                mouse_x_offset += Cursor.Position.X - mouse_x;
                mouse_y_offset += Cursor.Position.Y - mouse_y;

                this.DrawGrid(this.pictureBox.Image, this.CellSize, mouse_x_offset, mouse_y_offset);

                this.pictureBox.Invalidate();

                mouse_x = Cursor.Position.X;
                mouse_y = Cursor.Position.Y;

            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            movable = false;
        }
    }
}
