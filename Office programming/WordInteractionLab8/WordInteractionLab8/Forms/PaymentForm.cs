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
        }

        public PaymentForm(Payment payment, int selectedIndex) : this()
        {
            this.payment = payment;
            this.SelectedIndex = selectedIndex;

            this.FillPreInfo(payment);
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
            this.PayQueueComboBox.SelectedText = payment.Queue.ToString();

            //// Organizations

            this.SenderNameComboBox.SelectedText = payment.Payer.Name;
            this.addresseeNameComboBox.SelectedText = payment.Payee.Name;


            var payer = this.organizationFinder.FindOrganizationByName(payment.Payer.Name);
            var payee = this.organizationFinder.FindOrganizationByName(payment.Payee.Name);

            var payerBankAccounts = this.bankAccountFinder.FindBankAccountsByOrganizationId(payer.Id);
            var payeeBankAccounts = this.bankAccountFinder.FindBankAccountsByOrganizationId(payee.Id);

            this.RefresCurrentAccounts(this.SenderAccComboBox, payerBankAccounts);
            this.RefresCurrentAccounts(this.addresseeAccComboBox, payeeBankAccounts);

            this.SenderAccComboBox.SelectedText = payment.PayerAccount.CurrentAccount;
            this.addresseeAccComboBox.SelectedText = payment.PayeeAccount.CurrentAccount;

            var payerBank = this.bankInfoFinder.GetBankInfoByBic(payment.PayerAccount.BankBic);
            var payeeBank = this.bankInfoFinder.GetBankInfoByBic(payment.PayeeAccount.BankBic);

            this.senderBicLabel.Text = payment.PayerAccount.BankBic;
            this.senderBankNameLanbel.Text = payerBank.FullName;
            this.senderBankLocationLabel.Text = payerBank.Locality;

            this.addresseeBikLabel.Text = payment.PayeeAccount.BankBic;
            this.addresseeBankNameLabel.Text = payeeBank.FullName;
            this.addresseeBankLocationLabel.Text = payeeBank.Locality;

            //// Additionals
            
            //// TODO
        }

        private Payment GetBuildPayment()
        {
            var payment = new Payment();

            payment.Number = uint.Parse(this.payNumberMaskedTextBox.Text);

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

            payment.Rub = uint.Parse(this.rubMaskedTextBox.Text);
            payment.Cop = uint.Parse(this.copMaskedTextBox.Text);

            payment.Details = this.payDescriptionTextBox.Text;
            payment.Queue = byte.Parse(this.PayQueueComboBox.SelectedText);

            //// Organizations

            payment.Payer = new OrganizationInfo();
            payment.Payee = new OrganizationInfo();

            payment.Payer.Name = this.SenderNameComboBox.SelectedText;
            payment.Payee.Name = this.addresseeNameComboBox.SelectedText;

            var payer = this.organizationFinder.FindOrganizationByName(payment.Payer.Name);
            var payee = this.organizationFinder.FindOrganizationByName(payment.Payee.Name);

            payment.Payer.Name = payer.Name;
            payment.Payer.CPP = payer.CPP;
            payment.Payer.INN = payer.INN;

            payment.Payee.Name = payee.Name;
            payment.Payee.CPP = payee.CPP;
            payment.Payee.INN = payee.INN;

            payment.PayerAccount = new BankAccount();
            payment.PayeeAccount = new BankAccount();

            payment.PayerAccount.CurrentAccount = this.SenderAccComboBox.SelectedText;
            payment.PayeeAccount.CurrentAccount = this.addresseeAccComboBox.SelectedText;

            payment.PayerAccount.BankBic = this.senderBicLabel.Text;
            payment.PayeeAccount.BankBic = this.addresseeBikLabel.Text;

            payment.PayerAccount.OrganizationId = payment.PayerAccount.Id;
            payment.PayeeAccount.OrganizationId = payment.PayeeAccount.Id;

            //// Additionals

            //// TODO

            return payment;

        }

        private void RefresCurrentAccounts(ComboBox combobox, IEnumerable<BankAccount> bankAccounts)
        {
            combobox.Items.Clear();

            foreach (var account in bankAccounts)
            {
                combobox.Items.Add(account.CurrentAccount);
            }
        }

        public int? SelectedIndex { get; set; }

        private void okButton_Click(object sender, EventArgs e)
        {

        }
    }

    public class PaymentEventsArgs : EventArgs
    {
        public Payment Payment { get; set; }

        public ItemChangeStatus Status { get; set; }

        public int? SelectedIndex { get; set; }
    }
}
