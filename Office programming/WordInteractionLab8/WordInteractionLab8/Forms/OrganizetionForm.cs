namespace WordInteractionLab8.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using WordInteractionLab8.Models;
    using WordInteractionLab8.Resources;

    using ApplicationContext = WordInteractionLab8.Models.ApplicationContext;

    public partial class OrganizationForm : Form
    {
        private readonly OrganizationInfo organizationInfo;

        private readonly Action<OrganizationInfo, int?> refreshInfo;

        public OrganizationForm(Action<OrganizationInfo, int?> refreshInfo)
        {
            this.InitializeComponent();

            this.refreshInfo = refreshInfo;

             this.organizationInfo = new OrganizationInfo();
        }

        public OrganizationForm(Action<OrganizationInfo, int?> refreshInfo, int selectedIndex, OrganizationInfo organizationInfo) : this(refreshInfo)
        {
            this.NameMaskedTextBox.Text = this.organizationInfo.Name;
            this.innMaskedTextBox.Text = this.organizationInfo.INN;
            this.kppMaskedTextBox.Text = this.organizationInfo.CPP;

            foreach (var bankAccount in this.organizationInfo.BankAccounts)
            {
                this.baknInfoListBox.Items.Add(bankAccount.CurrentAccount);
            }

            this.SelectedIndex = selectedIndex;
            this.organizationInfo = organizationInfo;
        }

        public int? SelectedIndex { get; }

        private void AddBAccountButtonClick(object sender, EventArgs e)
        {
            var addBankAccountForm = new BankAccountForm(this.AddBankAccount);

            addBankAccountForm.Show();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBAccountButtonClick(object sender, EventArgs e)
        {
            var bankAccount = this.organizationInfo.BankAccounts.FirstOrDefault(acc => acc.CurrentAccount == this.baknInfoListBox.SelectedItem.ToString());

            var addBankAccountForm = new BankAccountForm(this.AddBankAccount, this.baknInfoListBox.SelectedIndex, bankAccount);

            addBankAccountForm.Show();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            if(this.NameMaskedTextBox.Text != string.Empty && this.kppMaskedTextBox.Text != string.Empty && this.innMaskedTextBox.Text != string.Empty)
            { 

                this.organizationInfo.Name = this.NameMaskedTextBox.Text;
                this.organizationInfo.CPP = this.kppMaskedTextBox.Text;
                this.organizationInfo.INN = this.innMaskedTextBox.Text;

                this.refreshInfo(this.organizationInfo, this.SelectedIndex);

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    AppResource.InfoMessageBox_Внимание,
                    AppResource.InfoMessageBox_Все_значения_должны_быть_заполнены_,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void DeleteBAccountButtonClick(object sender, EventArgs e)
        {
            var bancAccount = this.organizationInfo.BankAccounts.FirstOrDefault(a => a.CurrentAccount == this.baknInfoListBox.SelectedItem.ToString());

            this.organizationInfo.BankAccounts.ToList().Remove(bancAccount);

            this.baknInfoListBox.Items.Remove(this.baknInfoListBox.SelectedItem);
        }

        private void AddBankAccount(BankAccount bankAccount, int? editingIndex = null)
        {
            this.RefreshListBox(bankAccount, editingIndex);

            this.AddBankAccountToOrganization(bankAccount);
        }

        private void RefreshListBox(BankAccount bankAccount, int? editingIndex = null)
        {
            if (editingIndex == null)
            {
                this.baknInfoListBox.Items.Add(bankAccount.CurrentAccount);
            }
            else
            {
                this.baknInfoListBox.Items[(int)editingIndex] = bankAccount.CurrentAccount;
            }
        }

        private void AddBankAccountToOrganization(BankAccount bankAccount)
        {
            if (this.organizationInfo.BankAccounts == null)
            {
                this.organizationInfo.BankAccounts = new[] { bankAccount };
            }
            else
            {
                var bankAccounts = this.organizationInfo.BankAccounts.ToList();

                bankAccounts.Add(bankAccount);

                this.organizationInfo.BankAccounts = bankAccounts.ToArray();
            }
        }
    }
}
