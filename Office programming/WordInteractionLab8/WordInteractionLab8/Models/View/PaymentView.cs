namespace WordInteractionLab8.Models
{
    using System;

    public class PaymentView
    {
        public string Number { get; set; }

        public string PaymentAmount { get; set; }

        public string PaymentAmountInWords { get; set; }

        public string PaymentType { get; set; }

        public OrganizationView Payer { get; set; }

        public OrganizationView Payee { get; set; }

        public string PayQueue { get; set; }

        public string Description { get; set; }

        public string Date { get; set; }


        public string Basis { get; set; }

        public string Status { get; set; }

        public string Address { get; set; }

        public string KBK { get; set; }

        public string OKTMO { get; set; }

        public string TaxPeriodIndicator { get; set; }

        public string CustomsCode { get; set; }

        public string DocumentNumberIndicator { get; set; }

        public string DocumentDateIndicator { get; set; }
    }
}