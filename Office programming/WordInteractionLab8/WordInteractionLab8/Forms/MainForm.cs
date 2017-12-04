namespace WordInteractionLab8.Forms
{
    using System;
    using System.Windows.Forms;

    using WordInteractionLab8.Components;
    using WordInteractionLab8.Models;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();

            
        }

        private void AddOrganizationButton_Click(object sender, EventArgs e)
        {
            var addOrganizetionFormForm = new EditOrganizetionForm();

            addOrganizetionFormForm.Show();
        }

        private void IntoDocumentButtonClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
