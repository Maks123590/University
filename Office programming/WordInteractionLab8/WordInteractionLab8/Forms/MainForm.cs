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
            this.FillAllPayments();
        }

        private void AddPaymentButtonClick(object sender, EventArgs e)
        {
            var addPaymentForm = new PaymentForm();

            addPaymentForm.OrganizationFinded += this.PaymentInfoToDb;

            addPaymentForm.ShowDialog();
        }


        private void EditPaymentButtonClick(object sender, EventArgs e)
        {
            var number = this.PaymentsListBox.SelectedItem.ToString();

            var payment = this.paymentOrderFinder.FindPaymentOrderByNumber(number);

            var addPaymentForm = new PaymentForm(payment, this.PaymentsListBox.SelectedIndex);

            addPaymentForm.OrganizationFinded += this.PaymentInfoToDb;

            addPaymentForm.ShowDialog();
        }

        private void DeletePaymentButtonClick(object sender, EventArgs e)
        {
            var selectedName = this.PaymentsListBox.SelectedItem.ToString();

            var payment = this.paymentOrderFinder.FindPaymentOrderByNumber(selectedName);

            this.RefreshPaymentsListBox(payment, ItemChangeStatus.Removed, this.PaymentsListBox.SelectedIndex);

            this.dbChanger.RemovePaymentOrderFromDb(payment);
        }

        private void PaymentInfoToDb(object sender, PaymentEventsArgs paymentEventsArgs)
        {
            if (paymentEventsArgs.Status == ItemChangeStatus.Added)
            {
                this.dbChanger.AddPaymentOrderToDb(paymentEventsArgs.Payment);
            }
            else if (paymentEventsArgs.Status == ItemChangeStatus.Edited)
            {
                this.dbChanger.ChangePaymentOrderInDb(paymentEventsArgs.Payment);
            }
            else
            {
                this.dbChanger.RemovePaymentOrderFromDb(paymentEventsArgs.Payment);
            }

            this.RefreshPaymentsListBox(paymentEventsArgs.Payment, paymentEventsArgs.Status, paymentEventsArgs.SelectedIndex);
        }

        private void RefreshPaymentsListBox(Payment payment, ItemChangeStatus status, int? selectedIndex)
        {
            if (status == ItemChangeStatus.Added)
            {
                this.PaymentsListBox.Items.Add(payment.Number);
            }
            else if (status == ItemChangeStatus.Edited)
            {
                this.PaymentsListBox.Items[(int)selectedIndex] = payment.Number;
            }
            else
            {
                this.PaymentsListBox.Items.RemoveAt((int)selectedIndex);
            }
        }

        private void FillAllPayments()
        {
            this.PaymentsListBox.Items.Clear();

            var payments = this.paymentOrderFinder.GetAllPayments();

            foreach (var payment in payments)
            {
                this.PaymentsListBox.Items.Add(payment.Number);
            }
        }

        #region organization

        private void AddOrganizationButtonClick(object sender, EventArgs e)
        {
            var addOrganizationForm = new OrganizationForm();

            addOrganizationForm.OrganizationFinded += this.OrganizationInfoToDb;

            addOrganizationForm.ShowDialog();
        }

        private void EditOrganizationButtonClick(object sender, EventArgs e)
        {
            var selectedName = this.organizationMainListBox.Items[this.organizationMainListBox.SelectedIndex]
                .ToString();

            var organization = this.organizationInfoFinder.FindOrganizationByName(selectedName);

            var organizationBankAccounts = this.bankAccountFinder.FindByOrganizationId(organization.Id);

            var editOrganizationForm = new OrganizationForm(organizationBankAccounts, this.organizationMainListBox.SelectedIndex, organization);

            editOrganizationForm.OrganizationFinded += this.OrganizationInfoToDb;

            editOrganizationForm.ShowDialog();
        }

        private void DeleteOrganizationButtonClick(object sender, EventArgs e)
        {
            var selectedName = this.organizationMainListBox.Items[this.organizationMainListBox.SelectedIndex].ToString();

            var organization = this.organizationInfoFinder.FindOrganizationByName(selectedName);

            this.RefreshOrganizationMainListBox(organization, ItemChangeStatus.Removed, this.organizationMainListBox.SelectedIndex);

            foreach (var account in this.bankAccountFinder.FindByOrganizationId(organization.Id))
            {
                this.dbChanger.RemoveBankAccountFromDb(account);
            }

            this.dbChanger.RemoveOrganizationFromDb(organization);
        }


        private void OrganizationInfoToDb(object sender, OrganizationInfoEventsArgs organizationInfoEventsArgs)
        {
            this.RefreshOrganizationMainListBox(organizationInfoEventsArgs.OrganizationInfo, organizationInfoEventsArgs.Status, organizationInfoEventsArgs.SelectedIndex);

            if (organizationInfoEventsArgs.Status == ItemChangeStatus.Added)
            {
                this.dbChanger.AddOrganizationToDb(organizationInfoEventsArgs.OrganizationInfo);

                var organizationId = this.organizationInfoFinder.FindOrganizationByName(organizationInfoEventsArgs.OrganizationInfo.Name).Id;

                foreach (var account in organizationInfoEventsArgs.AddedBankAccounts)
                {
                    account.OrganizationId = organizationId;
                }

                foreach (var account in organizationInfoEventsArgs.EditedBankAccounts)
                {
                    account.OrganizationId = organizationId;
                }

                foreach (var account in organizationInfoEventsArgs.RemovedBankAccounts)
                {
                    account.OrganizationId = organizationId;
                }
            }
            else if (organizationInfoEventsArgs.Status == ItemChangeStatus.Edited)
            {
                this.dbChanger.ChangeOrganizationInDb(organizationInfoEventsArgs.OrganizationInfo);
            }
            else
            {
                this.dbChanger.RemoveOrganizationFromDb(organizationInfoEventsArgs.OrganizationInfo);
            }
            
            if (organizationInfoEventsArgs.AddedBankAccounts != null)
            {
                foreach (var account in organizationInfoEventsArgs.AddedBankAccounts)
                {
                    this.dbChanger.AddBankAccountToDb(account);
                }
            }

            if (organizationInfoEventsArgs.EditedBankAccounts != null)
            {
                foreach (var account in organizationInfoEventsArgs.EditedBankAccounts)
                {
                    this.dbChanger.ChangeBankAccountInDb(account);
                }
            }

            if (organizationInfoEventsArgs.RemovedBankAccounts != null)
            {
                foreach (var account in organizationInfoEventsArgs.RemovedBankAccounts)
                {
                    this.dbChanger.RemoveBankAccountFromDb(account);
                }
            }
        }

        private void RefreshOrganizationMainListBox(OrganizationInfo organizationInfo, ItemChangeStatus status, int? editingIndex = null)
        {
            if (status == ItemChangeStatus.Added)
            {
                this.organizationMainListBox.Items.Add(organizationInfo.Name);
            }
            else if (status == ItemChangeStatus.Edited)
            {
                this.organizationMainListBox.Items[(int)editingIndex] = organizationInfo.Name;
            }
            else
            {
                this.organizationMainListBox.Items.RemoveAt((int)editingIndex);
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

            var bankAccounts = this.bankAccountFinder.FindByOrganizationId(organizationInfo.Id);

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
                var bankAccount = this.bankAccountFinder.FindByOrganizationId(organizationInfo.Id).FirstOrDefault(or => or.CurrentAccount == this.bankAccountsListBox.SelectedItem?.ToString());

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

        #endregion
    }
}