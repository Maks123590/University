namespace WordInteractionLab8.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IPaymentOrderFinder
    {
        Payment FindPaymentOrderByNumber(string number);

        IEnumerable<Payment> GetAllPayments();
    }
}