namespace WordInteractionLab8.Models
{
    using System;

    public class PaymentView
    {
        public uint Number { get; set; }

        public decimal PaymentAmount { get; set; }

        public string PayerName { get; set; }

        public string PayeeName { get; set; }

        public DateTime Date { get; set; }
    }
}