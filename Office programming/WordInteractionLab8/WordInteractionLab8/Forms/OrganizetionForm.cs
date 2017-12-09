namespace WordInteractionLab8.Forms
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Runtime.Remoting.Channels;
    using System.Windows.Forms;

    using WordInteractionLab8.Models;
    using WordInteractionLab8.Resources;

    using ApplicationContext = WordInteractionLab8.Models.ApplicationContext;

    public partial class OrganizationForm : Form
    {
        private readonly OrganizationInfo organizationInfo;

        public OrganizationForm()
        {
            this.InitializeComponent();

             this.organizationInfo = new OrganizationInfo();
        }

        public OrganizationForm(int selectedIndex, OrganizationInfo organizationInfo) : this()
        {
            this.SelectedIndex = selectedIndex;
            this.organizationInfo = organizationInfo;

            this.NameMaskedTextBox.Text = this.organizationInfo.Name;
            this.innMaskedTextBox.Text = this.organizationInfo.INN;
            this.kppMaskedTextBox.Text = this.organizationInfo.CPP;

            if (this.organizationInfo.BankAccounts != null)
            {
                foreach (var bankAccount in this.organizationInfo.BankAccounts)
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
            var addBankAccountForm = new BankAccountForm();

            addBankAccountForm.BankAccountFinded += this.AddBankAccount;

            addBankAccountForm.Show();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBAccountButtonClick(object sender, EventArgs e)
        {
            var bankAccount = this.organizationInfo.BankAccounts.FirstOrDefault(acc => acc.CurrentAccount == this.baknInfoListBox.SelectedItem.ToString());

            var addBankAccountForm = new BankAccountForm(this.baknInfoListBox.SelectedIndex, bankAccount);

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
            var bancAccount = this.organizationInfo.BankAccounts.FirstOrDefault(a => a.CurrentAccount == this.baknInfoListBox.SelectedItem.ToString());

            this.organizationInfo.BankAccounts.ToList().Remove(bancAccount);

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

    public class OrganizationInfoEventsArgs : EventArgs
    {
        public OrganizationInfo OrganizationInfo { get; set; }

        public int? SelectedIndex { get; set; }
    }
}
