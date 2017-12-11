namespace WordInteractionLab8.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using WordInteractionLab8.IoC;
    using WordInteractionLab8.Models;
    using WordInteractionLab8.Models.Interfaces;
    using WordInteractionLab8.Resources;

    using ApplicationContext = WordInteractionLab8.Models.ApplicationContext;

    public partial class MainForm : Form
    {
        private IDbChanger dbChanger;

        private IBankInfoFinder bankInfoFinder;

        private IBankAccountFinder bankAccountFinder;
        private IOrganizationFinder organizationInfoFinder;
        private IPaymentOrderFinder paymentOrderFinder;

        public MainForm()
        {
            this.InitializeComponent();

            this.bankInfoFinder = ServiceLocator.GetService<IBankInfoFinder>();

            this.bankAccountFinder = ServiceLocator.GetService<IBankAccountFinder>();
            this.organizationInfoFinder = ServiceLocator.GetService<IOrganizationFinder>();
            this.paymentOrderFinder = ServiceLocator.GetService<IPaymentOrderFinder>();

            this.dbChanger = ServiceLocator.GetService<IDbChanger>();

            this.FillAllOrganizations();
        }

        private void AddPaymentButtonClick(object sender, EventArgs e)
        {
            var addPaymentForm = new EditPaymentForm();

            addPaymentForm.ShowDialog();
        }

        private void AddOrganizationButtonClick(object sender, EventArgs e)
        {
            var addOrganizationForm = new OrganizationForm();

            addOrganizationForm.OrganizationFinded += this.AddOrganizationInfo;

            addOrganizationForm.ShowDialog();
        }

        private void EditOrganizationButtonClick(object sender, EventArgs e)
        {
            var selectedName = this.organizationMainListBox.Items[this.organizationMainListBox.SelectedIndex]
                .ToString();

            var organization = this.organizationInfoFinder.FindOrganizationByName(selectedName);

            var organizationBankAccounts = this.bankAccountFinder.FindBankAccountsByOrganizationId(organization.Id);

            var editOrganizationForm = new OrganizationForm(organizationBankAccounts, this.organizationMainListBox.SelectedIndex, organization);

            editOrganizationForm.OrganizationFinded += this.AddOrganizationInfo;

            editOrganizationForm.Show();
        }

        private void AddOrganizationInfo(object sender, OrganizationInfoEventsArgs organizationInfoEventsArgs)
        {
            this.RefreshOrganizationMainListBox(organizationInfoEventsArgs.OrganizationInfo, organizationInfoEventsArgs.SelectedIndex);

            this.dbChanger.AddOrganizationToDb(organizationInfoEventsArgs.OrganizationInfo);

            if (organizationInfoEventsArgs.BankAccounts != null)
            {
                foreach (var account in organizationInfoEventsArgs.BankAccounts)
                {
                    account.OrganizationId = this.organizationInfoFinder.FindOrganizationByName(organizationInfoEventsArgs.OrganizationInfo.Name).Id;

                    this.dbChanger.AddBankAccountToDb(account);
                }
            }
        }

        private void RefreshOrganizationMainListBox(OrganizationInfo organizationInfo, int? editingIndex = null)
        {
            if (editingIndex == null)
            {
                this.organizationMainListBox.Items.Add(organizationInfo.Name);
            }
            else
            {
                this.organizationMainListBox.Items[(int)editingIndex] = organizationInfo.Name;
            }
        }

        private void OrganizationMainListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var index = this.organizationMainListBox.SelectedIndex;

            if (index != -1)
            {
                var selectedName = this.organizationMainListBox.Items[this.organizationMainListBox.SelectedIndex]
                    .ToString();

                var organizationInfo = this.organizationInfoFinder.FindOrganizationByName(selectedName);

                this.FillMainOrganizationInfo(organizationInfo);
            }
        }

        private void FillMainOrganizationInfo(OrganizationInfo organizationInfo)
        {
            if (organizationInfo == null)
            {
                return;
            }

            this.organizationNameLabel.Text = organizationInfo.Name;
            this.cppOrganizationLabel.Text = organizationInfo.CPP;
            this.innOrganizationLabel.Text = organizationInfo.INN;

            this.bankAccountsListBox.Items.Clear();

            var bankAccounts = this.bankAccountFinder.FindBankAccountsByOrganizationId(organizationInfo.Id);

            if (bankAccounts != null)
            {
                foreach (var bankAccount in bankAccounts)
                {
                    this.bankAccountsListBox.Items.Add(bankAccount.CurrentAccount);
                }
            }

            this.organizationInfoPanel.Visible = true;
        }

        private void FillBankAccountInfo(BankAccount bankAccount)
        {
            var bankInfo = this.bankInfoFinder.GetBankInfoByBic(bankAccount.BankBic);

            this.bankNameLabel.Text = bankInfo.FullName;
            this.bankLocationLabel.Text = bankInfo.Locality;
            this.bikLabel.Text = bankInfo.Bic;

            this.currentAccountlLabel.Text = bankAccount.CurrentAccount;

            this.bankAccInfoPanel.Visible = true;
        }

        private void BankAccountsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedName = this.organizationMainListBox.Items[this.organizationMainListBox.SelectedIndex]
                .ToString();

            var organizationInfo = this.organizationInfoFinder.FindOrganizationByName(selectedName);

            if (organizationInfo != null && this.bankAccountsListBox.SelectedItem != null)
            {
                var bankAccount = this.bankAccountFinder.FindBankAccountsByOrganizationId(organizationInfo.Id).FirstOrDefault(or => or.CurrentAccount == this.bankAccountsListBox.SelectedItem?.ToString());

                this.FillBankAccountInfo(bankAccount);
            }
        }

        private void FillAllOrganizations()
        {
            var organizations = this.organizationInfoFinder.GetAllOrganizations();

            foreach (var organization in organizations)
            {
                this.organizationMainListBox.Items.Add(organization.Name);
            }
        }

        private void DeleteOrganizationButtonClick(object sender, EventArgs e)
        {
        }
    }
}
