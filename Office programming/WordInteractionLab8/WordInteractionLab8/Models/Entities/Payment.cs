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
        TP,
        ZD,
        BF,
        TR,
        RS,
        OT,
        RT,
        PB,
        PR,
        AP,
        AR,
        IN,
        TL,
        ZT,
        DE,
        PO,
        KT,
        ID
    }

    public class Payment
    {
        public int Id { get; set; }

        public uint Number { get; set; }

        public DateTime Date { get; set; }

        public PaymentType Type { get; set; }

        public decimal PaymentAmount { get; set; }

        public string Details { get; set; }

        public OrganizetionInfo Payer { get; set; }

        public OrganizetionInfo Payee { get; set; }

        public byte Queue { get; set; }

        public PaymentBasis Basis { get; set; }

        public int Status { get; set; }

        public string Address { get; set; }

        public string KBK { get; set; }

        public string OKTMO { get; set; }

        public DateTime TaxPeriodIndicator { get; set; }

        public string CustomsCode { get; set; }

        public string DocumentNumberIndicator { get; set; }

        public DateTime DocumentDateIndicator { get; set; }
    }
}