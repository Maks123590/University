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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Word.Application application;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void runWordBtn_Click(object sender, EventArgs e)
        {
            application = new Word.Application();

            application.Visible = true;
        }

        private void createDocumentButton_Click(object sender, EventArgs e)
        {
            try
            {
                application.Documents.Add();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }
                
            
            

        }
    }
}
