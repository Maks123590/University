namespace WordInteractionLab8.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using WordInteractionLab8.Models.Interfaces;

    public class PaymentOrderFinder : IPaymentOrderFinder
    {
        private ApplicationContext db;

        public PaymentOrderFinder()
        {
            this.db = new ApplicationContext();
        }

        public Payment FindPaymentOrderByNumber(string number)
        {
            var tempNumber = long.Parse(number);

            return this.db.Payments.FirstOrDefault(p => p.Number == tempNumber);
        }

        public IEnumerable<Payment> GetAllPayments()
        {
            return this.db.Payments;
        }
    }
}