using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordInteractionLab8.Models;

namespace WordInteractionLab8
{
    using WordInteractionLab8.Forms;

    public partial class EditOrganizetionForm : Form
    {
        public EditOrganizetionForm()
        {
            InitializeComponent();
        }

        private void AddBAccountButton_Click(object sender, EventArgs e)
        {
            var addBankAccountForm = new EditBankAccountForm();

            addBankAccountForm.Show();
        }
    }
}
