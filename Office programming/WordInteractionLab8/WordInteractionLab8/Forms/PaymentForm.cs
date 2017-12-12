using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordInteractionLab8.Forms
{
    using WordInteractionLab8.IoC;
    using WordInteractionLab8.Models;
    using WordInteractionLab8.Models.Interfaces;

    public partial class PaymentForm : Form
    {
        private Payment payment;
        private ItemChangeStatus status;

        private IOrganizationFinder organizationFinder = ServiceLocator.GetService<IOrganizationFinder>();
        private IBankAccountFinder bankAccountFinder = ServiceLocator.GetService<IBankAccountFinder>();
        private IBankInfoFinder bankInfoFinder = ServiceLocator.GetService<IBankInfoFinder>();


        public PaymentForm()
        {
            this.InitializeComponent();

            this.InitializaComboBoxes();

            this.status = ItemChangeStatus.Added;
        }

        public PaymentForm(Payment payment, int selectedIndex) : this()
        {
            this.payment = payment;
            this.SelectedIndex = selectedIndex;

            this.status = ItemChangeStatus.Edited;

            this.FillPreInfo(payment);
        }

        public event EventHandler<PaymentEventsArgs> OrganizationFinded;

        public int? SelectedIndex { get; set; }

        protected virtual void OnPaymentOrderFilled(PaymentEventsArgs e)
        {
            EventHandler<PaymentEventsArgs> handler = this.OrganizationFinded;

            handler?.Invoke(this, e);
        }

        private void InitializaComboBoxes()
        {
            var organizations = this.organizationFinder.GetAllOrganizations();

            foreach (var organization in organizations)
            {
                this.SenderNameComboBox.Items.Add(organization.Name);
                this.addresseeNameComboBox.Items.Add(organization.Name);
            }
        }

        private void FillPreInfo(Payment payment)
        {
            this.payNumberMaskedTextBox.Text = payment.Number.ToString();
            this.paymentDateTimePicker.Value = payment.Date;

            switch (payment.Type)
            {
                case PaymentType.None: payTypeComboBox.SelectedIndex = 0;
                    break;
                case PaymentType.Urgent: payTypeComboBox.SelectedIndex = 1;
                    break;
                case PaymentType.Electronic: payTypeComboBox.SelectedIndex = 2;
                    break;
                case PaymentType.Telegraph: payTypeComboBox.SelectedIndex = 3;
                    break;
                case PaymentType.Postal: payTypeComboBox.SelectedIndex = 4;
                    break;
            }

            this.rubMaskedTextBox.Text = payment.Rub.ToString();
            this.copMaskedTextBox.Text = payment.Cop.ToString();
            this.payDescriptionTextBox.Text = payment.Details;
            this.PayQueueComboBox.Text = payment.Queue.ToString();

            //// Organizations

            var payer = this.organizationFinder.FindByOrganizationId(payment.PayerId);
            var payee = this.organizationFinder.FindByOrganizationId(payment.PayeeId);

            this.SenderNameComboBox.Text = payer.Name;
            this.addresseeNameComboBox.Text = payee.Name;

            var payerBankAccounts = this.bankAccountFinder.FindByOrganizationId(payer.Id);
            var payeeBankAccounts = this.bankAccountFinder.FindByOrganizationId(payee.Id);

            this.RefreshCurrentAccounts(this.SenderAccComboBox, payerBankAccounts);
            this.RefreshCurrentAccounts(this.addresseeAccComboBox, payeeBankAccounts);

            var payerBankAccount = this.bankAccountFinder.FindById(payment.PayerAccountId);
            var payeeBankAccount = this.bankAccountFinder.FindById(payment.PayeeAccountId);

            this.SenderAccComboBox.Text = payerBankAccount.CurrentAccount;
            this.addresseeAccComboBox.Text = payeeBankAccount.CurrentAccount;

            var payerBank = this.bankInfoFinder.GetBankInfoByBic(payerBankAccount.BankBic);
            var payeeBank = this.bankInfoFinder.GetBankInfoByBic(payeeBankAccount.BankBic);

            this.senderBicLabel.Text = payerBankAccount.BankBic;
            this.senderBankNameLanbel.Text = payerBank.FullName;
            this.senderBankLocationLabel.Text = payerBank.Locality;

            this.addresseeBikLabel.Text = payeeBankAccount.BankBic;
            this.addresseeBankNameLabel.Text = payeeBank.FullName;
            this.addresseeBankLocationLabel.Text = payeeBank.Locality;

            //// Additionals
            
            //// TODO
        }

        private Payment GetAggregatePayment()
        {
            var payment = new Payment();

            payment.Number = int.Parse(this.payNumberMaskedTextBox.Text);

            payment.Date = this.paymentDateTimePicker.Value;

            switch (this.payTypeComboBox.SelectedIndex)
            {
                case 0: payment.Type = PaymentType.None;
                    break;
                case 1:
                    payment.Type = PaymentType.Urgent;
                    break;
                case 2:
                    payment.Type = PaymentType.Electronic;
                    break;
                case 3:
                    payment.Type = PaymentType.Telegraph;
                    break;
                case 4:
                    payment.Type = PaymentType.Postal;
                    break;
            }

            payment.Rub = int.Parse(this.rubMaskedTextBox.Text);
            payment.Cop = byte.Parse(this.copMaskedTextBox.Text);

            payment.Details = this.payDescriptionTextBox.Text;
            payment.Queue = byte.Parse(this.PayQueueComboBox.Text);

            //// Organizations

            var payer = this.organizationFinder.FindOrganizationByName(this.SenderNameComboBox.Text);
            var payee = this.organizationFinder.FindOrganizationByName(this.addresseeNameComboBox.Text);

            payment.PayerId = payer.Id;
            payment.PayeeId = payee.Id;

            var payerAcc = this.bankAccountFinder.FindByOrganizationId(payer.Id).FirstOrDefault(a => a.CurrentAccount == this.SenderAccComboBox.Text);
            var payeeAcc = this.bankAccountFinder.FindByOrganizationId(payee.Id).FirstOrDefault(a => a.CurrentAccount == this.addresseeAccComboBox.Text);

            payment.PayerAccountId = payerAcc.Id;
            payment.PayeeAccountId = payeeAcc.Id;

            //// Additionals
            
            payment.DocumentDateIndicator = DateTime.Now;
            payment.TaxPeriodIndicator = DateTime.Now;

            //// TODO

            return payment;
        }

        private void RefreshCurrentAccounts(ComboBox combobox, IEnumerable<BankAccount> bankAccounts)
        {
            combobox.Items.Clear();

            foreach (var account in bankAccounts)
            {
                combobox.Items.Add(account.CurrentAccount);
            }
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            //// TODO Model Validate


            this.OnPaymentOrderFilled(new PaymentEventsArgs
                                          {
                                              Payment = this.GetAggregatePayment(),
                                              SelectedIndex = this.SelectedIndex,
                                              Status = this.status
                                          });

            this.Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SenderNameComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var organization = this.organizationFinder.FindOrganizationByName(this.SenderNameComboBox.Text);
             var bankAccounts = this.bankAccountFinder.FindByOrganizationId(organization.Id);

            this.RefreshCurrentAccounts(this.SenderAccComboBox, bankAccounts);
        }

        private void AddresseeNameComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var organization = this.organizationFinder.FindOrganizationByName(this.addresseeNameComboBox.Text);
            var bankAccounts = this.bankAccountFinder.FindByOrganizationId(organization.Id);

            this.RefreshCurrentAccounts(this.addresseeAccComboBox, bankAccounts);
        }
    }

    public class PaymentEventsArgs : EventArgs
    {
        public Payment Payment { get; set; }

        public ItemChangeStatus Status { get; set; }

        public int? SelectedIndex { get; set; }
    }
}
