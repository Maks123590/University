namespace WordInteractionLab8.Forms
{
    using System;
    using System.Windows.Forms;

    using WordInteractionLab8.Models;
    using WordInteractionLab8.Resources;

    public partial class BankAccountForm : Form
    {
        private readonly BankAccount bankAccount;

        private readonly Action<BankAccount, int?> refreshInfo;

        public BankAccountForm(Action<BankAccount, int?> refreshInfo)
        {
            this.InitializeComponent();

            this.bankAccount = new BankAccount { BankInfo = new BankInfo() };

            this.refreshInfo = refreshInfo;  
        }

        public BankAccountForm(Action<BankAccount, int?> refreshInfo, int selectedIndex, BankAccount bankAccount) : this(refreshInfo)
        {
            this.bankAccount = bankAccount;

            if (bankAccount.BankInfo != null)
            {
                this.FillBankInfo(bankAccount.BankInfo);
            }
            else
            {
                this.bankAccount.BankInfo = new BankInfo();
            }

            this.SelectedIndex = selectedIndex;

            this.currAccMaskedTextBox.Text = this.bankAccount.CurrentAccount ?? string.Empty;
        }

        public int? SelectedIndex { get; }

        private void OkButtonClick(object sender, EventArgs e)
        {
            if (this.nameMaskedTextBox.Text != string.Empty && this.bikMaskedTextBox.Text != string.Empty
                && this.locationMaskedTextBox.Text != string.Empty && this.correspAccMaskedTextBox.Text != string.Empty
                && this.currAccMaskedTextBox.Text != string.Empty)
            {
                this.bankAccount.BankInfo.FullName = this.nameMaskedTextBox.Text;
                this.bankAccount.BankInfo.Bic = this.bikMaskedTextBox.Text;
                this.bankAccount.BankInfo.Locality = this.locationMaskedTextBox.Text;
                this.bankAccount.BankInfo.CorrespondentAccount = this.correspAccMaskedTextBox.Text;
                this.bankAccount.CurrentAccount = this.currAccMaskedTextBox.Text;

                this.refreshInfo(this.bankAccount, this.SelectedIndex);

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
            var xmlDbBankInfo = XmlParser.GetBankInfoByBik(this.bikMaskedTextBox.Text);

            this.FillBankInfo(xmlDbBankInfo);
        }

        private void FillBankInfo(BankInfo bankInfo)
        {
            this.nameMaskedTextBox.Text = bankInfo.FullName;
            this.bikMaskedTextBox.Text = bankInfo.Bic;
            this.locationMaskedTextBox.Text = bankInfo.Locality;
            this.correspAccMaskedTextBox.Text = bankInfo.CorrespondentAccount;
        }
    }
}
