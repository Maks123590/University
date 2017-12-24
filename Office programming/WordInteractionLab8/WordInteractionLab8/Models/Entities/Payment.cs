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
        Нет,
        ТП,
        ЗД,
        БФ,
        ТР,
        РС,
        ОТ,
        РТ,
        ПБ,
        ПР,
        АП,
        АР,
        ИН,
        ТЛ,
        ЗТ,
        ДЕ,
        ПО,
        КТ,
        ИД
    }

    public class Payment
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public DateTime Date { get; set; }

        public PaymentType Type { get; set; }

        public int Rub { get; set; }

        public int Cop { get; set; }

        public string Details { get; set; }

        public int PayerId { get; set; }

        public int PayeeId { get; set; }

        public int PayerAccountId { get; set; }

        public int PayeeAccountId { get; set; }

        public byte Queue { get; set; }

        public PaymentBasis Basis { get; set; }

        public int Status { get; set; }

        public string Address { get; set; }

        public string KBK { get; set; }

        public string OKTMO { get; set; }

        public string TaxPeriodIndicatorDay { get; set; }

        public string TaxPeriodIndicatorMonth { get; set; }

        public string TaxPeriodIndicatorYear { get; set; }

        public string CustomsCode { get; set; }

        public string DocumentNumberIndicator { get; set; }

        public DateTime DocumentDateIndicator { get; set; }
    }
}