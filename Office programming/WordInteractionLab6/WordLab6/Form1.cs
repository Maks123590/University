using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Word = Microsoft.Office.Interop.Word;


namespace WordLab6
{
    public partial class Form1 : Form
    {
        private Word.Application wordApp;

        private ItemsDbContext db = new ItemsDbContext();

        private int currentItemId;

        private int CurrentItemId
        {
            get => currentItemId;

            set
            {
                currentItemId = value;
                ShowItem(db.Items.Find(currentItemId));
            }
        }


        public Form1()
        {
            InitializeComponent();

            if (db.Items.Any())
            {
                CurrentItemId++;
            }
        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;

            var dataItem = new DataItem
            {
                Name = "Name" + (CurrentItemId + 1),
                Description = "Description" + (CurrentItemId + 1)
            };

            db.Items.Add(dataItem);

            db.SaveChanges();

            CurrentItemId = db.Items.Count();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (CurrentItemId < db.Items.Count() - 1)
            {
                tempSaveItem(db.Items.Find(CurrentItemId));

                CurrentItemId++;
            }
        }


        private void ShowItem(DataItem item)
        {
            try
            {
                using (var memoryStream = new MemoryStream(item.ImageBytes, 0, item.ImageBytes.Length))
                {
                    memoryStream.Write(item.ImageBytes, 0, item.ImageBytes.Length);

                    pictureBox.Image = Image.FromStream(memoryStream);

                }
            }
            catch (Exception)
            {
                pictureBox.Image = null;
            }


            nameTextBox.Text = item.Name;

            descriptTextBox.Text = item.Description;

        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (CurrentItemId > 1)
            {
                //tempSaveItem(db.Items.Find(CurrentItemId));

                CurrentItemId--;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            tempSaveItem(db.Items.Find(CurrentItemId));

            db.SaveChanges();

            MessageBox.Show("Success!");
        }

        private void imgFromFileButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(fileDialog.FileName);
            }           
        }

        private void tempSaveItem(DataItem item)
        {
            using (var memoryStream = new MemoryStream())
            {
                pictureBox.Image?.Save(memoryStream, ImageFormat.Png);

                item.Name = nameTextBox.Text;
                item.Description = descriptTextBox.Text;
                item.ImageBytes = memoryStream.ToArray();
            }
        }

        private void ImFromBuffer_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                pictureBox.Image = Clipboard.GetImage();
            }
            else
            {
                MessageBox.Show("Picture in Clipboard is not found");
            }
        }

        private void InDocButton_Click(object sender, EventArgs e)
        {
            if (wordApp == null)
            {
                wordApp = new Word.Application();
            }

            var assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;

            var path = Path.GetDirectoryName(assemblyLocation);


            var document = wordApp.Documents.Add(path + "\\Шаблон1.dot");

            wordApp.Visible = true;

            var table = document.Tables[1];

            var oldClipboardContent = Clipboard.GetDataObject();

            for (int i = 1; i <= db.Items.Count(); i++)
            {
                var item = db.Items.Find(i);

                var test = db.Items.Count();

                if (item != null)
                {
                    table.Rows.Add();

                    table.Cell(i + 1, 1).Range.Text = item.Name;
                    table.Cell(i + 1, 2).Range.Text = item.Description;

                    if ((item.ImageBytes != null) && (item.ImageBytes.Length > 0))
                    {
                        var image = ByteArrayToImage(item.ImageBytes);

                        Clipboard.SetImage(image);

                        //table.Rows.Add();


                        table.Cell(i + 1, 3).Range.Paste();
                    }
                }
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

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
    }
}
