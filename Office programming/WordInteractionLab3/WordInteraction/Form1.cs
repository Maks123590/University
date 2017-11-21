using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;

namespace WordInteraction
{
    public partial class Form1 : Form
    {
        private Word.Application wordApplication;

        public Form1()
        {
            InitializeComponent();

            wordVisibleCheckBox.Enabled = false;
            wordStateLabel.Text = "Word off";
            wordWorkPanel.Visible = false;
            closeWordBtn.Enabled = false;
        }

        private void runWordBtn_Click(object sender, EventArgs e)
        {
            if (wordApplication == null)
            {
                wordApplication = new Word.Application {Visible = true};
            }

            wordStateLabel.Text = "Word on";

            wordVisibleCheckBox.Enabled = true;
            wordVisibleCheckBox.Checked = true;

            wordWorkPanel.Visible = true;
            closeWordBtn.Enabled = true;
        }

        private void wordVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wordApplication != null)
            {
                wordApplication.Visible = wordVisibleCheckBox.Checked;
            }
        }

        private void createDocBtn_Click(object sender, EventArgs e)
        {
            var document = wordApplication.Documents.Add();

            openedDocslistBox.Items.Add(document.FullName);
        }

        private void closeWordBtn_Click(object sender, EventArgs e)
        {
            wordApplication?.Quit();

            wordStateLabel.Text = "Word off";

            wordVisibleCheckBox.Enabled = false;
            wordVisibleCheckBox.Checked = false;

            wordWorkPanel.Visible = false;

            closeWordBtn.Enabled = false;
        }

        private void EditDocBtn_Click(object sender, EventArgs e)
        {
            var document = wordApplication.Documents[openedDocslistBox.SelectedIndex];

            document.Content.Text = textBox1.Text;
        }

        private void DeleteDocBtn_Click(object sender, EventArgs e)
        {
            wordApplication.Documents[1].Select();

            MessageBox.Show("Selected" + wordApplication.ActiveDocument.FullName);
        }
    }
}
