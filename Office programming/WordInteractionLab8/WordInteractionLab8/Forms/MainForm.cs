namespace WordInteractionLab8.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using WordInteractionLab8.Components;
    using WordInteractionLab8.Models;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void IntoDocumentButtonClick(object sender, EventArgs e)
        {

        }

        private void addPaymentButton_Click(object sender, EventArgs e)
        {
            var addPaymentForm = new EditPaymentForm();

            addPaymentForm.Show();
        }

        private void addOrganizationButton_Click(object sender, EventArgs e)
        {
            var addOrganizationForm = new EditOrganizetionForm();
            addOrganizationForm.Show();
        }

        private void editPaymentButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
