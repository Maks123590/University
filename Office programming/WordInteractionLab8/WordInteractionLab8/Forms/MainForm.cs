namespace WordInteractionLab8.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using WordInteractionLab8.Components;
    using WordInteractionLab8.IoC;
    using WordInteractionLab8.Models;
    using WordInteractionLab8.Models.Interfaces;
    using WordInteractionLab8.Resources;

    using ApplicationContext = WordInteractionLab8.Models.ApplicationContext;

    public partial class MainForm : Form
    {
        private ApplicationContext db = new ApplicationContext();

        public MainForm()
        {
            this.InitializeComponent();

            this.FillAllOrganizations();
        }

        private void IntoDocumentButtonClick(object sender, EventArgs e)
        {
        }

        private void AddPaymentButtonClick(object sender, EventArgs e)
        {
            var addPaymentForm = new EditPaymentForm();

            addPaymentForm.ShowDialog();
        }

        private void AddOrganizationButtonClick(object sender, EventArgs e)
        {
            var addOrganizationForm = new OrganizationForm();

            addOrganizationForm.OrganizationFinded += this.AddBankAccount;

            addOrganizationForm.ShowDialog();
        }

        private void EditOrganizationButtonClick(object sender, EventArgs e)
        {
            var selectedName = this.organizationMainListBox.Items[this.organizationMainListBox.SelectedIndex]
                .ToString();

            var organization = db.Organizations.FirstOrDefault(oInf => oInf.Name == selectedName);

            var organizationBankAccounts = this.db.BankAccounts.Where(ac => ac.OrganizationId == organization.Id);

            var editOrganizationForm = new OrganizationForm(organizationBankAccounts, this.organizationMainListBox.SelectedIndex, organization);

            editOrganizationForm.OrganizationFinded += this.AddBankAccount;

            editOrganizationForm.Show();
        }

        private void AddBankAccount(object sender, OrganizationInfoEventsArgs organizationInfoEventsArgs)
        {
            this.RefreshListBox(organizationInfoEventsArgs.OrganizationInfo, organizationInfoEventsArgs.SelectedIndex);

            var organizationId = this.AddOrganizationToDb(organizationInfoEventsArgs.OrganizationInfo);

            if (organizationInfoEventsArgs.BankAccounts != null)
            {
                foreach (var account in organizationInfoEventsArgs.BankAccounts)
                {
                    account.OrganizationId = organizationId;
                }

                AddBankAccountToDb(organizationInfoEventsArgs.BankAccounts);
            }
        }

        private void RefreshListBox(OrganizationInfo organizationInfo, int? editingIndex = null)
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

        private int AddOrganizationToDb(OrganizationInfo organizationInfo)
        {
            var organization = this.db.Organizations.FirstOrDefault(org => org.Id == organizationInfo.Id);

            if (organization != null)
            {
                organization = organizationInfo;
            }
            else
            {
                this.db.Organizations.Add(organizationInfo);
            }

            this.db.SaveChanges();

            return this.db.Organizations.FirstOrDefault(o => o.Name == organizationInfo.Name).Id;
        }

        private void AddBankAccountToDb(BankAccount[] bankAccounts)
        {
            foreach (var bankAccount in bankAccounts)
            {
                var bankAcc = this.db.BankAccounts.FirstOrDefault(ba => ba.Id == bankAccount.Id);

                if (bankAcc != null)
                {
                    bankAcc = bankAccount;
                }
                else
                {
                    this.db.BankAccounts.Add(bankAccount);
                }
            }
            
            this.db.SaveChanges();
        }

        private void OrganizationMainListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var index = this.organizationMainListBox.SelectedIndex;

            if (index != -1)
            {
                var selectedName = this.organizationMainListBox.Items[this.organizationMainListBox.SelectedIndex]
                    .ToString();

                var organizationInfo = db.Organizations.FirstOrDefault(oInf => oInf.Name == selectedName);

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

            if (this.db.BankAccounts.Any(ac => ac.OrganizationId == organizationInfo.Id))
            {
                foreach (var bankAccount in this.db.BankAccounts.Where(ac => ac.OrganizationId == organizationInfo.Id))
                {
                    this.bankAccountsListBox.Items.Add(bankAccount.CurrentAccount);
                }
            }

            this.organizationInfoPanel.Visible = true;
        }

        private void FillBankAccountInfo(BankAccount bankAccount)
        {
            var bankInfo = ServiceLocator.GetService<IBankInfoFinder>().GetBankInfoByBic(bankAccount.BankBic);

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

            var organizationInfo = db.Organizations.FirstOrDefault(oInf => oInf.Name == selectedName);

            if (organizationInfo != null)
            {
                var bankAccount = this.db.BankAccounts.FirstOrDefault(
                    a => (a.OrganizationId == organizationInfo.Id) && (a.CurrentAccount == this.bankAccountsListBox.SelectedItem.ToString()));

                this.FillBankAccountInfo(bankAccount);
            }
        }

        private void FillAllOrganizations()
        {
            var organizations = this.db.Organizations;

            foreach (var organization in organizations)
            {
                this.organizationMainListBox.Items.Add(organization.Name);
            }
        }
    }
}
