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
    }
}