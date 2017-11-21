using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

    
namespace WordInterLab2
{
    public partial class Form1 : Form
    {
        private Word.Application Application { get; set; }

        private Word.Document Template { get; set; }

        public Form1()
        {
            InitializeComponent();
            insertBtn.Enabled = false;
            replaceBtn.Enabled = false;
        }

        private void runWordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Application = new Word.Application
                {
                    Visible = false
                };

                insertBtn.Enabled = true;
                replaceBtn.Enabled = true;
                findTextBox.Text = "###";
                runWordBtn.Enabled = false;

                docCountLabel.Text = Application.Documents.Count.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            var names = FIOTextBox.Lines;

            var docCounter = 0;

            foreach (var name in names)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    continue;
                }

                Application.Documents.Add(Template: @"C:\Users\Макс Батунин\documents\visual studio 2017\Projects\WordInterLab2\WordInterLab2\template.doc");

                Application.Selection.Move(Word.WdUnits.wdCharacter, 14);

                Application.Selection.TypeText(name);

                docCounter++;
            }

            docCountLabel.Text = Application.Documents.Count.ToString();

            MessageBox.Show(docCounter + " documents added.");
        }

        private void saveDocsBtn_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var counter = 0;

                foreach (Word.Document document in Application.Documents)
                {
                    document.SaveAs(folderBrowserDialog.SelectedPath + "/document" + counter + ".doc");
                    document.Close();
                    counter++;
                }

                docCountLabel.Text = Application.Documents.Count.ToString();

                MessageBox.Show("Saved.");
            }
        }

        private void wordVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        { 
             Application.Visible = wordVisibleCheckBox.Checked;
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            var names = replaceTextBox.Lines;

            var docCounter = 0;

            foreach (var name in names)
            {
                var document = Application.Documents.Add(Template: @"C:\Users\Макс Батунин\documents\visual studio 2017\Projects\WordInterLab2\WordInterLab2\template2.doc");

                var range = document.Range(0, document.Characters.Count);

                Word.Find find = range.Find;

                find.Text = findTextBox.Text;
                find.Replacement.Text = name;
                find.Execute(Replace: Word.WdReplace.wdReplaceAll);

                find.Text = "Date";
                find.Replacement.Text = DateTime.Today.ToString("dd.MM.yyyy");
                find.Execute(Replace: Word.WdReplace.wdReplaceAll);

                docCounter++;


            }

            docCountLabel.Text = Application.Documents.Count.ToString();

            MessageBox.Show(docCounter + " documents added.");
        }

        
    }
}
