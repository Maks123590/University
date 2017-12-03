namespace WordInteractionLab8.Models
{
    using System;

    public enum PaymentType
    {
        None,
        Urgent,
        Electronic,
        Telegraph,
        Postal
    }

    public enum PaymentBasis
    {

    }

    public enum PayerStatus
    {

    }

    public class Payment
    {
        public int Id { get; set; }

        public uint Number { get; set; }

        public PaymentType Type { get; set; }

        public decimal PaymentAmount { get; set; }

        public string Details { get; set; }

        public OrganizetionInfo Payer { get; set; }

        public OrganizetionInfo Payee { get; set; }

        public byte Queue { get; set; }

        public PaymentBasis Basis { get; set; }

        public PayerStatus Status { get; set; }

        public string Address { get; set; }

        public string KBK { get; set; }

        public string OKTMO { get; set; }

        public DateTime TaxPeriodIndicator { get; set; }

        public string CustomsCode { get; set; }

        public string DocumentNumberIndicator { get; set; }

        public DateTime DocumentDateIndicator { get; set; }
    }
}