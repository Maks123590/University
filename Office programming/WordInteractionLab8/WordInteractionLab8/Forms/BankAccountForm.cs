namespace WordInteractionLab8.Forms
{
    using System;
    using System.Windows.Forms;

    using WordInteractionLab8.IoC;
    using WordInteractionLab8.Models;
    using WordInteractionLab8.Models.Interfaces;
    using WordInteractionLab8.Resources;

    public partial class BankAccountForm : Form
    {
        private readonly BankAccount bankAccount;

        private readonly IBankInfoFinder bankInfoFinder;

        private readonly OrganizationInfo organizationInfo;

        public BankAccountForm(OrganizationInfo organization)
        {
            this.InitializeComponent();

            this.bankAccount = new BankAccount { OrganizationId = organization.Id };

            this.organizationInfo = organization;

            this.bankInfoFinder = ServiceLocator.GetService<IBankInfoFinder>();
        }

        public BankAccountForm(OrganizationInfo organization, int selectedIndex, BankAccount bankAccount) : this(organization)
        {
            this.bankAccount = bankAccount ?? new BankAccount();

            this.FillBankInfo(this.bankInfoFinder.GetBankInfoByBic(this.bankAccount.BankBic));

            this.SelectedIndex = selectedIndex;

            this.currAccMaskedTextBox.Text = this.bankAccount.CurrentAccount ?? string.Empty;
        }

        public event EventHandler<BankInfoEventsArgs> BankAccountFinded;

        public int? SelectedIndex { get; }

        protected virtual void OnBankAccountFinded(BankInfoEventsArgs e)
        {
            EventHandler<BankInfoEventsArgs> handler = this.BankAccountFinded;

            handler?.Invoke(this, e);
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            if (this.nameMaskedTextBox.Text != string.Empty && this.bikMaskedTextBox.Text != string.Empty
                && this.locationMaskedTextBox.Text != string.Empty && this.correspAccMaskedTextBox.Text != string.Empty
                && this.currAccMaskedTextBox.Text != string.Empty)
            {
                this.bankAccount.BankBic = this.bikMaskedTextBox.Text;
                this.bankAccount.CurrentAccount = this.currAccMaskedTextBox.Text;

                this.OnBankAccountFinded(new BankInfoEventsArgs
                                             {
                                                 BankAccount = this.bankAccount,
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

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillByBikButtonClick(object sender, EventArgs e)
        {
            this.FillBankInfo(this.bankInfoFinder.GetBankInfoByBic(this.bikMaskedTextBox.Text));
        }

        private void FillBankInfo(BankInfo bankInfo)
        {
            if (bankInfo == null)
            {
                return;
            }

            this.nameMaskedTextBox.Text = bankInfo.FullName;
            this.bikMaskedTextBox.Text = bankInfo.Bic;
            this.locationMaskedTextBox.Text = bankInfo.Locality;
            this.correspAccMaskedTextBox.Text = bankInfo.CorrespondentAccount;
        }
    }

    public class BankInfoEventsArgs : EventArgs
    {
        public BankAccount BankAccount { get; set; }

        public int? SelectedIndex { get; set; }
    }
}
