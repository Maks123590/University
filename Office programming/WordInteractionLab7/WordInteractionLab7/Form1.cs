using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

//using Word= 

namespace WordInteractionLab7
{
    public partial class Form1 : Form
    {
        private Word.Application wordApp;

        private List<District> Districts;

        private readonly int YStartPos;
        private readonly int YEndPos;
        private readonly int XStartPos;
        private readonly int XEndPos;

        private int xMin;
        private int xMax;
        private int YMin;
        private int YMax;

        public Form1()
        {
            InitializeComponent();

            YStartPos = 5;
            YEndPos = pictureBox.Width - 5;
            XStartPos = 5;
            XEndPos = pictureBox.Height - 5;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDistrictInfo(comboBox1.SelectedIndex);
        }

        private void GetDistricts()
        {
            var serializer = new JavaScriptSerializer();

            if (Districts != null)
            {
                return;
            }

            var districtsData = File.ReadAllText(@"Districts.json");

            Districts = serializer.Deserialize<District[]>(districtsData).ToList();


        }

        private void ShowDistrictInfo(int districtNumber)
        {
            if (Districts == null)
            {
                GetDistricts();
            }

            var district = Districts[districtNumber];

            districtNameLabel.Text = district.Name;

            var sb = new StringBuilder();

            sb.AppendLine("Административный центр: " + district.Center.Name);
            sb.AppendLine("Территория: " + district.Area + " кв. км");
            sb.AppendLine("Население: " + district.Population + " чел.");

            districtInfoTextBox.Text = sb.ToString();

            pictureBox.Image = GetDistrictMapImage(district);
        }

        private Image GetDistrictMapImage(District district)
        {
            xMin = district.minPoint.x;
            xMax = district.maxPoint.x;
            YMin = district.minPoint.y;
            YMax = district.maxPoint.y;

            var image = new Bitmap(pictureBox.Width, pictureBox.Height);

            var graphics = Graphics.FromImage(image);

            graphics.FillRectangle(Brushes.DarkSlateGray, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);

            graphics.FillRectangle(Brushes.MintCream, 1, 1, pictureBox.Width - 3, pictureBox.Height - 3);

            var contour = district.Contour;

            var points = new List<PointF>();

            foreach (var point in contour)
            {
                point.x = x_screen(point.x);
                point.y = y_screen(point.y);

                points.Add(point);
            }

            graphics.FillPolygon(Brushes.CornflowerBlue, points.ToArray());

            var centerEllipseSize = 10;

            graphics.FillEllipse(Brushes.OrangeRed, x_screen(district.Center.Coord.x - centerEllipseSize/2), y_screen(district.Center.Coord.y - centerEllipseSize / 2), centerEllipseSize, centerEllipseSize);

            graphics.DrawString(district.Center.Name, new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular), Brushes.Black, x_screen(district.Center.Coord.x - 5), y_screen(district.Center.Coord.y + 5));

            return image;
        }

        private int x_screen(int x)
        {
            return YStartPos + (int)Math.Round(((double)x - xMin) * (YEndPos - YStartPos) / (xMax - xMin));
        }

        private int y_screen(int y)
        {
            return XStartPos + (int) Math.Round(((double) y - YMin) * (XEndPos - XStartPos) / (YMax - YMin));
        }

        private void intoDocButton_Click(object sender, EventArgs e)
        {
            if (wordApp == null)
            {
                wordApp = new Word.Application();
            }

            if (Districts == null)
            {
                GetDistricts();
            }

            var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;

            var path = Path.GetDirectoryName(assemblyLocation);


            var document = wordApp.Documents.Add(path + "\\Template.docx");

            wordApp.Visible = true;

            var table = document.Tables[1];

            var oldClipboardContent = Clipboard.GetDataObject();

            for (int i = 0; i < Districts.Count; i++)
            {
                var district = Districts[i];

                
                table.Rows.Add();

                table.Cell(i + 2, 1).Range.Text = district.Name;
                table.Cell(i + 2, 2).Range.Text = $"Административный центр - {district.Center.Name}\nТерритория - {district.Area} кв.км\nНаселение - {district.Population} чел.";

                
                var image = GetDistrictMapImage(district);

                Clipboard.SetImage(image);

                table.Cell(i + 2, 3).Range.Paste();                
            }

            if (oldClipboardContent != null)
            {
                Clipboard.SetDataObject(oldClipboardContent);
            }
            else
            {
                Clipboard.Clear();
            }
        }
    }
}
