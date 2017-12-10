namespace WordInteractionLab8.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using WordInteractionLab8.Models;
    using WordInteractionLab8.Resources;

    public partial class OrganizationForm : Form
    {
        private readonly OrganizationInfo organizationInfo;

        private readonly List<BankAccount> bankAccounts;

        public OrganizationForm()
        {
            this.InitializeComponent();

             this.organizationInfo = new OrganizationInfo();

            this.bankAccounts = new List<BankAccount>();
        }

        public OrganizationForm(IEnumerable<BankAccount> bankAccounts, int selectedIndex, OrganizationInfo organizationInfo) : this()
        {
            this.SelectedIndex = selectedIndex;
            this.organizationInfo = organizationInfo;
            this.bankAccounts = bankAccounts.ToList();

            this.NameMaskedTextBox.Text = this.organizationInfo.Name;
            this.innMaskedTextBox.Text = this.organizationInfo.INN;
            this.kppMaskedTextBox.Text = this.organizationInfo.CPP;

            if (this.bankAccounts != null)
            {
                foreach (var bankAccount in this.bankAccounts)
                {
                    this.baknInfoListBox.Items.Add(bankAccount.CurrentAccount);
                }
            }
        }

        public event EventHandler<OrganizationInfoEventsArgs> OrganizationFinded;

        public int? SelectedIndex { get; }

        protected virtual void OnOrganizationFinded(OrganizationInfoEventsArgs e)
        {
            EventHandler<OrganizationInfoEventsArgs> handler = this.OrganizationFinded;

            handler?.Invoke(this, e);
        }

        private void AddBAccountButtonClick(object sender, EventArgs e)
        {
            var addBankAccountForm = new BankAccountForm(this.organizationInfo);

            addBankAccountForm.BankAccountFinded += this.AddBankAccount;

            addBankAccountForm.Show();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBAccountButtonClick(object sender, EventArgs e)
        {
            var bankAccount = this.bankAccounts.FirstOrDefault(acc => acc.CurrentAccount == this.baknInfoListBox.SelectedItem.ToString());

            var addBankAccountForm = new BankAccountForm(this.organizationInfo, this.baknInfoListBox.SelectedIndex, bankAccount);

            addBankAccountForm.BankAccountFinded += this.AddBankAccount;

            addBankAccountForm.Show();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            if(this.NameMaskedTextBox.Text != string.Empty && this.kppMaskedTextBox.Text != string.Empty && this.innMaskedTextBox.Text != string.Empty)
            { 
                this.organizationInfo.Name = this.NameMaskedTextBox.Text;
                this.organizationInfo.CPP = this.kppMaskedTextBox.Text;
                this.organizationInfo.INN = this.innMaskedTextBox.Text;

                this.OnOrganizationFinded(new OrganizationInfoEventsArgs
                                             {
                                                 OrganizationInfo = this.organizationInfo,
                                                 BankAccounts = this.bankAccounts.ToArray(),
                                                 SelectedIndex = this.SelectedIndex
                                             });

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
            var bancAccount = this.bankAccounts.FirstOrDefault(a => a.CurrentAccount == this.baknInfoListBox.SelectedItem.ToString());

            this.bankAccounts.Remove(bancAccount);

            this.baknInfoListBox.Items.Remove(this.baknInfoListBox.SelectedItem);
        }

        private void AddBankAccount(object sender, BankInfoEventsArgs bankInfoEventsArgs)
        {
            this.RefreshListBox(bankInfoEventsArgs.BankAccount, bankInfoEventsArgs.SelectedIndex);

            this.AddBankAccountToOrganization(bankInfoEventsArgs.BankAccount);
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
            this.bankAccounts.Add(bankAccount);
        }
    }

    public class OrganizationInfoEventsArgs : EventArgs
    {
        public OrganizationInfo OrganizationInfo { get; set; }

        public BankAccount[] BankAccounts { get; set; }

        public int? SelectedIndex { get; set; }
    }
}
